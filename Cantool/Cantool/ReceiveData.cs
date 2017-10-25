using Cantool;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Set_Com
{
    public partial class fm_receivedata : Form
    {
        
        /// <summary>
        /// Com口是否设定
        /// </summary>
        private bool set_com = false;
        /// <summary>
        /// 创建私有串口资源
        /// </summary>
        private SerialPort comDevice ;
        public fm_receivedata()
        {
            InitializeComponent();
            //tbx_receivedata.ScrollBars = ScrollBars.Both;
            MessageBox.Show("请先设定COM口");
            fm_set_Com f = new fm_set_Com();
            f.Show();
            
        }

        public fm_receivedata(bool set_com, SerialPort comDevice)
        {
            InitializeComponent();
            this.set_com = set_com;
            if (set_com)
            {
                this.comDevice = Com.get_com();
                //将com口的datarece事件绑定到Com_DataReceived函数中
                comDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
            }
            else
            {

            }
        }
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
                return;
            }
            Message_DataBase.set_current_data(sdata);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Calculate cal = new Calculate();
            this.AddData(ReDatas);
            dic = cal.Decode(sdata);
            //dic长度为0
            //MessageBox.Show("dic的长度为：" + dic.Count().ToString());
            
            foreach (KeyValuePair<string, string> kv in dic)
            {
                // string temp = "\r\n this is here!";
                string temp = kv.Key + "\'s physical value is :" + kv.Value;

                //向数据库中插入数据
                DbManager.Ins.ConnStr = "server = localhost; user id = root; password = root; database = cantool";
                string sql = @"INSERT into can_message(can_message.signal_name, can_message.signal_value,can_message.time) VALUES (?signal_name, ?signal_value, ?time)";
                List<MySqlParameter> Paramter = new List<MySqlParameter>();
                Paramter.Add(new MySqlParameter("?signal_name", kv.Key));
                Paramter.Add(new MySqlParameter("?signal_value", kv.Value));
                Paramter.Add(new MySqlParameter("?time", DateTime.Now.ToLocalTime().ToString()));
                int insert = DbManager.Ins.ExecuteNonquery(sql, Paramter.ToArray());
                byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(temp);
                this.AddData(byteArray);
            }
        }


        public void AddData(byte[] data)
        {
            String sdata = new ASCIIEncoding().GetString(data);
            //tbx_receivedata.AppendText(sdata);
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {

                    tbx_receivedata.AppendText("\r\n");
                    //tbx_receivedata.Multiline = Enabled;
                    tbx_receivedata.AppendText(sdata);
                }));
            }
                
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // fm_receivedata
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 262);
        //    this.Name = "fm_receivedata";
            
        //    this.ResumeLayout(false);

        //}

        //private void fm_receivedata_Load(object sender, EventArgs e)
        //{
        //    this.Dispose(false);
        //}
    }
}
