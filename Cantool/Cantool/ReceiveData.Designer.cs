namespace Set_Com
{
    partial class fm_receivedata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tbx_receivedata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_receivedata
            // 
            this.tbx_receivedata.Location = new System.Drawing.Point(20, 28);
            this.tbx_receivedata.Multiline = true;
            this.tbx_receivedata.Name = "tbx_receivedata";
            this.tbx_receivedata.Size = new System.Drawing.Size(381, 256);
            this.tbx_receivedata.TabIndex = 0;
            // 
            // fm_receivedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 352);
            this.Controls.Add(this.tbx_receivedata);
            this.Name = "fm_receivedata";
            this.Text = "接收数据";
            this.ResumeLayout(false);
            this.PerformLayout();
            //this.Load += new System.EventHandler(this.fm_receivedata_Load);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_receivedata;
        
    }
}