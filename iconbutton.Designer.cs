namespace Assignemnts
{
    partial class iconbutton
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
            this.submit = new System.Windows.Forms.Button();
            this.icns = new System.Windows.Forms.GroupBox();
            this.warning = new System.Windows.Forms.RadioButton();
            this.stop = new System.Windows.Forms.RadioButton();
            this.question = new System.Windows.Forms.RadioButton();
            this.info = new System.Windows.Forms.RadioButton();
            this.hand = new System.Windows.Forms.RadioButton();
            this.exclamation = new System.Windows.Forms.RadioButton();
            this.error = new System.Windows.Forms.RadioButton();
            this.r7 = new System.Windows.Forms.RadioButton();
            this.btns = new System.Windows.Forms.GroupBox();
            this.rc = new System.Windows.Forms.RadioButton();
            this.ync = new System.Windows.Forms.RadioButton();
            this.yn = new System.Windows.Forms.RadioButton();
            this.ari = new System.Windows.Forms.RadioButton();
            this.okcancel = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.icns.SuspendLayout();
            this.btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(110, 428);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(454, 22);
            this.t1.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(169, 331);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // icns
            // 
            this.icns.Controls.Add(this.warning);
            this.icns.Controls.Add(this.stop);
            this.icns.Controls.Add(this.question);
            this.icns.Controls.Add(this.info);
            this.icns.Controls.Add(this.hand);
            this.icns.Controls.Add(this.exclamation);
            this.icns.Controls.Add(this.error);
            this.icns.Controls.Add(this.r7);
            this.icns.Location = new System.Drawing.Point(328, 1);
            this.icns.Name = "icns";
            this.icns.Size = new System.Drawing.Size(362, 353);
            this.icns.TabIndex = 5;
            this.icns.TabStop = false;
            this.icns.Text = "icons";
            this.icns.Enter += new System.EventHandler(this.icns_Enter);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(20, 315);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(78, 20);
            this.warning.TabIndex = 22;
            this.warning.Text = "Warning";
            this.warning.UseVisualStyleBackColor = true;
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Location = new System.Drawing.Point(20, 286);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(56, 20);
            this.stop.TabIndex = 21;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(20, 243);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(81, 20);
            this.question.TabIndex = 20;
            this.question.Text = "Question";
            this.question.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(20, 199);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(93, 20);
            this.info.TabIndex = 19;
            this.info.Text = "Information";
            this.info.UseVisualStyleBackColor = true;
            // 
            // hand
            // 
            this.hand.AutoSize = true;
            this.hand.Location = new System.Drawing.Point(20, 156);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(61, 20);
            this.hand.TabIndex = 18;
            this.hand.Text = "Hand";
            this.hand.UseVisualStyleBackColor = true;
            // 
            // exclamation
            // 
            this.exclamation.AutoSize = true;
            this.exclamation.Location = new System.Drawing.Point(20, 113);
            this.exclamation.Name = "exclamation";
            this.exclamation.Size = new System.Drawing.Size(101, 20);
            this.exclamation.TabIndex = 17;
            this.exclamation.Text = "Exclamation";
            this.exclamation.UseVisualStyleBackColor = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(20, 75);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(57, 20);
            this.error.TabIndex = 16;
            this.error.Text = "Error";
            this.error.UseVisualStyleBackColor = true;
            // 
            // r7
            // 
            this.r7.AutoSize = true;
            this.r7.Location = new System.Drawing.Point(20, 34);
            this.r7.Name = "r7";
            this.r7.Size = new System.Drawing.Size(76, 20);
            this.r7.TabIndex = 15;
            this.r7.Text = "Asterisk";
            this.r7.UseVisualStyleBackColor = true;
            // 
            // btns
            // 
            this.btns.Controls.Add(this.rc);
            this.btns.Controls.Add(this.ync);
            this.btns.Controls.Add(this.yn);
            this.btns.Controls.Add(this.ari);
            this.btns.Controls.Add(this.okcancel);
            this.btns.Controls.Add(this.r1);
            this.btns.Location = new System.Drawing.Point(110, 15);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(200, 293);
            this.btns.TabIndex = 4;
            this.btns.TabStop = false;
            this.btns.Text = "button";
            this.btns.Enter += new System.EventHandler(this.btns_Enter);
            // 
            // rc
            // 
            this.rc.AutoSize = true;
            this.rc.Location = new System.Drawing.Point(22, 243);
            this.rc.Name = "rc";
            this.rc.Size = new System.Drawing.Size(102, 20);
            this.rc.TabIndex = 14;
            this.rc.Text = "RetryCancel";
            this.rc.UseVisualStyleBackColor = true;
            // 
            // ync
            // 
            this.ync.AutoSize = true;
            this.ync.Location = new System.Drawing.Point(22, 199);
            this.ync.Name = "ync";
            this.ync.Size = new System.Drawing.Size(112, 20);
            this.ync.TabIndex = 13;
            this.ync.Text = "YesNoCancel";
            this.ync.UseVisualStyleBackColor = true;
            // 
            // yn
            // 
            this.yn.AutoSize = true;
            this.yn.Location = new System.Drawing.Point(22, 156);
            this.yn.Name = "yn";
            this.yn.Size = new System.Drawing.Size(70, 20);
            this.yn.TabIndex = 12;
            this.yn.Text = "YesNo";
            this.yn.UseVisualStyleBackColor = true;
            // 
            // ari
            // 
            this.ari.AutoSize = true;
            this.ari.Location = new System.Drawing.Point(22, 113);
            this.ari.Name = "ari";
            this.ari.Size = new System.Drawing.Size(133, 20);
            this.ari.TabIndex = 11;
            this.ari.Text = "AboutRetryignore";
            this.ari.UseVisualStyleBackColor = true;
            // 
            // okcancel
            // 
            this.okcancel.AutoSize = true;
            this.okcancel.Location = new System.Drawing.Point(22, 75);
            this.okcancel.Name = "okcancel";
            this.okcancel.Size = new System.Drawing.Size(87, 20);
            this.okcancel.TabIndex = 10;
            this.okcancel.Text = "OkCancel";
            this.okcancel.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(22, 34);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(45, 20);
            this.r1.TabIndex = 9;
            this.r1.Text = "Ok";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // iconbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.icns);
            this.Controls.Add(this.btns);
            this.Name = "iconbutton";
            this.Text = "iconbutton";
            this.icns.ResumeLayout(false);
            this.icns.PerformLayout();
            this.btns.ResumeLayout(false);
            this.btns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.GroupBox icns;
        private System.Windows.Forms.RadioButton warning;
        private System.Windows.Forms.RadioButton stop;
        private System.Windows.Forms.RadioButton question;
        private System.Windows.Forms.RadioButton info;
        private System.Windows.Forms.RadioButton hand;
        private System.Windows.Forms.RadioButton exclamation;
        private System.Windows.Forms.RadioButton error;
        private System.Windows.Forms.RadioButton r7;
        private System.Windows.Forms.GroupBox btns;
        private System.Windows.Forms.RadioButton rc;
        private System.Windows.Forms.RadioButton ync;
        private System.Windows.Forms.RadioButton yn;
        private System.Windows.Forms.RadioButton ari;
        private System.Windows.Forms.RadioButton okcancel;
        private System.Windows.Forms.RadioButton r1;
    }
}