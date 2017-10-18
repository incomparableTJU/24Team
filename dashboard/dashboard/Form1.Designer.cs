namespace dashboard
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
            
     //       this.timer1.Enabled = true;
       //     this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.aGauge2 = new dashboard.AGauge();
            this.SuspendLayout();
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 130;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(2));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black };
            this.aGauge2.CapPosition = new System.Drawing.Point(102, 200);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(142, 100),
        new System.Drawing.Point(102, 200),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "mV",
        "",
        ""};
            this.aGauge2.CapText = "mV";
            this.aGauge2.Center = new System.Drawing.Point(170, 170);
            this.aGauge2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge2.Location = new System.Drawing.Point(66, 78);
            this.aGauge2.Margin = new System.Windows.Forms.Padding(4);
            this.aGauge2.MaxValue = 400F;   //最大值
            this.aGauge2.MinValue = -100F;   //最小值
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = dashboard.AGauge.NeedleColorEnum.Yellow;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 130;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 5;
            this.aGauge2.Range_Idx = ((byte)(1));
            this.aGauge2.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 290F;
            this.aGauge2.RangeInnerRadius = 100;
            this.aGauge2.RangeOuterRadius = 130;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {//不同颜色结束数值
        100F,
        290F,
        400F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        100,
        100,
        100,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        130,
        130,
        130,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {//不同颜色开始数值
        -100F,
        100F,
        290F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 100F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 130;
            this.aGauge2.ScaleLinesInterOuterRadius = 140;
            this.aGauge2.ScaleLinesInterWidth = 2;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 130;
            this.aGauge2.ScaleLinesMajorOuterRadius = 142;
            this.aGauge2.ScaleLinesMajorStepValue = 50F;
            this.aGauge2.ScaleLinesMajorWidth = 3;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 130;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 140;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 160;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(567, 414);
            this.aGauge2.TabIndex = 4;
            this.aGauge2.Text = "aGauge2";


            System.Random rnd = new System.Random();
            rand = rnd.Next(0, 255);
            this.aGauge2.Value = rand;
            this.aGauge2.Refresh();
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 542);
            this.Controls.Add(this.aGauge2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
    }

    #endregion
        private AGauge aGauge2;
     //   private System.Windows.Forms.Timer timer1;
        int rand;
    }
}

