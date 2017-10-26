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
    public partial class SetVelocity : Form
    {
        private string speedNow = "S0";
        private string speedLast = null;
        public SetVelocity()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                speedLast = speedNow;
                speedNow = "S0";
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                speedLast = speedNow;
                speedNow = "S1";
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                speedLast = speedNow;
                speedNow = "S2";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                speedLast = speedNow;
                speedNow = "S3";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                speedLast = speedNow;
                speedNow = "S4";   
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                speedLast = speedNow;
                speedNow = "S5";
            }
                
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                speedLast = speedNow;
                speedNow = "S6";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                speedLast = speedNow;
                speedNow = "S7";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                speedLast = speedNow;
                speedNow = "S8";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort comDevice = Com.get_com();
            if (!comDevice.IsOpen)
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sendContent = speedNow+"\r";

            
            byte[] sendData = null;
            sendData = Encoding.ASCII.GetBytes(sendContent.Trim());
            this.SendData_(sendData, comDevice);
            MessageBox.Show("已向Cantool装置发送设定速率！");

            byte[] ReDatas = new byte[comDevice.BytesToRead];
            comDevice.Read(ReDatas, 0, ReDatas.Length);
            string receive = new ASCIIEncoding().GetString(ReDatas);

            if (receive == "\r")
            {
                this.textBox1.Text = speedNow;
            }
            else if (receive == "\\BEL") //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                this.textBox1.Text = speedLast;
            else
                this.textBox1.Text = "设置失败";
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
