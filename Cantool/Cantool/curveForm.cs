
using Cantool.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cantool
{
    public partial class CurveForm : Form
    {
        private Queue<double> dataQueue = new Queue<double>();
        private int num = 1;//每次删除增加几个点
        List<float> val = new List<float>();
        List<string> signalname = new List<string>();
        messagesignal sig = new messagesignal();
        string current;//当前选择的名字
        int count = 0;


        /// <summary>
        /// 绑定message数据
        /// </summary>
        void bind_cbx_message()
        {
            List<Cantool.Message> database = Message_DataBase.get_all_Message();
            if (database != null && database.Count() > 0)
            {
                this.cbx_message.DataSource = database;//绑定数据
                this.cbx_message.ValueMember = "messageId";
                this.cbx_message.DisplayMember = "messageName";
            }
            else
            {
                MessageBox.Show("请先载入数据");
            }
        }
        /// <summary>
        /// 清理函数，设定初始值
        /// </summary>
        private void clear()
        {
            count = 0;
            if(this.chart1.Series.Count > 0)
            this.chart1.Series[0].Points.Clear();
            dataQueue.Clear();
        }
        public CurveForm()
        {
            InitializeComponent();
            bind_cbx_message();
            InitChart();

            this.chart1.Series[0].Points.Clear();
            this.cbx_count.SelectedIndex = 0;
            Com.get_com().DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);

            //val.Add(3);
            //val.Add(0);
            //val.Add(7);
            //val.Add(50);
            //val.Add(50);
            //val.Add(50);
            //val.Add(50);
            //val.Add(50);
            //val.Add(50);
            //val.Add(50);
            //string[] name = { "si1", "si2", "si3" };
            //float[] value = { 23, 45, 67 };

            // sig.initsignal(3, name, value, comboBox1);
        }
        /// <summary>

        /// 开始事件

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>

        private void btnStart_Click(object sender, EventArgs e)
        {
            //this.timer1.Start();
            InitChart();
            UpdateQueueValue();
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataQueue.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue.ElementAt(i));
            }
        }

        private void btnStop_Click(object sender, EventArgs e)

        {
            this.timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            UpdateQueueValue();
            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataQueue.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue.ElementAt(i));
            }
        }

        private void InitChart()

        {

            //定义图表区域

            this.chart1.ChartAreas.Clear();

            ChartArea chartArea1 = new ChartArea("C1");

            this.chart1.ChartAreas.Add(chartArea1);

            //定义存储和显示点的容器

            this.chart1.Series.Clear();

            Series series1 = new Series("S1");

            series1.ChartArea = "C1";

            this.chart1.Series.Add(series1);

            //设置图表显示样式

            this.chart1.ChartAreas[0].AxisY.Minimum = 0;

            this.chart1.ChartAreas[0].AxisY.Maximum = 100;

            this.chart1.ChartAreas[0].AxisX.Interval = 5;

            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;

            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //    chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            //   chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
            //   chart1.ChartAreas[0].AxisX.ScaleView.Size = 20;

            //设置标题        
            this.chart1.Titles.Add("S01");

            this.chart1.Titles[0].Text = "CanTool数据的物理值显示";

            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;

            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);

            //设置图表显示样式

            this.chart1.Series[0].Color = Color.Red;
            //线的类型
            this.chart1.Series[0].ChartType = SeriesChartType.Spline;
            this.chart1.Series[0].Points.Clear();


            chart1.Series[0].BorderWidth = 2;
            //标记点边框颜色      
            chart1.Series[0].MarkerBorderColor = Color.Blue;
            //标记点边框大小
            chart1.Series[0].MarkerBorderWidth = 3; //chart1.;// Xaxis 
            //标记点中心颜色
            chart1.Series[0].MarkerColor = Color.White;//AxisColor
            //标记点大小
            chart1.Series[0].MarkerSize = 8;
            //标记点类型     
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;

            //设置数值显示
            chart1.Series[0].IsValueShownAsLabel = true;
            //将文字移到外侧
            chart1.Series[0]["PieLabelStyle"] = "Outside";
            //绘制黑色的连线
            chart1.Series[0]["PieLineColor"] = "Black";



        }
        //更新队列中的值
        private void UpdateQueueValue()
        {
            if (dataQueue.Count > 100)
            {
                //先出列
                for (int i = 0; i < num; i++)
                {
                    dataQueue.Dequeue();
                }
            }
            for (int i = 0; i < num; i++)
            {

                foreach (int elements in val)
                    dataQueue.Enqueue(elements);
            }
        }
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    for(int i=0;i<sig.sigcount();i++)
        //    {
        //        if (comboBox1.SelectedIndex == i)
        //        {

        //            current = comboBox1.Text.ToString();
        //            MessageBox.Show("显示的是" + current);
        //        }
        //    }

        //}

        private void cbx_message_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get displayed message
            Cantool.Message selectedMessage = (Cantool.Message)this.cbx_message.SelectedItem;
            MessageBox.Show(selectedMessage.messageId.ToString());
            List<Signal> toBeDisplaySG = new List<Signal>();
            List<string> signals = selectedMessage.signals;
            for (int i = 0; i < signals.Count(); i++)
            {
                Signal temp = new Signal();
                Signal get = Signal.getSignal(signals[i]);
                temp.signal = get.signal;
                temp.signalName = get.signalName;
                temp.startBit = get.startBit;
                temp.bitLength = get.bitLength;
                temp.bitStyle = get.bitLength;
                temp.A = get.A;
                temp.B = get.B;
                temp.C = get.C;
                temp.D = get.D;
                temp.physicalUnit = get.physicalUnit;
                temp.nodeNames = get.nodeNames;
                toBeDisplaySG.Add(temp);
            }

            this.cbx_signal.DataSource = toBeDisplaySG;
            this.cbx_signal.ValueMember = "signalName";
        }


        private DataTable get_signal_value(String signalName, int count)
        {
            //数据库字符串，暂时放到这里
            DbManager.Ins.ConnStr = "server = localhost; user id = root; password = root; database = cantool";
            //String sql = "select can_message.signal_value from can_message where can_message.signal_name="mx"  ORDER BY can_message.time desc limit 1";
            String sql = "select can_message.signal_value from can_message where can_message.signal_name=?signal_name  ORDER BY can_message.time desc limit 0,?count";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("?signal_name", signalName));
            Paramter.Add(new MySqlParameter("?count", count));
            DataTable data = DbManager.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            return data;
        }
        private void cbx_count_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            set_curve_value();
        }


        /// <summary>
        /// 设置曲线的值
        /// </summary>
        private void set_curve_value()
        {
            int count = Convert.ToInt32(this.cbx_count.SelectedItem);
            Signal selected_signal = (Signal)this.cbx_signal.SelectedItem;
            String signal_name = selected_signal.signalName;
            DataTable dt = get_signal_value(signal_name, count);
            if (dt == null)
            {
                MessageBox.Show("当前不存在所选signal的数据");
                return;
            }
            else
            {
                count = 0;
                for (count = 0; count < dt.Rows.Count; count++)
                {
                    //
                    String str = dt.Rows[count]["signal_value"].ToString();
                    dataQueue.Enqueue(Convert.ToDouble(str));
                    this.chart1.Series[0].Points.AddXY((count + 1), Convert.ToDouble(str));
                    
                }

            }
        }

        private void cbx_signal_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            set_curve_value();
        }


        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort comDevice = Com.get_com();
            if (comDevice != null)
            {
                byte[] ReDatas = new byte[comDevice.BytesToRead];
                comDevice.Read(ReDatas, 0, ReDatas.Length);

                String sdata = new ASCIIEncoding().GetString(ReDatas);
                if (sdata == null || sdata.Trim() == "")
                {
                    String current_data = Message_DataBase.get_current_data();
                    if (current_data != null)
                    {
                        sdata = current_data;
                    }
                    else
                    {
                        return;
                    }
                }
                Message_DataBase.set_current_data(sdata);
                Dictionary<string, string> dic = new Dictionary<string, string>();
                Calculate cal = new Calculate();
                dic = cal.Decode(sdata);


                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        //for (int i = 0; i < 10; i++)
                        //{

                        //}
                        //aGauge2.Value = count;
                        //count = count + 10;
                        Signal selected_signal = (Signal)this.cbx_signal.SelectedItem;
                        foreach (KeyValuePair<string, string> kv in dic)
                        {
                            if (kv.Key == selected_signal.signalName)
                            {
                                if (this.chart1.Series.Count > 0)
                                {
                                    this.chart1.Series[0].Points.Clear();  
                                }
                                dataQueue.Enqueue(Convert.ToDouble(kv.Value));
                                for (int i = 0; i < dataQueue.Count; i++)
                                {
                                    this.chart1.Series[0].Points.AddXY((i + 1), dataQueue.ElementAt(i));
                                }


                                break;
                            }

                        }
                    }));
                }
            }
            else
            {
                MessageBox.Show("请设置COM口");
            }

        }
    }
}

