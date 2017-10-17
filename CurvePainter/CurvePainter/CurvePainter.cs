using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CurvePainter
{
    [ToolboxItem(true)]
    public class CurvePainter:Control
    {
        public CurvePainter()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
            this.BackColor = Color.Black;
        }

        #region 属性
        private List<List<float>> dataSource;
        /// <summary>
        /// 数据源
        /// </summary>
        public List<List<float>> DataSource
        {
            get { return dataSource; }
            set
            {
                if (value != null)
                {
                    try
                    {

                        bool isEqualed = true;
                        int count = value[0].Count;
                        value.ForEach(x =>
                        {
                            if (x.Count != count)
                                isEqualed = false;
                        });
                        if (isEqualed)
                        {
                            dataSource = value; Invalidate();
                        }
                        else
                        {
                            throw new Exception("数据源中集合的长度必须相等");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
        }

        private List<string> xElements = new List<string>() { "元素1", "元素2", "元素3", "元素4", "元素5", "元素6", "元素7", "元素8", "元素9", "元素10" };

        /// <summary>
        /// X轴显示的元素
        /// </summary>     
        public List<string> XElements
        {
            get { return xElements; }
            set
            {
                if (value != null)
                {
                    if (DataSource != null)
                    {
                        if (value.Count != DataSource[0].Count)
                            throw new Exception("X轴元素数量必须和数据源元素数量相等");
                        else
                            xElements = value; Invalidate();
                    }
                }
                else
                {
                    xElements = value; Invalidate();
                }
            }
        }

        private float gridValue = 0.1f;

        /// <summary>
        /// Y轴每一单位长度代表的值,默认值0.1
        /// </summary>
        public float GridValue
        {
            get { return gridValue; }
            set { gridValue = value; }
        }

        private float startValue = -1f;

        /// <summary>
        /// Y坐标为0代表的起始值,默认值0
        /// </summary>
        public float StartValue
        {
            get { return startValue; }
            set { startValue = value; }
        }
        private int yGridCount = 20;
        /// <summary>
        /// Y轴的格数,默认值20
        /// </summary>
        public int YGridCount
        {
            get { return yGridCount; }
            set { yGridCount = value; }
        }

        private List<Color> linesColors;

        /// <summary>
        /// 线条颜色
        /// </summary>
        public List<Color> LinesColors
        {
            get { return linesColors; }
            set { linesColors = value; }
        }

        private float standardValue=0f;

        /// <summary>
        /// 标准值
        /// </summary>
        public float StandardValue
        {
            get { return standardValue; }
            set { standardValue = value; }
        }

        private float maxValue;
        /// <summary>
        /// 最大值
        /// </summary>
        public float MaxValue
        {
            get { return maxValue; }
            set { maxValue = value; }
        }

        private float minValue;
        /// <summary>
        /// 最小值
        /// </summary>
        public float MinValue
        {
            get { return minValue; }
            set { minValue = value; }
        }
        #endregion

        public delegate void WarningHandle(object sender, EventArgs e);
        /// <summary>
        /// 超出标准报警事件
        /// </summary>
        public event WarningHandle CurvePainterWarning;
        /// <summary>
        /// 自己绘制
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawXY(this.Size,e.Graphics);
            DrawCurve(e.Graphics,this.Size);
        }

     
        /// <summary>
        /// 画坐标轴
        /// </summary>
        /// <param name="size">控件大小</param>
        /// <param name="g">Graphics对象</param>
        private void DrawXY(Size size, Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TranslateTransform(size.Width / 8, size.Height / 10*9);
          
            Pen penGrid = new Pen(Brushes.LightGray) { DashStyle = DashStyle.Dot, Width = 1.5f };
            for (int i = 1; i <= yGridCount; i++)
            {
                g.DrawLine(penGrid, new PointF(0f, (-i * size.Height * 0.8f * 0.9f / yGridCount)), new PointF(size.Width * 0.75f, (-i * size.Height * 0.8f * 0.9f / yGridCount)));
                //画Y轴刻度
            if (startValue != -1f)
            {
                g.DrawString((startValue+gridValue*i).ToString(),new Font("宋体", 7), Brushes.LightGray,new RectangleF(-g.MeasureString((startValue+gridValue*i).ToString(),new Font("宋体", 7)).Width,-i * size.Height * 0.8f * 0.9f / yGridCount-5f,40,10), StringFormat.GenericDefault);
            }
            }
            
            Pen penXY = new Pen(Brushes.Gray) { StartCap = LineCap.Round, EndCap = LineCap.ArrowAnchor, Width = 3 };
            //X轴
            g.DrawLine(penXY, new PointF(0f, 0f), new PointF(size.Width * 0.75f, 0));
            //Y轴
            g.DrawLine(penXY, new PointF(0f, 0f), new PointF(0, -size.Height / 10 * 8));

            int elementCount = xElements.Count;
            for (int i = 1; i <= elementCount; i++)
            {
                g.DrawLine(penGrid, new PointF(size.Width * 0.75f * 0.9f / elementCount * i, 0), new PointF(size.Width * 0.75f * 0.9f / elementCount * i, -size.Height * 0.8f*0.9f));
                g.DrawString(xElements[i - 1], new Font("宋体", 7), Brushes.LightGray, new RectangleF(size.Width * 0.75f * 0.9f / elementCount * i - 10, 5, 35, 10), StringFormat.GenericDefault);
            }
        }

        /// <summary>
        /// 根据数据源画曲线
        /// </summary>
        /// <param name="g"></param>
        private void DrawCurve(Graphics g,Size size)
        {
            Pen p = new Pen(Brushes.Red);
            p.StartCap = LineCap.Round;  
            p.EndCap = LineCap.Round;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
           //设置连续两段的联接样式  
            p.LineJoin = LineJoin.Round;
            //获取每一像素高度代表的数值
            float value = gridValue / (size.Height * 0.8f * 0.9f / yGridCount);
            //记录越界的值
            Dictionary<string, float> dict = new Dictionary<string, float>();
            if (dataSource != null)
            {
                for (int i = 0; i < dataSource.Count; i++)
                {
                    if (dataSource[i] != null)
                    {
                        List<PointF> points = new List<PointF>();
                        for(int j=1;j<=dataSource[i].Count;j++)
                        {
                            try
                            {
                                points.Add(new PointF(size.Width * 0.75f * 0.9f / xElements.Count * j, -(dataSource[i][j-1] - startValue) / value));
                                //触发事件
                                if (maxValue != minValue &&maxValue!= 0f&&minValue!=0)
                                {                                   
                                    if (dataSource[i][j - 1] > maxValue || dataSource[i][j - 1] < minValue)
                                        dict.Add("元素" + xElements[j - 1], dataSource[i][j - 1]);
                                }
                            }
                            catch (Exception)
                            {
                                
                                throw;
                            }
                        }
                        if (dict.Count > 0)
                        {
                            CurvePainterWarning(dict, null);
                        }
                        g.DrawCurve(new Pen(linesColors[i], 2), points.ToArray());
                    }
                }
            }
            //标准线
            if (standardValue != 0f)
            {
                g.DrawLine(new Pen(Brushes.Yellow, 2) { DashStyle = DashStyle.DashDot }, new PointF(0, -(standardValue - startValue) / value), new PointF(size.Width * 0.75f, -(standardValue - startValue) / value));
            }
            //标准线
            if (maxValue != 0f)
            {
                g.DrawLine(new Pen(Brushes.Red, 2) { DashStyle = DashStyle.DashDot }, new PointF(0, -(maxValue - startValue) / value), new PointF(size.Width * 0.75f, -(maxValue - startValue) / value));
            }
            //标准线
            if (minValue != 0f)
            {
                g.DrawLine(new Pen(Brushes.Red, 2) { DashStyle = DashStyle.DashDot }, new PointF(0, -(minValue - startValue) / value), new PointF(size.Width * 0.75f, -(minValue - startValue) / value));
            }
            
        }

    }
}
