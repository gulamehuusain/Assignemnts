namespace mycal
{
    partial class selfiles
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
            this.b2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(123, 98);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(335, 22);
            this.t1.TabIndex = 0;
            this.t1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(305, 150);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(76, 23);
            this.b1.TabIndex = 1;
            this.b1.Text = "Select";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Enabled = false;
            this.b2.Location = new System.Drawing.Point(185, 143);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 30);
            this.b2.TabIndex = 2;
            this.b2.Text = "Open File";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(176, 258);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(396, 140);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p1.TabIndex = 4;
            this.p1.TabStop = false;
            // 
            // selfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.t1);
            this.Name = "selfiles";
            this.Text = "selfiles";
            this.Load += new System.EventHandler(this.selfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox p1;
    }
}