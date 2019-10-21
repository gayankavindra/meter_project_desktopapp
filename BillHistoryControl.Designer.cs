namespace WindowsFormsApp1
{
    partial class BillHistoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(688, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox7.Location = new System.Drawing.Point(460, 34);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(196, 26);
            this.textBox7.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(296, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Account number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(962, 496);
            this.dataGridView1.TabIndex = 43;
            // 
            // BillHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "BillHistoryControl";
            this.Size = new System.Drawing.Size(1091, 645);
            this.Load += new System.EventHandler(this.BillHistoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
