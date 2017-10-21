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
    public partial class fm_set_Com : Form
    {

        /// <summary>
        /// 创建私有串口资源
        /// </summary>
        private SerialPort comDevice = new SerialPort();

        /// <summary>
        /// 绑定波特率的数据
        /// </summary>
        public void bind_BaudRate()
        {
            IList<String> list = new List<String>();
            int count = 300;
            for (int i = 1; i < 8; i++)
            {
                list.Add(Convert.ToString(count));
                count = count * 2;
            }

            cbbBaudRate.DataSource = list;
        }

        #region 
        /// <summary>
        /// 设定窗体的初始行为
        /// </summary>
        /// 
        private void set_window()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;//禁止更改大小
            this.MaximizeBox = false;//使最大化窗口失效
        }
        #endregion

        /// <summary>
        /// 绑定控件的初始值
        /// </summary>
        private void bind_control_value()
        {
            bind_BaudRate();

            cbbComList.Items.AddRange(SerialPort.GetPortNames());
            if (cbbComList.Items.Count > 0)
            {
                cbbComList.SelectedIndex = 0;
            }

            cbbBaudRate.SelectedIndex = 5;
            cbbDataBits.SelectedIndex = 0;
            cbbParity.SelectedIndex = 0;
            cbbStopBits.SelectedIndex = 0;


        }
        public fm_set_Com()
        {
            InitializeComponent();
            set_window();
            bind_control_value();
        }

        private void cbbComList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cbbComList.Items.Count <= 0)
            {
                MessageBox.Show("没有发现串口，请检查线路");
                return;
            }

            if (comDevice.IsOpen == false)
            {
                comDevice.PortName = cbbComList.SelectedItem.ToString();
                comDevice.BaudRate = Convert.ToInt32(cbbBaudRate.SelectedItem.ToString());
                comDevice.Parity = (Parity)Convert.ToInt32(cbbParity.SelectedIndex.ToString());
                comDevice.DataBits = Convert.ToInt32(cbbDataBits.SelectedItem.ToString());
                comDevice.StopBits = (StopBits)Convert.ToInt32(cbbStopBits.SelectedItem.ToString());
                // comDevice.ParityReplace = 63;
                //char a = (char)comDevice.ParityReplace;
                //MessageBox.Show(a.ToString());
                //MessageBox.Show(comDevice.ParityReplace.GetType().ToString());
                try
                {
                    comDevice.Open();
                    btn_ok.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btn_ok.Text = "关闭串口";

            }
            else
            {
                try
                {
                    comDevice.Close();
                    btn_ok.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btn_ok.Text = "打开串口";

            }

            cbbBaudRate.Enabled = !comDevice.IsOpen;
            cbbComList.Enabled = !comDevice.IsOpen;
            cbbDataBits.Enabled = !comDevice.IsOpen;
            cbbParity.Enabled = !comDevice.IsOpen;
            cbbStopBits.Enabled = !comDevice.IsOpen;

            fm_receivedata f = new fm_receivedata(true, comDevice);
            f.Show();
        }
    }
}
