namespace Assignemnts
{
    partial class compares
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
            this.comp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.ListBox();
            this.l1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comp
            // 
            this.comp.Location = new System.Drawing.Point(332, 329);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(75, 23);
            this.comp.TabIndex = 16;
            this.comp.Text = "compare";
            this.comp.UseVisualStyleBackColor = true;
            this.comp.Click += new System.EventHandler(this.comp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filepath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filepath";
            // 
            // l2
            // 
            this.l2.FormattingEnabled = true;
            this.l2.ItemHeight = 16;
            this.l2.Location = new System.Drawing.Point(451, 136);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(300, 84);
            this.l2.TabIndex = 13;
            // 
            // l1
            // 
            this.l1.FormattingEnabled = true;
            this.l1.ItemHeight = 16;
            this.l1.Location = new System.Drawing.Point(159, 136);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(140, 84);
            this.l1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(466, 99);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 22);
            this.t2.TabIndex = 10;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(172, 99);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 22);
            this.t1.TabIndex = 9;
            // 
            // compares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Name = "compares";
            this.Text = "compares";
            this.Load += new System.EventHandler(this.compares_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button comp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox l2;
        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
    }
}