using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantool
{
    public partial class CanMessageLayout : Form
    {
        public List<Message> database;

        public CanMessageLayout()
        {
            InitializeComponent();
            loadRows();
        }

        public void loadRows()
        {
            this.canLayout.Enabled = false;
            //this.canLayout.Columns[0].DefaultCellStyle.SelectionBackColor = Color.White;

            this.canLayout.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.canLayout.RowTemplate.Height = 25;
            this.canLayout.Rows.Add(8);

            //就是这行！！！！！！
            this.canLayout.Rows[7].HeaderCell.Value = "0";

            //must at the end!!!!
            this.canLayout.CurrentCell = null;
            //this.canLayout.ClearSelection();
        }

        //get all messages from fileSaver form
        public void loadData(List<Message> dbs)
        {
            database = dbs;
            if (database.Count() > 0)
            {
                this.messageComboBox.DataSource = database;//绑定数据
                this.messageComboBox.ValueMember = "messageId";
                this.messageComboBox.DisplayMember = "messageName";
            }

        }

        public List<Color> getColor()
        {
            //set color list~~
            List<Color> colorful = new List<Color>();
            colorful.Add(Color.LightCoral);
            colorful.Add(Color.LightPink);
            colorful.Add(Color.Pink);
            colorful.Add(Color.MistyRose);
            colorful.Add(Color.LemonChiffon);
            colorful.Add(Color.Aquamarine);
            colorful.Add(Color.Aqua);
            colorful.Add(Color.PaleTurquoise);
            colorful.Add(Color.DarkTurquoise);
            colorful.Add(Color.GreenYellow);
            colorful.Add(Color.Lavender);
            colorful.Add(Color.LightGray);
            colorful.Add(Color.Thistle);
            return colorful;
            
        }


        private void messageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    this.canLayout.Rows[i].Cells[j].Style.BackColor = Color.White;
            //this.canLayout.DefaultCellStyle.BackColor = Color.White;

            List<Color> colorful = getColor();
            
            //get displayed message
            Message selectedMessage = (Message)this.messageComboBox.SelectedItem;
            List<Signal> toBeDisplaySG = new List<Signal>();
            List<string> signals = selectedMessage.signals;
            for (int i = 0; i < signals.Count(); i++)
            {
                Signal temp = new Signal();
                Signal get = Signal.getSignal(signals[i]);
                temp.signal = get.signal;
                temp.signalName = get.signalName;
                temp.startBit = get.startBit;
                temp.bitLength = get.bitLength;
                temp.bitStyle = get.bitLength;
                temp.A = get.A;
                temp.B = get.B;
                temp.C = get.C;
                temp.D = get.D;
                temp.physicalUnit = get.physicalUnit;
                temp.nodeNames = get.nodeNames;

                toBeDisplaySG.Add(temp);
            }
            //this.dataGridView3.Rows[i].Cells[1].Style.BackColor = Color.MediumPurple;
            int hang = 0;
            int startColorCell = 0;
            int iC = 0;
            foreach (var signal in toBeDisplaySG)
            {
                startColorCell = 7 - signal.startBit % 8;
                hang = signal.startBit / 8;
                if (iC == colorful.Count())
                    iC = 0;

                if (signal.bitLength == 1)
                    this.canLayout.Rows[hang].Cells[startColorCell].Style.BackColor = colorful[iC];
                else if (signal.bitLength > 1)
                {
                    for (int j = 0; j < signal.bitLength; j++)
                    {
                        if (startColorCell == 8)
                        {
                            startColorCell = 0;
                            hang += 1;
                        }
                        this.canLayout.Rows[hang].Cells[startColorCell].Style.BackColor = colorful[iC];
                        startColorCell++;
                    }
                }
                iC++;
            }
        }

    }
}
