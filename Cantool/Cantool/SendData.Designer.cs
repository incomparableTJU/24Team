namespace Cantool
{
    partial class SendData
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
            this.cbx_message = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cycle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbx_message
            // 
            this.cbx_message.FormattingEnabled = true;
            this.cbx_message.Location = new System.Drawing.Point(16, 38);
            this.cbx_message.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_message.Name = "cbx_message";
            this.cbx_message.Size = new System.Drawing.Size(160, 23);
            this.cbx_message.TabIndex = 0;
            this.cbx_message.SelectedIndexChanged += new System.EventHandler(this.cbx_message_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "发送信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(16, 117);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(311, 220);
            this.panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "周期(0-65535ms)";
            // 
            // cycle
            // 
            this.cycle.Location = new System.Drawing.Point(213, 79);
            this.cycle.Name = "cycle";
            this.cycle.Size = new System.Drawing.Size(100, 25);
            this.cycle.TabIndex = 5;
            // 
            // SendData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 359);
            this.Controls.Add(this.cycle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cbx_message);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendData";
            this.Text = "SendData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cycle;
    }
}