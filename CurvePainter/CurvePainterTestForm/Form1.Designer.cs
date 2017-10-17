namespace CurvePainterTestForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtWarning = new System.Windows.Forms.TextBox();
            this.curvePainter1 = new CurvePainter.CurvePainter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(554, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 181);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtWarning
            // 
            this.txtWarning.Location = new System.Drawing.Point(554, 3);
            this.txtWarning.Multiline = true;
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWarning.Size = new System.Drawing.Size(230, 186);
            this.txtWarning.TabIndex = 4;
            // 
            // curvePainter1
            // 
            this.curvePainter1.BackColor = System.Drawing.Color.Black;
            this.curvePainter1.DataSource = null;
            this.curvePainter1.GridValue = 0.1F;
            this.curvePainter1.LinesColors = null;
            this.curvePainter1.Location = new System.Drawing.Point(2, 3);
            this.curvePainter1.MaxValue = 0F;
            this.curvePainter1.MinValue = 0F;
            this.curvePainter1.Name = "curvePainter1";
            this.curvePainter1.Size = new System.Drawing.Size(532, 373);
            this.curvePainter1.StandardValue = 0F;
            this.curvePainter1.StartValue = -1F;
            this.curvePainter1.TabIndex = 3;
            this.curvePainter1.Text = "curvePainter1";
            this.curvePainter1.XElements = ((System.Collections.Generic.List<string>)(resources.GetObject("curvePainter1.XElements")));
            this.curvePainter1.YGridCount = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 443);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.curvePainter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CurvePainter.CurvePainter curvePainter1;
        private System.Windows.Forms.TextBox txtWarning;



    }
}

