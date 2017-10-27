namespace Set_Com
{
    partial class fm_set_Com
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.cbbDataBits = new System.Windows.Forms.ComboBox();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbbComList = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbComList);
            this.groupBox1.Location = new System.Drawing.Point(31, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择一个com口";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbParity);
            this.groupBox2.Controls.Add(this.cbbStopBits);
            this.groupBox2.Controls.Add(this.cbbDataBits);
            this.groupBox2.Controls.Add(this.cbbBaudRate);
            this.groupBox2.Location = new System.Drawing.Point(31, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM端口设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "波特率";
            // 
            // cbbParity
            // 
            this.cbbParity.FormattingEnabled = true;
            this.cbbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbbParity.Location = new System.Drawing.Point(271, 81);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(121, 20);
            this.cbbParity.TabIndex = 2;
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.FormattingEnabled = true;
            this.cbbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbStopBits.Location = new System.Drawing.Point(271, 23);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(121, 20);
            this.cbbStopBits.TabIndex = 3;
            // 
            // cbbDataBits
            // 
            this.cbbDataBits.FormattingEnabled = true;
            this.cbbDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cbbDataBits.Location = new System.Drawing.Point(79, 81);
            this.cbbDataBits.Name = "cbbDataBits";
            this.cbbDataBits.Size = new System.Drawing.Size(121, 20);
            this.cbbDataBits.TabIndex = 4;
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Location = new System.Drawing.Point(79, 20);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cbbBaudRate.TabIndex = 5;
            // 
            // cbbComList
            // 
            this.cbbComList.FormattingEnabled = true;
            this.cbbComList.Location = new System.Drawing.Point(6, 20);
            this.cbbComList.Name = "cbbComList";
            this.cbbComList.Size = new System.Drawing.Size(121, 20);
            this.cbbComList.TabIndex = 6;
            this.cbbComList.SelectedIndexChanged += new System.EventHandler(this.cbbComList_SelectedIndexChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(234, 309);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            
            // 
            // fm_set_Com
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fm_set_Com";
            this.Text = "设置COM口";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            //this.Load += new System.EventHandler(this.fm_set_Com_Load);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.ComboBox cbbComList;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button button2;
    }
}

