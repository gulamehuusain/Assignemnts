namespace Assignemnts
{
    partial class movingbutton
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
            this.close1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close1
            // 
            this.close1.Location = new System.Drawing.Point(350, 198);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(100, 55);
            this.close1.TabIndex = 1;
            this.close1.Text = "Close_load";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // movingbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close1);
            this.Name = "movingbutton";
            this.Text = "movingbutton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close1;
    }
}