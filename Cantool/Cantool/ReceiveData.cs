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
                this.comDevice = comDevice;
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

            this.AddData(ReDatas);

        }
        

        public void AddData(byte[] data)
        {
            String sdata = new ASCIIEncoding().GetString(data);
            //tbx_receivedata.AppendText(sdata);
            this.BeginInvoke(new MethodInvoker(delegate
            {

                tbx_receivedata.AppendText("\r\n");

                tbx_receivedata.AppendText(sdata);
            }));
        }
    }
}
