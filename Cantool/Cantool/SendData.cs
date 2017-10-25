using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantool
{
   
    public partial class SendData : Form
    {
        Dictionary<String, String> dic;
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
        public SendData()
        {
            InitializeComponent();
            bind_cbx_message();
            dic = new Dictionary<string, string>();

        }
        /// <summary>
        /// 根据signal的数目更改pannel的尺寸
        /// </summary>
        /// <param name="signal_count"></param>
       private void refresh_panel_size(int signal_count)
        {
            this.panel.Size = new System.Drawing.Size(314, signal_count * 27 + 50);
        }

        /// <summary>
        /// 根据signal的数目更改window的尺寸
        /// </summary>
        /// <param name="signal_count"></param>
        private void refresh_window_size(int signal_count)
        {
            this.Size = new System.Drawing.Size(380, signal_count * 27 + 190);
        }


        /// <summary>
        /// 创建label
        /// </summary>
        /// <param name="l_name"></param>
        /// <param name="location"></param>
        private void create_label(String l_name, Point location)
        {
            Label l = new Label();

            l.AutoSize = true;
            l.Location = location;
            l.Name = "lbl_" +  l_name;
            l.Size = new System.Drawing.Size(41, 12);
            l.TabIndex = 1;
            l.Text = l_name;
            l.Visible = true;

            this.panel.Controls.Add(l);
        }

        /// <summary>
        /// 创建textbox
        /// </summary>
        /// <param name="t_name"></param>
        /// <param name="location"></param>
        private void create_textbox(String t_name, Point location)
        {
            TextBox textbox = new TextBox();

            textbox.Location = location;
            textbox.Name = t_name;
            textbox.Size = new System.Drawing.Size(100, 41);
            textbox.Text = "0";

            this.panel.Controls.Add(textbox);
        }

        private void cbx_message_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get displayed message
            Cantool.Message selectedMessage = (Cantool.Message)this.cbx_message.SelectedItem;
            
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
            //MessageBox.Show(toBeDisplaySG.Count.ToString());

            //调整界面大小
            refresh_window_size(toBeDisplaySG.Count);
            refresh_panel_size(toBeDisplaySG.Count);


            //清空panel中原有控件
            this.panel.Controls.Clear();
            //生成控件
            Point label_start = new Point(32, 15);//label的初始位置
            Point tbx_start = new Point(184, 12);//textbox的初始位置

            int count = 0;
            //循环生成控件
            foreach(Signal s in toBeDisplaySG)
            {
                int l_x = label_start.X;
                int l_y = label_start.Y + 27 * count;
                Point lo = new Point(l_x, l_y);
                create_label(s.signalName, lo);

                int t_x = tbx_start.X ;
                int t_y = l_y;
                Point t_lo = new Point(t_x, t_y);
                create_textbox(s.signalName, t_lo);
                count++;
            }

            //this.cbx_signal.DataSource = toBeDisplaySG;
            //this.cbx_signal.ValueMember = "signalName";
        }

        /// <summary>
        /// 收集panel中所有控件的值，并放在字典中
        /// </summary>
        private Dictionary<string, string> coleect_value()
        {
            dic = new Dictionary<string, string>();
            foreach(Control c in this.panel.Controls)
            {
                if(c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    TextBox tem = (TextBox)c;
                    dic.Add(tem.Name, tem.Text);
                    //MessageBox.Show(tem.Name + tem.Text);
                }
            }
            return dic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> dic = coleect_value();
            Message message = (Message)this.cbx_message.SelectedItem;
            String message_ID = message.messageId.ToString();
            //dic 和 message_ID 获得
            Calculate cal = new Calculate();
            string result = cal.Put(message_ID, dic);
            MessageBox.Show("result is : " + result);
        }
    }

    
}
