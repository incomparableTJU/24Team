using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Web;
using System.Web.Script.Serialization;

namespace Cantool
{
    public partial class FileSaver : Form
    {
        Object content = "abcdefg"; //test
        List<Message> database = new List<Message>();

        public FileSaver()
        {
            InitializeComponent();
        }

        /**
         * save to *file
         * */
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.RestoreDirectory = true;
            fileDialog.Title = "请选择文件";
            //设置要选择的文件的类型“标签1|*.jpg|标签2|.png|标签3|.gif”
            fileDialog.Filter = "CSV文件|*.csv|XML文件|*.xml|JSON文件|*.json";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径
                bool isSuccessful = false;
                String filename = fileDialog.FileName.ToString();
                if (filename.Contains("csv"))
                {
                    //文件写入
                    FileStream fs = new FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                    //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                    StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                    for (int i = 0; i < database.Count(); i++)
                        sw.WriteLine(database[i].toString());
                    sw.Close();
                    fs.Close();
                }
                else if (filename.Contains("xml"))
                    isSuccessful = saveToXML(filename);
                else if (filename.Contains("json"))
                    isSuccessful = saveToJSON(filename);
                FileInfo fi = new FileInfo(filename);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
            }
        }

        //将文件内容转换成指定文件类型的格式
        /***
         * 将一个类 string化，再存成xml文件，待完善
         **/
        bool saveToXML(String filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                // Create Xml Writer.   
                XmlTextWriter xmlWriter = new XmlTextWriter(sw);
                // 也可以使用public XmlTextWriter(string filename, Encoding encoding)来构造   
                // encoding默认为 UTF-8.   
                //XmlTextWriter writer = new XmlTextWriter("test3.xml", null);   
                // Set indenting so that its easier to read XML when open in Notepad and such apps.   
                xmlWriter.Formatting = Formatting.Indented;
                // This will output the XML declaration   
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Messages");
                for (int i = 0; i < database.Count(); i++)
                {
                    xmlWriter.WriteStartElement("Message");
                    xmlWriter.WriteAttributeString("id", database[i].messageId.ToString());
                    xmlWriter.WriteAttributeString("name", database[i].messageName.ToString());
                    xmlWriter.WriteAttributeString("DLC", database[i].DLC.ToString());
                    xmlWriter.WriteAttributeString("fromECU", database[i].nodeNameECU.ToString());
                    for (int j = 0; j < database[i].signals.Count(); j++)
                    {
                        if (database[i].signals[j] != null)
                            xmlWriter.WriteElementString("Signal", database[i].signals[j]);
                    }
                    xmlWriter.WriteEndElement();
                }
                // close contacts </contact>   
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
            return true;
        }

        /***
         * 将一个类存为json文件，待完善
         **/
        bool saveToJSON(String filename)
        {
            // Object->Json
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            string json = null;
            //wirte into file
            FileStream fs = new FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            for (int i = 0; i < database.Count(); i++)
            {
                json = jsonSerializer.Serialize(database[i]);
                sw.WriteLine(json);
            }
            sw.Close();
            fs.Close();
            return true;
        }

        /**
         * add DB to Class
         **/
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            //初始路径,这里设置的是程序的起始位置，可自由设置  
            filename.InitialDirectory = Application.StartupPath;
            filename.Filter = "All files(*.*)|*.*|dbc files(*.dbc)|*.dbc";
            //文件类型的显示顺序（上一行.txt设为第二位）
            filename.FilterIndex = 2;
            filename.RestoreDirectory = true; //对话框记忆之前打开的目录
            //List<Message> database = new List<Message>();
            Message m = new Message();
            if (filename.ShowDialog() == DialogResult.OK)
            {
                //获得完整路径在textBox1中显示
                textBox1.Text = filename.FileName.ToString();
                StreamReader sr = new StreamReader(filename.FileName, Encoding.Default);
                string outtemp = null, intemp = null;
                outtemp = sr.ReadLine();
                int iM = 1, iS = 1;//counter
                while (outtemp != null)
                {
                    if (outtemp.Contains("BO_"))
                    {
                        iS = 1;//redefine
                        m.getMessage(outtemp);
                        textBox2.AppendText("\r\n");
                        textBox2.AppendText(iM.ToString() + " MessageId:" + m.messageId + " MessageName:" + m.messageName + " MessagFromECU：" + m.nodeNameECU + "\r\n");
                        iM++;
                        m.signals = new List<string>();
                        intemp = sr.ReadLine();
                        while (intemp != null && intemp.Contains("SG_"))
                        {
                            textBox2.AppendText("  "+iS.ToString() + " " + intemp + "\r\n");
                            //将signal add到message中
                            m.signals.Add(intemp);
                            iS++;
                            //getSignal(intemp);
                            intemp = sr.ReadLine();
                        }
                    }
                    database.Add(m);
                    m = new Message();
                    outtemp = intemp;
                }
                sr.Close();

            }
        }


        public List<Message> getDatabase()
        {
            return database;
        }

    }
}
