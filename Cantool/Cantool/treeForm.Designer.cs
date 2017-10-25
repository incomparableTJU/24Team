namespace Cantool
{
    partial class TreeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout(); //防止控件属性改变时不断重画
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;   //填满整个窗体
            this.treeView1.Location = new System.Drawing.Point(0, 0);//设置左上角相对于容器左上角的位置
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(292, 273);//设置高度和宽度
            this.treeView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);//获取或设置控件的设计尺寸
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;//获取或设置控件的自动缩放模式
            this.ClientSize = new System.Drawing.Size(292, 273);  //获取或设置窗体工作区大小1
            this.Controls.Add(this.treeView1);   //将指定控件添加到控件集合中
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;   //获取或设置窗体的边框格式
            this.MaximizeBox = false;//是否在窗体中显示最大化按钮
            this.Name = "MainForm"; //设置控件名称
            this.Text = "CSWinFormCreateTreeView";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
    }
}

