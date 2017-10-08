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

namespace testCom
{
    public partial class Form1 : Form
    {

        private SerialPort comDevice = new SerialPort();

        public void init()
        {
            bind_BaudRate();
           //btnSend.Enabled = false;
            cbbComList.Items.AddRange(SerialPort.GetPortNames());
            if(cbbComList.Items.Count > 0)
            {
                cbbComList.SelectedIndex = 0;
            }
            cbbBaudRate.SelectedIndex = 5;
            cbbDataBits.SelectedIndex = 0;
            cbbParity.SelectedIndex = 0;
            cbbStopBits.SelectedIndex = 0;


            comDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);

        }

        ///
        /// 绑定波特率的数据
        /// 
        public void bind_BaudRate()
        {
            IList<String> list = new List<String>();
            int count = 300;
            for(int i = 1; i < 8; i++)
            {
                list.Add(Convert.ToString(count));
                count = count * 2;
            }

            cbbBaudRate.DataSource = list;
           
            
            
            
        }

        public void bind_combox(ComboBox cbb, List<String> l)
        {
            cbb.DataSource = l;
        }
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {

            
            InitializeComponent();


            //this.radioButton1.Name = "r1";
            // this.radioButton2.Name = "r1";
            // this.radioButton3.Name = "r1";
            // this.radioButton4.Name = "r1";
            
            init();
            this.rbtnSendHex.Name = "r2";
            this.rbtnSendASCII.Name = "r2";
            this.rbtnSendUTF8.Name = "r2";
            this.rbtnSendUnicode.Name = "r2";





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(cbbComList.Items.Count <= 0)
            {
                MessageBox.Show("没有发现串口，请检查线路");
                return;
            }

            if(comDevice.IsOpen == false)
            {
                comDevice.PortName = cbbComList.SelectedItem.ToString();
                comDevice.BaudRate = Convert.ToInt32(cbbBaudRate.SelectedItem.ToString());
                comDevice.Parity = (Parity)Convert.ToInt32(cbbParity.SelectedIndex.ToString());
                comDevice.DataBits = Convert.ToInt32(cbbDataBits.SelectedItem.ToString());
                comDevice.StopBits = (StopBits)Convert.ToInt32(cbbStopBits.SelectedItem.ToString());
                try
                {
                    comDevice.Open();
                    btnSend.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnOpen.Text = "关闭串口";

            }
            else
            {
                try
                {
                    comDevice.Close();
                    btnSend.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnOpen.Text = "打开串口";
            
            }

            cbbBaudRate.Enabled = !comDevice.IsOpen;
            cbbComList.Enabled = !comDevice.IsOpen;
            cbbDataBits.Enabled = !comDevice.IsOpen;
            cbbParity.Enabled =   !comDevice.IsOpen;
            cbbStopBits.Enabled = !comDevice.IsOpen;
        }

        private bool SendData(byte[] data)
        {
            if(comDevice.IsOpen)
            {
                try
                {
                    comDevice.Write(data, 0, data.Length);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] sendData = null;

            if(rbtnSendASCII.Checked)
            {
                sendData = Encoding.ASCII.GetBytes(txtSendData.Text.Trim());
            }

            if(this.SendData(sendData))
            {

            }

        }

        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[comDevice.BytesToRead];
            comDevice.Read(ReDatas, 0, ReDatas.Length);
            this.AddData(ReDatas);

        }

        public void AddData(byte[] data)
        {
            if(rbtnASCII.Checked)
            {
                AddContent(new ASCIIEncoding().GetString(data));
            }
        }

        public void AddContent(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if(chkAutoLine.Checked && txtShowData.Text.Length > 0)
                {
                    txtShowData.AppendText("\r\n");
                }
                txtShowData.AppendText(content);
            }));
        }
    }
}
