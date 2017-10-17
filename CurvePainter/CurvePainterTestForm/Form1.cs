using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CurvePainterTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<List<float>> list = new List<List<float>>();
            curvePainter1.StartValue = 18f;
            curvePainter1.GridValue =1.5f;
            curvePainter1.YGridCount = 20;
            curvePainter1.StandardValue = 22f;
            curvePainter1.MaxValue = 28f;
            curvePainter1.MinValue = 19f;
            curvePainter1.LinesColors = new List<Color>() { Color.Red,Color.Green};
            curvePainter1.CurvePainterWarning += new CurvePainter.CurvePainter.WarningHandle(curvePainter1_CurvePainterWarning);
           
            List<float> lt = new List<float>() { 20f, 20.5f, 22f, 26f, 24f, 25f,30f,21f };
            list.Add(lt);
            List<List<float>> list1 = new List<List<float>>();
            List<float> lt1 = new List<float>() { 18.5f, 31f, 23.5f, 20f, 31.5f,23f, 25.5f, 21f };
            list1.Add(lt1);
            this.curvePainter1.DataSource = list;
            curvePainter1.XElements = new List<string>() { "A", "B", "C", "D", "E", "F","G","H" };

            Thread t=new Thread(new ThreadStart(()=>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    if (this.curvePainter1.DataSource == list)
                    {
                        this.curvePainter1.DataSource = list1;
                    }
                    else
                    {
                        this.curvePainter1.DataSource = list;
                    }

                }
            }));

            t.Start();
        }

        void curvePainter1_CurvePainterWarning(object sender, EventArgs e)
        {
            Dictionary<string, float> dict = sender as Dictionary<string, float>;
            foreach (KeyValuePair<string, float> x in dict)
            {
                txtWarning.Text += string.Format(@"报警:{0},值{1}",x.Key,x.Value) + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.BackgroundImage = null;
            Bitmap bit = new Bitmap(curvePainter1.Width,curvePainter1.Height);
            curvePainter1.DrawToBitmap(bit, new Rectangle(0,0,curvePainter1.Width, curvePainter1.Height));
            this.pictureBox1.BackgroundImage = bit;
        }
    }
}
