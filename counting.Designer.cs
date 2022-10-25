namespace mycal
{
    partial class counting
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(287, 100);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(378, 22);
            this.t1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(411, 150);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 1;
            this.b1.Text = "count";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // l1
            // 
            this.l1.FormattingEnabled = true;
            this.l1.ItemHeight = 16;
            this.l1.Location = new System.Drawing.Point(351, 217);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(232, 196);
            this.l1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ENTER TEXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "THREE CHARACTER WORD LIST";
            // 
            // counting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.t1);
            this.Name = "counting";
            this.Text = "counting";
            this.Load += new System.EventHandler(this.counting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}