using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    class signal
    {
        public string name { get; set; }
        public float value { get; set; }
        public List<signal> signallist;//信号列表

        //初始化下拉框
        public int sigcount()
        {
            return signallist.Count;
        }
        public void initsignal(int num, string[] name, float[] val, ComboBox comboBox1, AGauge agu)//传来信号数量，名字，值
        {
            signallist = new List<signal>();
            for (int i = 0; i < num; i++)
            {
                signal singlesig = new signal();
                singlesig.name = name[i];
                singlesig.value = val[i];

                signallist.Add(singlesig);
            }
            if (signallist.Count > 0)
            {
                comboBox1.DataSource = signallist;//绑定数据
                comboBox1.ValueMember = "value";
                comboBox1.DisplayMember = "name";

                //  MessageBox.Show("name");
            }
        }
        public void select(AGauge agu, int i,Label label)
        {
            agu.CapText = signallist[i].name;
            agu.Value = signallist[i].value;
            label.Text = signallist[i].value.ToString();
        }
        public void update(AGauge agu, string signalname, float value)
        {
            if (agu.CapText.ToString() == signalname)
            {
                agu.Value = value;
            }
        }
    }
}

