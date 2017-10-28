namespace Cantool
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem wenjianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于CanToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 树状结构图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件存储ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem can信息物理值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仪表盘ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 实时曲线ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem can信息布局ToolStripMenuItem1;
        private System.Windows.Forms.Panel homePage;
        private System.Windows.Forms.Panel panel;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitem_set_com = new System.Windows.Forms.ToolStripMenuItem();
            this.用户设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canTool装置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.can总线通信参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件存储ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.can信息布局ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.树状结构图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.can信息物理值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仪表盘ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.实时曲线ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于CanToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wenjianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePage = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem,
            this.控制ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1046, 39);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menu";
            // 
            // 首页ToolStripMenuItem
            // 
            this.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            this.首页ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.首页ToolStripMenuItem.Text = "首页";
            this.首页ToolStripMenuItem.Click += new System.EventHandler(this.首页ToolStripMenuItem_Click);
            // 
            // 控制ToolStripMenuItem
            // 
            this.控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitem_set_com,
            this.用户设定ToolStripMenuItem,
            this.canTool装置ToolStripMenuItem,
            this.can总线通信参数ToolStripMenuItem});
            this.控制ToolStripMenuItem.Name = "控制ToolStripMenuItem";
            this.控制ToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.控制ToolStripMenuItem.Text = "数据传输";
            // 
            // mitem_set_com
            // 
            this.mitem_set_com.Name = "mitem_set_com";
            this.mitem_set_com.Size = new System.Drawing.Size(276, 36);
            this.mitem_set_com.Text = "设置COM口";
            this.mitem_set_com.Click += new System.EventHandler(this.mitem_set_com_Click);
            // 
            // 用户设定ToolStripMenuItem
            // 
            this.用户设定ToolStripMenuItem.Name = "用户设定ToolStripMenuItem";
            this.用户设定ToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.用户设定ToolStripMenuItem.Text = "发送设定物理值";
            this.用户设定ToolStripMenuItem.Click += new System.EventHandler(this.用户设定ToolStripMenuItem_Click);
            // 
            // canTool装置ToolStripMenuItem
            // 
            this.canTool装置ToolStripMenuItem.Name = "canTool装置ToolStripMenuItem";
            this.canTool装置ToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.canTool装置ToolStripMenuItem.Text = "CanTool装置";
            this.canTool装置ToolStripMenuItem.Click += new System.EventHandler(this.canTool装置ToolStripMenuItem_Click_1);
            // 
            // can总线通信参数ToolStripMenuItem
            // 
            this.can总线通信参数ToolStripMenuItem.Name = "can总线通信参数ToolStripMenuItem";
            this.can总线通信参数ToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.can总线通信参数ToolStripMenuItem.Text = "Can总线通信参数";
            this.can总线通信参数ToolStripMenuItem.Click += new System.EventHandler(this.can总线通信参数ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库ToolStripMenuItem,
            this.can信息物理值ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.设置ToolStripMenuItem.Text = "显示";
            // 
            // 数据库ToolStripMenuItem
            // 
            this.数据库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件存储ToolStripMenuItem,
            this.can信息布局ToolStripMenuItem1,
            this.树状结构图ToolStripMenuItem});
            this.数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            this.数据库ToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.数据库ToolStripMenuItem.Text = "数据库";
            // 
            // 文件存储ToolStripMenuItem
            // 
            this.文件存储ToolStripMenuItem.Name = "文件存储ToolStripMenuItem";
            this.文件存储ToolStripMenuItem.Size = new System.Drawing.Size(228, 36);
            this.文件存储ToolStripMenuItem.Text = "文件存储";
            this.文件存储ToolStripMenuItem.Click += new System.EventHandler(this.文件存储ToolStripMenuItem_Click);
            // 
            // can信息布局ToolStripMenuItem1
            // 
            this.can信息布局ToolStripMenuItem1.Name = "can信息布局ToolStripMenuItem1";
            this.can信息布局ToolStripMenuItem1.Size = new System.Drawing.Size(228, 36);
            this.can信息布局ToolStripMenuItem1.Text = "Can信息布局";
            this.can信息布局ToolStripMenuItem1.Click += new System.EventHandler(this.can信息布局ToolStripMenuItem1_Click);
            // 
            // 树状结构图ToolStripMenuItem
            // 
            this.树状结构图ToolStripMenuItem.Name = "树状结构图ToolStripMenuItem";
            this.树状结构图ToolStripMenuItem.Size = new System.Drawing.Size(228, 36);
            this.树状结构图ToolStripMenuItem.Text = "树状结构图";
            this.树状结构图ToolStripMenuItem.Click += new System.EventHandler(this.树状结构图ToolStripMenuItem_Click);
            // 
            // can信息物理值ToolStripMenuItem
            // 
            this.can信息物理值ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仪表盘ToolStripMenuItem1,
            this.实时曲线ToolStripMenuItem1});
            this.can信息物理值ToolStripMenuItem.Name = "can信息物理值ToolStripMenuItem";
            this.can信息物理值ToolStripMenuItem.Size = new System.Drawing.Size(252, 36);
            this.can信息物理值ToolStripMenuItem.Text = "Can信号物理值";
            // 
            // 仪表盘ToolStripMenuItem1
            // 
            this.仪表盘ToolStripMenuItem1.Name = "仪表盘ToolStripMenuItem1";
            this.仪表盘ToolStripMenuItem1.Size = new System.Drawing.Size(184, 36);
            this.仪表盘ToolStripMenuItem1.Text = "仪表盘";
            this.仪表盘ToolStripMenuItem1.Click += new System.EventHandler(this.仪表盘ToolStripMenuItem1_Click);
            // 
            // 实时曲线ToolStripMenuItem1
            // 
            this.实时曲线ToolStripMenuItem1.Name = "实时曲线ToolStripMenuItem1";
            this.实时曲线ToolStripMenuItem1.Size = new System.Drawing.Size(184, 36);
            this.实时曲线ToolStripMenuItem1.Text = "实时曲线";
            this.实时曲线ToolStripMenuItem1.Click += new System.EventHandler(this.实时曲线ToolStripMenuItem1_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于CanToolToolStripMenuItem,
            this.查看日志ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于CanToolToolStripMenuItem
            // 
            this.关于CanToolToolStripMenuItem.Name = "关于CanToolToolStripMenuItem";
            this.关于CanToolToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.关于CanToolToolStripMenuItem.Text = "关于CanTool";
            // 
            // 查看日志ToolStripMenuItem
            // 
            this.查看日志ToolStripMenuItem.Name = "查看日志ToolStripMenuItem";
            this.查看日志ToolStripMenuItem.Size = new System.Drawing.Size(230, 36);
            this.查看日志ToolStripMenuItem.Text = "查看日志";
            // 
            // wenjianToolStripMenuItem
            // 
            this.wenjianToolStripMenuItem.Name = "wenjianToolStripMenuItem";
            this.wenjianToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.wenjianToolStripMenuItem.Text = "首页";
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(13, 0);
            this.homePage.Margin = new System.Windows.Forms.Padding(4);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(1048, 748);
            this.homePage.TabIndex = 5;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.homePage);
            this.panel.Location = new System.Drawing.Point(0, 42);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1048, 724);
            this.panel.TabIndex = 5;
            this.panel.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 790);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStripMenuItem mitem_set_com;
        private System.Windows.Forms.ToolStripMenuItem canTool装置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem can总线通信参数ToolStripMenuItem;






    }
}