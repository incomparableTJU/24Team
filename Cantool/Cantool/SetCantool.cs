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

namespace Cantool
{
    public partial class SetCantool : Form
    {
        public SetCantool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort comDevice = Com.get_com();
            if (!comDevice.IsOpen)
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sendContent = "V\r";

            byte[] sendData = null;
            sendData = Encoding.ASCII.GetBytes(sendContent.Trim());
            this.SendData_(sendData, comDevice);
            MessageBox.Show("已向Cantool装置发送请求版本信息！");
            
            //接受、显示在textbox上
            byte[] ReDatas = new byte[comDevice.BytesToRead];
            comDevice.Read(ReDatas, 0, ReDatas.Length);

            string receive = new ASCIIEncoding().GetString(ReDatas);
            
            if (receive != null )
                this.textBoxVerson.Text = receive;
            else
                this.textBoxVerson.Text ="抱歉，未接收到版本信息!";
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            SerialPort comDevice = Com.get_com();
            if (!comDevice.IsOpen)
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sendContent = "O1\r";

            byte[] sendData = null;
            sendData = Encoding.ASCII.GetBytes(sendContent.Trim());
            this.SendData_(sendData, comDevice);
            MessageBox.Show("已向Cantool装置发送开启命令！");

            //接受 然后显示在label上
            byte[] ReDatas = new byte[comDevice.BytesToRead];
            comDevice.Read(ReDatas, 0, ReDatas.Length);

            string receive = new ASCIIEncoding().GetString(ReDatas);
            
            if (receive == "\r")
            {
                this.labelState.Text = "已开启";
            }
            else if (receive == "\\BEL") //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                this.labelState.Text = "抱歉，打开失败！";
            else
                this.labelState.Text = "已关闭";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            SerialPort comDevice = Com.get_com();
            if (!comDevice.IsOpen)
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sendContent = "C\r";

            byte[] sendData = null;
            sendData = Encoding.ASCII.GetBytes(sendContent.Trim());
            this.SendData_(sendData, comDevice);
            MessageBox.Show("已向Cantool装置发送关闭命令！");

            //接收、然后显示在label上
            byte[] ReDatas = new byte[comDevice.BytesToRead];
            comDevice.Read(ReDatas, 0, ReDatas.Length);

            string receive = new ASCIIEncoding().GetString(ReDatas);
            if (receive == "\r")
            {
                this.labelState.Text = "已关闭";
            }
            else if (receive == "\\BEL") //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                this.labelState.Text = "抱歉，无法关闭！";
            else
                this.labelState.Text = "已开启";
        }

        private bool SendData_(byte[] data, SerialPort comDevice)
        {
            if (comDevice.IsOpen)
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

    
        
    }
}
