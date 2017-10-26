using Cantool;
using Cantool.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class boardForm : Form
    {
        //signal sig = new signal();
        int count = 10;
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
        public boardForm()
        {
            InitializeComponent();
            bind_cbx_message();
            //将Com_DataReceived函数绑定到COM口数据接收的事件上，一旦有数据传来，就调用Com_DataReceived函数
            //检查最新的Message是否包含当前选中的signal信息，若有，则更新仪表盘的数值
            Com.get_com().DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);


        }

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort comDevice = Com.get_com();
            if(comDevice != null)
            {
                byte[] ReDatas = new byte[comDevice.BytesToRead];
                comDevice.Read(ReDatas, 0, ReDatas.Length);

                String sdata = new ASCIIEncoding().GetString(ReDatas);
                if(sdata == null || sdata.Trim() == "" )
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
                            // string temp = "\r\n this is here!";
                           if(kv.Key == selected_signal.signalName)
                            {
                                //MessageBox.Show(kv.Key);
                                //MessageBox.Show(selected_signal.signalName);
                                //MessageBox.Show(kv.Value);
                                //MessageBox.Show(selected_signal.C.ToString());
                                //MessageBox.Show(selected_signal.D.ToString());
                                this.aGauge2.MinValue = Convert.ToSingle(selected_signal.C);
                                //取整数
                                //间隔
                                int space = (Convert.ToInt32(selected_signal.D + 10)) % 10;
                                if (Convert.ToSingle(selected_signal.D) <= 2)
                                {
                                    this.aGauge2.MaxValue  = 2;
                                }
                                else
                                {
                                    this.aGauge2.MaxValue = Convert.ToSingle(selected_signal.D + 10 - space);
                                }
                                aGauge2.ScaleLinesMajorStepValue = (aGauge2.MaxValue - aGauge2.MinValue) / 10;
                                this.aGauge2.Value = Convert.ToSingle(kv.Value);
                                this.label1.Text = kv.Value;
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




        private void aGauge2_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {

        }      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        private void cbx_signal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Signal selected_signal = (Signal)this.cbx_signal.SelectedItem;
            this.aGauge2.MinValue = Convert.ToSingle(selected_signal.C);
            //取整数
            //间隔
            int space = (Convert.ToInt32(selected_signal.D + 10)) % 10;
            if (Convert.ToSingle(selected_signal.D) <= 2)
            {
                this.aGauge2.MaxValue = 2;
            }
            else
            {
                this.aGauge2.MaxValue = Convert.ToSingle(selected_signal.D + 10 - space);
            }

            aGauge2.ScaleLinesMajorStepValue = (aGauge2.MaxValue - aGauge2.MinValue) / 10;
            //从数据库中获取当前选中的signal的最新值，显示出来
            String signal_value = get_signal_value(selected_signal.signalName);
            this.aGauge2.Value = Convert.ToSingle(signal_value);
            this.label1.Text = signal_value;
        }

        private String get_signal_value(String signalName)
        {
            //数据库字符串，暂时放到这里
            DbManager.Ins.ConnStr = "server = localhost; user id = root; password = root; database = cantool";
            //String sql = "select can_message.signal_value from can_message where can_message.signal_name="mx"  ORDER BY can_message.time desc limit 1";
            String sql = "select can_message.signal_value from can_message where can_message.signal_name=?signal_name  ORDER BY can_message.time desc limit 1";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            Paramter.Add(new MySqlParameter("?signal_name", signalName));
            DataTable data = DbManager.Ins.ExcuteDataTable(sql, Paramter.ToArray());
            if(data != null)
            {
                if(data.Rows.Count > 0)
                {
                    String tem = data.Rows[0]["signal_value"].ToString();
                    return tem;
                }
                
                
                return "0";
            }
            return "0";
        }
    }
}
