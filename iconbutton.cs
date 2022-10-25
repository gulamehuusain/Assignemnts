using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemnts
{
    public partial class iconbutton : Form
    {
        public iconbutton()
        {
            InitializeComponent();
        }
        private MessageBoxButtons btt { get; set; }
        private MessageBoxIcon icc { get; set; }
        private void submit_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Wrong", "FALSE", btt, icc);
            switch (result)
            {

                case DialogResult.OK:
                    t1.Text = "oK is pressed";
                    break;
                case DialogResult.Cancel:
                    t1.Text = "Cancel is pressed";
                    break;
                case DialogResult.Retry:
                    t1.Text = "Retry IS PRESSED";
                    break;
                case DialogResult.Yes:
                    t1.Text = "yes  IS PRESSED";
                    break;
                case DialogResult.No:
                    t1.Text = "No is pressed";
                    break;
                case DialogResult.Abort:
                    t1.Text = "Abort";
                    break;

            }


        }

        private void btns_Enter(object sender, EventArgs e)
        {



            if (sender == r1)
            {

                btt = MessageBoxButtons.OK;

            }
            else if (sender == okcancel)
            {

                btt = MessageBoxButtons.OKCancel;

            }
            else if (sender == ari)
            {

                btt = MessageBoxButtons.AbortRetryIgnore;

            }
            else if (sender == yn)
            {

                btt = MessageBoxButtons.YesNo;

            }
            else if (sender == ync)
            {

                btt = MessageBoxButtons.YesNoCancel;

            }
            else if (sender == rc)
            {

                btt = MessageBoxButtons.RetryCancel;

            }

        }
    

        

        private void icns_Enter(object sender, EventArgs e)
        {

            if (sender == r7)
            {

                icc = MessageBoxIcon.Asterisk;
            }
            else if (sender == error)
            {

                icc = MessageBoxIcon.Error;
            }
            else if (sender == exclamation)
            {

                icc = MessageBoxIcon.Exclamation;
            }
            else if (sender == hand)
            {

                icc = MessageBoxIcon.Hand;
            }
            else if (sender == info)
            {

                icc = MessageBoxIcon.Information;
            }
            else if (sender == question)
            {

                icc = MessageBoxIcon.Question;
            }
            else if (sender == stop)
            {

                icc = MessageBoxIcon.Stop;
            }
            else if (sender == warning)
            {

                icc = MessageBoxIcon.Warning;
            }
        }
    }
}

    

