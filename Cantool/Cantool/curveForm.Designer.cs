namespace Cantool
{
    partial class CurveForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.cbx_message = new System.Windows.Forms.ComboBox();
            this.cbx_signal = new System.Windows.Forms.ComboBox();
            this.cbx_count = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(417, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.Location = new System.Drawing.Point(4, 42);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(488, 320);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(507, 8);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbx_message
            // 
            this.cbx_message.FormattingEnabled = true;
            this.cbx_message.Location = new System.Drawing.Point(12, 13);
            this.cbx_message.Name = "cbx_message";
            this.cbx_message.Size = new System.Drawing.Size(121, 20);
            this.cbx_message.TabIndex = 3;
            this.cbx_message.SelectedIndexChanged += new System.EventHandler(this.cbx_message_SelectedIndexChanged);
            // 
            // cbx_signal
            // 
            this.cbx_signal.FormattingEnabled = true;
            this.cbx_signal.Location = new System.Drawing.Point(139, 12);
            this.cbx_signal.Name = "cbx_signal";
            this.cbx_signal.Size = new System.Drawing.Size(121, 20);
            this.cbx_signal.TabIndex = 4;
            this.cbx_signal.SelectedIndexChanged += new System.EventHandler(this.cbx_signal_SelectedIndexChanged);
            // 
            // cbx_count
            // 
            this.cbx_count.FormattingEnabled = true;
            this.cbx_count.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.cbx_count.Location = new System.Drawing.Point(266, 11);
            this.cbx_count.Name = "cbx_count";
            this.cbx_count.Size = new System.Drawing.Size(121, 20);
            this.cbx_count.TabIndex = 5;
            this.cbx_count.SelectedIndexChanged += new System.EventHandler(this.cbx_count_SelectedIndexChanged);
            // 
            // CurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 476);
            this.Controls.Add(this.cbx_count);
            this.Controls.Add(this.cbx_signal);
            this.Controls.Add(this.cbx_message);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnStart);
            this.Name = "CurveForm";
            this.Text = "curvegraph";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbx_message;
        private System.Windows.Forms.ComboBox cbx_signal;
        private System.Windows.Forms.ComboBox cbx_count;
    }
}
