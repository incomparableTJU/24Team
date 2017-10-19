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

        private void can信息布局ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide the last panel and add new panel
            this.panel.Controls.Clear();
            this.homePage.Visible = false;
            this.panel.Visible = true;

            //set the attribution
            CanMessageLayout layout = new CanMessageLayout();
            layout.TopLevel = false;
            layout.Dock = System.Windows.Forms.DockStyle.Fill;
            layout.FormBorderStyle = FormBorderStyle.None;

            this.panel.Controls.Add(layout);
            layout.Show();
        }

      

       

      

      

    }
}
