namespace mycal
{
    partial class flappy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flappy));
            this.b1 = new System.Windows.Forms.PictureBox();
            this.pi2 = new System.Windows.Forms.PictureBox();
            this.pi1 = new System.Windows.Forms.PictureBox();
            this.times = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi1)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Image = ((System.Drawing.Image)(resources.GetObject("b1.Image")));
            this.b1.Location = new System.Drawing.Point(100, 148);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(53, 37);
            this.b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b1.TabIndex = 0;
            this.b1.TabStop = false;
            this.b1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.getdown);
            // 
            // pi2
            // 
            this.pi2.Image = ((System.Drawing.Image)(resources.GetObject("pi2.Image")));
            this.pi2.Location = new System.Drawing.Point(502, 333);
            this.pi2.Name = "pi2";
            this.pi2.Size = new System.Drawing.Size(81, 117);
            this.pi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi2.TabIndex = 1;
            this.pi2.TabStop = false;
            this.pi2.Click += new System.EventHandler(this.pi2_Click);
            // 
            // pi1
            // 
            this.pi1.Image = ((System.Drawing.Image)(resources.GetObject("pi1.Image")));
            this.pi1.Location = new System.Drawing.Point(532, 1);
            this.pi1.Name = "pi1";
            this.pi1.Size = new System.Drawing.Size(81, 204);
            this.pi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pi1.TabIndex = 2;
            this.pi1.TabStop = false;
            this.pi1.Click += new System.EventHandler(this.pi1_Click);
            // 
            // times
            // 
            this.times.Enabled = true;
            this.times.Interval = 20;
            this.times.Tick += new System.EventHandler(this.times_Tick);
            // 
            // flappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pi1);
            this.Controls.Add(this.pi2);
            this.Controls.Add(this.b1);
            this.Name = "flappy";
            this.Text = "flappy";
            this.Load += new System.EventHandler(this.flappy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.flappy_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flappy_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pi1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox b1;
        private System.Windows.Forms.PictureBox pi2;
        private System.Windows.Forms.PictureBox pi1;
        private System.Windows.Forms.Timer times;
    }
}