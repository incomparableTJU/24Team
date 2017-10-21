using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class Form1 : Form
    {
        signal sig = new signal();
        public Form1()
        {
            InitializeComponent();
            string[] meaasge = { "si1", "si2", "si3" };
            float[] val = { 2, 30, 45f };
            int n = 3;
            sig.initsignal(n, meaasge, val, comboBox1, aGauge2);
            string signal = "si1";
            float signalvai = 40f;
            sig.update(aGauge2, signal, signalvai);

        }




        private void aGauge2_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {
           // aGauge2.Value = this.value;



        }      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < sig.sigcount(); i++)
            {
                if (comboBox1.SelectedIndex == i)
                {
                    sig.select(aGauge2, i,label1);

                }
            }
        }
    }
}
