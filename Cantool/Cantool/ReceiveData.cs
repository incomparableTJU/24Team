using AdvancedDataGridView;
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
        Dictionary<string, string> dic = new Dictionary<string, string>();
        List<string> signalname;
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
            Calculate cal = new Calculate();
            String sdata = new ASCIIEncoding().GetString(ReDatas);
            try
            {
                if (sdata.StartsWith("t"))
                {

                    if (sdata.Length != 21)
                    {
                        //byte[] strBuffer = System.Text.Encoding.ASCII.GetBytes(yourASCIIString);
                        string str = "wrong data length, please be check!";
                        MessageBox.Show(str);
                        comDevice.Write(str);
                    }
                    if (int.Parse(sdata.Substring(4, 1)) > 8)
                    {
                        string str = "wrong data bit , please be check!";
                        MessageBox.Show(str);
                        comDevice.Write(str);
                    }
                    if (!cal.InOrNot(sdata.Substring(1, 3)))
                    {
                        string str = "no this data id, please be check!";
                        MessageBox.Show(str);
                        comDevice.Write(str);
                    }
                }
                else if (sdata.StartsWith("T"))
                {
                    if (sdata.Length != 26)
                    {
                        string str = "wrong data length, please be check!";
                        MessageBox.Show(str);
                        comDevice.Write(str);
                    }
                    if (int.Parse(sdata.Substring(9, 1)) > 8)
                    {
                        string str = "wrong data bit , please be check!";
                        MessageBox.Show(str);
                        comDevice.Write(str);
                    }
                    if (!cal.InOrNot(sdata.Substring(1, 8)))
                    {
                        string str = "no this data id, please be check!";
                        MessageBox.Show(str);
                        comDevice.Write(str);
                    }
                }
                else
                {
                    string str = "wrong data, please be check!";
                    MessageBox.Show(str);
                    comDevice.Write(str);
                }
            }
            catch
            {
                return;
            }
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
           
            //Calculate cal = new Calculate();          
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
                // this.AddData(byteArray);
               }
        }
        private void fm_receivedata_Load(object sender, System.EventArgs e)
       {
            attachmentColumn.DefaultCellStyle.NullValue = null;

            // load image strip
            this.imageStrip.ImageSize = new System.Drawing.Size(16, 16);
            this.imageStrip.TransparentColor = System.Drawing.Color.Magenta;
            this.imageStrip.ImageSize = new Size(16, 16);
            //   this.imageStrip.Images.AddStrip(Cantool.Properties.Resources.newGroupPostIconStrip);

            treeGridView1.ImageList = imageStrip;

            // attachment header cell
           // this.attachmentColumn.HeaderCell = new AttachmentColumnHeader(imageStrip.Images[2]);
 
         }
        
        private void fm_receivedata_Shown(object sender, EventArgs e)
        {
            Font boldFont = new Font(treeGridView1.DefaultCellStyle.Font, FontStyle.Bold);
            List<TreeGridNode> node = new List<TreeGridNode>();
            int i = 0;
            foreach (KeyValuePair<string, string> kv in dic)
            {
                if (!signalname.Contains(kv.Key))
                {
                    signalname.Add(kv.Key);
                    
                    node[i] = treeGridView1.Nodes.Add(null, kv.Key, kv.Value);
                    node[i].ImageIndex = 0;
                    node[i].DefaultCellStyle.Font = boldFont;
                    i++;
                                 
                }
                else
                {
                    for (int j= 0; j < signalname.Count(); j++)
                    {
                        if (kv.Key ==signalname[j])
                        {
                            node[j].Nodes.Add(null," ",kv.Value);
                            node[j].ImageIndex = 0;
                            node[j].DefaultCellStyle.Font = boldFont;
                        }
                }
                }
                   
               
                

                //  node = node.Nodes.Add(null, "Re: Using DataView filter when binding to DataGridView", "tab", @"10/19/2005 1:02 AM");
                //  node.ImageIndex = 1;
            }
            TreeGridNode node2 = treeGridView1.Nodes.Add(null, "kv.Key"," kv.Value");
            node2.ImageIndex = 0;
            node2.DefaultCellStyle.Font = boldFont;
            node2 = node2.Nodes.Add(null, "Re: Using DataView filter when binding to DataGridView", "tab");
            node2.ImageIndex = 1;
        }


        internal class AttachmentColumnHeader : DataGridViewColumnHeaderCell
        {
            public Image _image;
            public AttachmentColumnHeader(Image img)
                : base()
            {
                this._image = img;
            }
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(_image, cellBounds.X + 4, cellBounds.Y + 2);
            }
            protected override object GetValue(int rowIndex)
            {
                return null;
            }
        }

        private void treeGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
