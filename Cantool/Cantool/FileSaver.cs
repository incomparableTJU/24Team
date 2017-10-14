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
        Object content = "abcdefg"; //需保存的内容

        public FileSaver()
        {
            InitializeComponent();
        }
        
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
                    sw.WriteLine(content.ToString());
                    sw.Close();
                    fs.Close();
                }
                else if (filename.Contains("xml"))
                    isSuccessful = saveToXML(filename,content);
                else if (filename.Contains("json"))
                    isSuccessful = saveToJSON(filename,content);
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
        bool saveToXML(String filename, Object content)
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
                xmlWriter.WriteStartElement("Contacts");
                xmlWriter.WriteStartElement("Contact");
                xmlWriter.WriteAttributeString("id", "01");
                xmlWriter.WriteElementString("Name", "Daisy Abbey");
                xmlWriter.WriteElementString("Gender", "female");
                // close contact </contact>   
                xmlWriter.WriteEndElement();
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
        bool saveToJSON(String filename, Object content)
        {
             // Object->Json
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            string json = jsonSerializer.Serialize(content);
            //wirte into file
            FileStream fs = new FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            sw.WriteLine(json);
            sw.Close();
            fs.Close();
            return true;
        }

    }
}
