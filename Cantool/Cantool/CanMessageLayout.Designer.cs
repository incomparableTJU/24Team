using System.Drawing;
namespace Cantool
{
    partial class CanMessageLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView canLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7;

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
            this.canLayout = new System.Windows.Forms.DataGridView();
            this.column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageComboBox = new System.Windows.Forms.ComboBox();
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // canLayout
            // 
            this.canLayout.AllowUserToAddRows = false;
            this.canLayout.AllowUserToDeleteRows = false;
            this.canLayout.AllowUserToResizeColumns = false;
            this.canLayout.AllowUserToResizeRows = false;
            this.canLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column0,
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5,
            this.column6,
            this.column7});
            this.canLayout.Location = new System.Drawing.Point(170, 219);
            this.canLayout.Name = "canLayout";
            this.canLayout.ReadOnly = true;
            this.canLayout.RowHeadersWidth = 30;
            this.canLayout.RowTemplate.Height = 37;
            this.canLayout.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.canLayout.Size = new System.Drawing.Size(705, 445);
            this.canLayout.TabIndex = 0;
            // 
            // column0
            // 
            this.column0.HeaderText = "7";
            this.column0.Name = "column0";
            this.column0.ReadOnly = true;
            this.column0.Width = 40;
            // 
            // column1
            // 
            this.column1.HeaderText = "6";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.Width = 40;
            // 
            // column2
            // 
            this.column2.HeaderText = "5";
            this.column2.Name = "column2";
            this.column2.ReadOnly = true;
            this.column2.Width = 40;
            // 
            // column3
            // 
            this.column3.HeaderText = "4";
            this.column3.Name = "column3";
            this.column3.ReadOnly = true;
            this.column3.Width = 40;
            // 
            // column4
            // 
            this.column4.HeaderText = "3";
            this.column4.Name = "column4";
            this.column4.ReadOnly = true;
            this.column4.Width = 40;
            // 
            // column5
            // 
            this.column5.HeaderText = "2";
            this.column5.Name = "column5";
            this.column5.ReadOnly = true;
            this.column5.Width = 40;
            // 
            // column6
            // 
            this.column6.HeaderText = "1";
            this.column6.Name = "column6";
            this.column6.ReadOnly = true;
            this.column6.Width = 40;
            // 
            // column7
            // 
            this.column7.HeaderText = "0";
            this.column7.Name = "column7";
            this.column7.ReadOnly = true;
            this.column7.Width = 40;
            // 
            // messageComboBox
            // 
            this.messageComboBox.FormattingEnabled = true;
            this.messageComboBox.Location = new System.Drawing.Point(442, 123);
            this.messageComboBox.Name = "messageComboBox";
            this.messageComboBox.Size = new System.Drawing.Size(349, 32);
            this.messageComboBox.TabIndex = 1;
            this.messageComboBox.SelectedIndexChanged += new System.EventHandler(this.messageComboBox_SelectedIndexChanged);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(256, 126);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(142, 24);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Can信息类别";
            // 
            // CanMessageLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 766);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.messageComboBox);
            this.Controls.Add(this.canLayout);
            this.Name = "CanMessageLayout";
            ((System.ComponentModel.ISupportInitialize)(this.canLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox messageComboBox;
        private System.Windows.Forms.Label messageLabel;

    }
}