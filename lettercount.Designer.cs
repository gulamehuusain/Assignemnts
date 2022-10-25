namespace Assignemnts
{
    partial class lettercount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.ListBox();
            this.b1 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "THREE CHARACTER WORD LIST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ENTER TEXT";
            // 
            // l1
            // 
            this.l1.FormattingEnabled = true;
            this.l1.ItemHeight = 16;
            this.l1.Location = new System.Drawing.Point(355, 186);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(232, 196);
            this.l1.TabIndex = 7;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(415, 119);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 6;
            this.b1.Text = "count";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(291, 69);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(378, 22);
            this.t1.TabIndex = 5;
            // 
            // lettercount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.t1);
            this.Name = "lettercount";
            this.Text = "lettercount";
            this.Load += new System.EventHandler(this.lettercount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox t1;
    }
}