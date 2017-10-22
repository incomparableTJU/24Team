using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curvepaint
{
    class messagesignal
    {
        public string name { get; set; }
        public float value { get; set; }
        public List<messagesignal> signallist;//信号列表

        //初始化下拉框
        public int sigcount()
        {
            return signallist.Count;
        }
        public void initsignal(int num, string[] name, float[] val, ComboBox comboBox1)//传来信号数量，名字，值
        {
            signallist = new List<messagesignal>();
            for (int i = 0; i < num; i++)
            {
                messagesignal singlesig = new messagesignal();
                singlesig.name = name[i];
                singlesig.value = val[i];  

                signallist.Add(singlesig);
            }
            if (signallist.Count > 0)
            {
                comboBox1.DataSource = signallist;//绑定数据
                comboBox1.ValueMember = "value";
                comboBox1.DisplayMember = "name";           
            }
        }

       
    }
}

