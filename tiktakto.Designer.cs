namespace Assignemnts
{
    partial class tiktakto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tiktakto));
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Red;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(298, 294);
            this.b3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(204, 38);
            this.b3.TabIndex = 8;
            this.b3.Text = "Exit";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Red;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(298, 201);
            this.b2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(204, 49);
            this.b2.TabIndex = 7;
            this.b2.Text = "Multi Player";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Red;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(298, 118);
            this.b1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(204, 49);
            this.b1.TabIndex = 6;
            this.b1.Text = "Single Player";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // tiktakto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(843, 478);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "tiktakto";
            this.Text = "tiktakto";
            this.Load += new System.EventHandler(this.tiktakto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
    }
}