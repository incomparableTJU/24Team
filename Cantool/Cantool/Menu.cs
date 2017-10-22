using Set_Com;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantool
{
    public partial class Menu : Form
    {
        public List<Message> database = new List<Message>();

        public Menu()
        {
            InitializeComponent();
        }

        private void 文件存储ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide the last panel and add new panel
            this.panel.Controls.Clear();
            this.homePage.Visible = false;
            this.panel.Visible = true;

            //set the attribution
            FileSaver fileSaverForm = new FileSaver();
            fileSaverForm.TopLevel = false;
            fileSaverForm.Dock = System.Windows.Forms.DockStyle.Fill;
            fileSaverForm.FormBorderStyle = FormBorderStyle.None;

            this.panel.Controls.Add(fileSaverForm);
            fileSaverForm.Show();
            this.database = fileSaverForm.getDatabase();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            this.homePage.Visible = true;
            this.panel.Visible = false;
        }

        private void 设定COM口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide the last panel and add new panel
            this.panel.Controls.Clear();
            this.homePage.Visible = false;
            this.panel.Visible = true;

            //set the attribution of setcom
            fm_set_Com set_com = new fm_set_Com();
            set_com.TopLevel = false;
            set_com.Dock = System.Windows.Forms.DockStyle.Fill;
            set_com.FormBorderStyle = FormBorderStyle.None;

            this.panel.Controls.Add(set_com);
            set_com.Show();
        }

        private void can信息布局ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //hide the last panel and add new panel
            this.panel.Controls.Clear();
            this.homePage.Visible = false;
            this.panel.Visible = true;

            //set the attribution
            CanMessageLayout layout = new CanMessageLayout();
            layout.loadData(database);

            layout.TopLevel = false;
            layout.Dock = System.Windows.Forms.DockStyle.Fill;
            layout.FormBorderStyle = FormBorderStyle.None;

            this.panel.Controls.Add(layout);
            layout.Show();
        }
    }
}
