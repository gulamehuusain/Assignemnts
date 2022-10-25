using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycal
{
    public partial class drw : Form
    {
        public drw()
        {
            InitializeComponent();
        }

        private void drw_Load(object sender,EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    
        bool var = false;
        private void p2_MouseHover(object sender, EventArgs e)
        {

        }

        private void p2_MouseUp(object sender, MouseEventArgs e)
        {
            var = false;
        }

        private void p2_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void p2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void drw_MouseDown(object sender, MouseEventArgs e)
        {
            var = true;
        }

        private void drw_MouseUp(object sender, MouseEventArgs e)
        {
            var = false;
        }
          
        private void drw_MouseMove(object sender, MouseEventArgs e)
        {
            if (var)
            {


                using (Graphics obj = CreateGraphics())
                {
                    if (r1.Checked && r6.Checked )
                    {
                        obj.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 3, 4);
                    }
                    else if (r1.Checked && r7.Checked)
                    {
                        obj.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 4, 5);
                    }
                    else if (r2.Checked && r6.Checked) {
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

        private void color_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void sizes_Paint(object sender, PaintEventArgs e)
        {

        }
        bool draw;
        private void p1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
        }

        private void p1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void p1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw == true)
            {

                using (Graphics g = p1.CreateGraphics()) {

                    g.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 3, 4);
                    

                }

            }
        }
    }
}
