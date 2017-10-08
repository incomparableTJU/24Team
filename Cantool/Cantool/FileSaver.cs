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

namespace Cantool
{
    public partial class FileSaver : Form
    {
        String content = "abcdefg"; //需保存的内容

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
                String filename = fileDialog.FileName.ToString();
                if (filename.Contains("csv"))
                    content = convertToCSV(content);
                else if (filename.Contains("xml"))
                    content = convertToXML(content);
                else if (filename.Contains("json"))
                    content = convertToJSON(content);
                FileInfo fi = new FileInfo(filename);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
                //文件写入
                FileStream fs = new FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                sw.WriteLine(content);
                sw.Close();
                fs.Close();

            }
        }

        //将文件内容转换成指定文件类型的格式
        String convertToCSV(String content)
        {
            return content;
        }
        String convertToXML(String content)
        {
            return content;
        }
        String convertToJSON(String content)
        {
            return content;
        }

    }
}
