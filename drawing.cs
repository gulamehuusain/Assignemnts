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
    public partial class drawing : Form
    {
        public drawing()
        {
            InitializeComponent();
        }
        bool var = false;
        private void drawing_Load(object sender, EventArgs e)
        {

        }

        private void drawing_MouseDown(object sender, MouseEventArgs e)
        {
            var = true;
        }

        private void drawing_MouseUp(object sender, MouseEventArgs e)
        {
            var = false;
        }

        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (var)
            {


                using (Graphics obj = CreateGraphics())
                {
                    if (r1.Checked && r6.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 3, 4);
                    }
                    else if (r1.Checked && r7.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 4, 5);
                    }
                    else if (r2.Checked && r6.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, 3, 4);
                    }
                    else if (r2.Checked && r7.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, 4, 5);
                    }
                    else if (r3.Checked && r6.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Brown), e.X, e.Y, 3, 4);
                    }
                    else if (r3.Checked && r7.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Brown), e.X, e.Y, 4, 5);
                    }
                    else if (r4.Checked && r6.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 3, 4);
                    }
                    else if (r4.Checked && r7.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 4, 5);
                    }

                    else if (r5.Checked && r6.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Green), e.X, e.Y, 3, 4);
                    }
                    else if (r5.Checked && r7.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Green), e.X, e.Y, 4, 5);
                    }
                }

            }
        }
    }
}
