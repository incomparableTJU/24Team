namespace Cantool
{
    partial class SetCantool
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
            this.buttonVerson = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxVerson = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelState = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVerson
            // 
            this.buttonVerson.Location = new System.Drawing.Point(678, 201);
            this.buttonVerson.Name = "buttonVerson";
            this.buttonVerson.Size = new System.Drawing.Size(125, 52);
            this.buttonVerson.TabIndex = 0;
            this.buttonVerson.Text = "获取";
            this.buttonVerson.UseVisualStyleBackColor = true;
            this.buttonVerson.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(355, 79);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(114, 40);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "打开";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(505, 79);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 40);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxVerson
            // 
            this.textBoxVerson.Location = new System.Drawing.Point(174, 194);
            this.textBoxVerson.Multiline = true;
            this.textBoxVerson.Name = "textBoxVerson";
            this.textBoxVerson.ReadOnly = true;
            this.textBoxVerson.Size = new System.Drawing.Size(449, 61);
            this.textBoxVerson.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(120, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantool装置版本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelState);
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Controls.Add(this.buttonClose);
            this.groupBox2.Location = new System.Drawing.Point(120, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantool装置状态";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelState.Location = new System.Drawing.Point(113, 80);
            this.labelState.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(116, 35);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "已关闭";
            // 
            // SetCantool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 677);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxVerson);
            this.Controls.Add(this.buttonVerson);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetCantool";
            this.Text = "SetCantool";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVerson;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxVerson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelState;
    }
}