namespace testCom
{
    partial class Form1
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
            this.cbbComList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.chkAutoLine = new System.Windows.Forms.CheckBox();
            this.rbtnSendHex = new System.Windows.Forms.RadioButton();
            this.rbtnSendASCII = new System.Windows.Forms.RadioButton();
            this.rbtnSendUTF8 = new System.Windows.Forms.RadioButton();
            this.rbtnSendUnicode = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnASCII = new System.Windows.Forms.RadioButton();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.rbtnUTF8 = new System.Windows.Forms.RadioButton();
            this.rbtnUnicode = new System.Windows.Forms.RadioButton();
            this.txtShowData = new System.Windows.Forms.TextBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbComList
            // 
            this.cbbComList.FormattingEnabled = true;
            this.cbbComList.Location = new System.Drawing.Point(65, 85);
            this.cbbComList.Name = "cbbComList";
            this.cbbComList.Size = new System.Drawing.Size(121, 20);
            this.cbbComList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Location = new System.Drawing.Point(65, 135);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cbbBaudRate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // cbbDataBits
            // 
            this.cbbDataBits.FormattingEnabled = true;
            this.cbbDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cbbDataBits.Location = new System.Drawing.Point(65, 188);
            this.cbbDataBits.Name = "cbbDataBits";
            this.cbbDataBits.Size = new System.Drawing.Size(121, 20);
            this.cbbDataBits.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位";
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.FormattingEnabled = true;
            this.cbbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbStopBits.Location = new System.Drawing.Point(65, 236);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(121, 20);
            this.cbbStopBits.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "停止位";
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
            this.cbbParity.Location = new System.Drawing.Point(65, 290);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(121, 20);
            this.cbbParity.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "校验位";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(186, 357);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chkAutoLine
            // 
            this.chkAutoLine.AutoSize = true;
            this.chkAutoLine.Location = new System.Drawing.Point(333, 48);
            this.chkAutoLine.Name = "chkAutoLine";
            this.chkAutoLine.Size = new System.Drawing.Size(72, 16);
            this.chkAutoLine.TabIndex = 3;
            this.chkAutoLine.Text = "自动换行";
            this.chkAutoLine.UseVisualStyleBackColor = true;
            // 
            // rbtnSendHex
            // 
            this.rbtnSendHex.AutoSize = true;
            this.rbtnSendHex.Location = new System.Drawing.Point(347, 433);
            this.rbtnSendHex.Name = "rbtnSendHex";
            this.rbtnSendHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnSendHex.TabIndex = 4;
            this.rbtnSendHex.TabStop = true;
            this.rbtnSendHex.Text = "Hex";
            this.rbtnSendHex.UseVisualStyleBackColor = true;
            // 
            // rbtnSendASCII
            // 
            this.rbtnSendASCII.AutoSize = true;
            this.rbtnSendASCII.Location = new System.Drawing.Point(394, 433);
            this.rbtnSendASCII.Name = "rbtnSendASCII";
            this.rbtnSendASCII.Size = new System.Drawing.Size(53, 16);
            this.rbtnSendASCII.TabIndex = 4;
            this.rbtnSendASCII.TabStop = true;
            this.rbtnSendASCII.Text = "ASCII";
            this.rbtnSendASCII.UseVisualStyleBackColor = true;
            // 
            // rbtnSendUTF8
            // 
            this.rbtnSendUTF8.AutoSize = true;
            this.rbtnSendUTF8.Location = new System.Drawing.Point(453, 433);
            this.rbtnSendUTF8.Name = "rbtnSendUTF8";
            this.rbtnSendUTF8.Size = new System.Drawing.Size(53, 16);
            this.rbtnSendUTF8.TabIndex = 4;
            this.rbtnSendUTF8.TabStop = true;
            this.rbtnSendUTF8.Text = "UTF-8";
            this.rbtnSendUTF8.UseVisualStyleBackColor = true;
            this.rbtnSendUTF8.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbtnSendUnicode
            // 
            this.rbtnSendUnicode.AutoSize = true;
            this.rbtnSendUnicode.Location = new System.Drawing.Point(512, 432);
            this.rbtnSendUnicode.Name = "rbtnSendUnicode";
            this.rbtnSendUnicode.Size = new System.Drawing.Size(65, 16);
            this.rbtnSendUnicode.TabIndex = 4;
            this.rbtnSendUnicode.TabStop = true;
            this.rbtnSendUnicode.Text = "Unicode";
            this.rbtnSendUnicode.UseVisualStyleBackColor = true;
            this.rbtnSendUnicode.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(307, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 100);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtnUnicode);
            this.panel3.Controls.Add(this.rbtnUTF8);
            this.panel3.Controls.Add(this.rbtnASCII);
            this.panel3.Controls.Add(this.rbtnHex);
            this.panel3.Location = new System.Drawing.Point(411, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 100);
            this.panel3.TabIndex = 9;
            // 
            // rbtnASCII
            // 
            this.rbtnASCII.AutoSize = true;
            this.rbtnASCII.Location = new System.Drawing.Point(121, 35);
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.Size = new System.Drawing.Size(53, 16);
            this.rbtnASCII.TabIndex = 1;
            this.rbtnASCII.TabStop = true;
            this.rbtnASCII.Text = "ASCII";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(23, 35);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnHex.TabIndex = 0;
            this.rbtnHex.TabStop = true;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            // 
            // rbtnUTF8
            // 
            this.rbtnUTF8.AutoSize = true;
            this.rbtnUTF8.Location = new System.Drawing.Point(222, 35);
            this.rbtnUTF8.Name = "rbtnUTF8";
            this.rbtnUTF8.Size = new System.Drawing.Size(53, 16);
            this.rbtnUTF8.TabIndex = 1;
            this.rbtnUTF8.TabStop = true;
            this.rbtnUTF8.Text = "UTF-8";
            this.rbtnUTF8.UseVisualStyleBackColor = true;
            // 
            // rbtnUnicode
            // 
            this.rbtnUnicode.AutoSize = true;
            this.rbtnUnicode.Location = new System.Drawing.Point(334, 35);
            this.rbtnUnicode.Name = "rbtnUnicode";
            this.rbtnUnicode.Size = new System.Drawing.Size(65, 16);
            this.rbtnUnicode.TabIndex = 1;
            this.rbtnUnicode.TabStop = true;
            this.rbtnUnicode.Text = "Unicode";
            this.rbtnUnicode.UseVisualStyleBackColor = true;
            // 
            // txtShowData
            // 
            this.txtShowData.Location = new System.Drawing.Point(398, 118);
            this.txtShowData.Multiline = true;
            this.txtShowData.Name = "txtShowData";
            this.txtShowData.Size = new System.Drawing.Size(491, 192);
            this.txtShowData.TabIndex = 10;
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(398, 327);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(491, 69);
            this.txtSendData.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(880, 425);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "手动发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 504);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.txtShowData);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rbtnSendUnicode);
            this.Controls.Add(this.rbtnSendUTF8);
            this.Controls.Add(this.rbtnSendASCII);
            this.Controls.Add(this.rbtnSendHex);
            this.Controls.Add(this.chkAutoLine);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbParity);
            this.Controls.Add(this.cbbStopBits);
            this.Controls.Add(this.cbbDataBits);
            this.Controls.Add(this.cbbBaudRate);
            this.Controls.Add(this.cbbComList);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbComList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox chkAutoLine;
        private System.Windows.Forms.RadioButton rbtnSendHex;
        private System.Windows.Forms.RadioButton rbtnSendASCII;
        private System.Windows.Forms.RadioButton rbtnSendUTF8;
        private System.Windows.Forms.RadioButton rbtnSendUnicode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnUnicode;
        private System.Windows.Forms.RadioButton rbtnUTF8;
        private System.Windows.Forms.RadioButton rbtnASCII;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.TextBox txtShowData;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Button btnSend;
    }
}

