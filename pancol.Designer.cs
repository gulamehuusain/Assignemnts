namespace mycal
{
    partial class pancol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colr = new System.Windows.Forms.Panel();
            this.colr1 = new System.Windows.Forms.RadioButton();
            this.sizes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sizes);
            this.groupBox1.Controls.Add(this.colr1);
            this.groupBox1.Controls.Add(this.colr);
            this.groupBox1.Location = new System.Drawing.Point(85, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "box color";
            // 
            // colr
            // 
            this.colr.Location = new System.Drawing.Point(238, 34);
            this.colr.Name = "colr";
            this.colr.Size = new System.Drawing.Size(264, 280);
            this.colr.TabIndex = 0;
            this.colr.Paint += new System.Windows.Forms.PaintEventHandler(this.colr_Paint);
            // 
            // colr1
            // 
            this.colr1.AutoSize = true;
            this.colr1.Location = new System.Drawing.Point(33, 60);
            this.colr1.Name = "colr1";
            this.colr1.Size = new System.Drawing.Size(58, 20);
            this.colr1.TabIndex = 1;
            this.colr1.TabStop = true;
            this.colr1.Text = "color";
            this.colr1.UseVisualStyleBackColor = true;
            // 
            // sizes
            // 
            this.sizes.AutoSize = true;
            this.sizes.Location = new System.Drawing.Point(33, 104);
            this.sizes.Name = "sizes";
            this.sizes.Size = new System.Drawing.Size(52, 20);
            this.sizes.TabIndex = 2;
            this.sizes.TabStop = true;
            this.sizes.Text = "size";
            this.sizes.UseVisualStyleBackColor = true;
            // 
            // pancol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "pancol";
            this.Text = "pancol";
            this.Load += new System.EventHandler(this.pancol_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pancol_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel colr;
        private System.Windows.Forms.RadioButton sizes;
        private System.Windows.Forms.RadioButton colr1;
    }
}