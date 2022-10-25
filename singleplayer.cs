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
    public partial class singleplayer : Form
    {
        public singleplayer()
        {
            InitializeComponent();
        }
        bool radio;
        Random ran = new Random();

        int end = 9;
        private void bclick(object sender, EventArgs e)
        {

        }
        bool check;

        int count;
        private void won()
        {

            if ((r1.Text == r11.Text) && (r11.Text == r111.Text) && (!r1.Enabled))
            {
                r2.Enabled = false;
                r22.Enabled = false;
                r222.Enabled = false;
                r3.Enabled = false;
                r33.Enabled = false;
                r333.Enabled = false;
                check = true;
            }
            else if ((r2.Text == r22.Text) && (r22.Text == r222.Text) && (!r2.Enabled))
            {
                r1.Enabled = false;
                r11.Enabled = false;
                r111.Enabled = false;
                r3.Enabled = false;
                r33.Enabled = false;
                r333.Enabled = false;

                check = true;
            }
            else if ((r3.Text == r33.Text) && (r33.Text == r333.Text) && (!r3.Enabled))
            {
                r2.Enabled = false;
                r22.Enabled = false;
                r222.Enabled = false;
                r1.Enabled = false;
                r11.Enabled = false;
                r111.Enabled = false;
                check = true;
            }
            else if ((r1.Text == r2.Text) && (r2.Text == r3.Text) && (!r1.Enabled))
            {
                r11.Enabled = false;
                r22.Enabled = false;
                r33.Enabled = false;
                r111.Enabled = false;
                r222.Enabled = false;
                r333.Enabled = false;
                check = true;
            }
            else if ((r111.Text == r222.Text) && (r222.Text == r333.Text) && (!r111.Enabled))
            {
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r11.Enabled = false;
                r22.Enabled = false;
                r33.Enabled = false;
                check = true;
            }
            else if ((r11.Text == r22.Text) && (r22.Text == r33.Text) && (!r11.Enabled))
            {
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r111.Enabled = false;
                r222.Enabled = false;
                r333.Enabled = false;
                check = true;
            }
            else if ((r1.Text == r22.Text) && (r22.Text == r333.Text) && (!r1.Enabled))
            {
                r11.Enabled = false;
                r111.Enabled = false;
                r2.Enabled = false;
                r222.Enabled = false;
                r3.Enabled = false;
                r33.Enabled = false;
                check = true;
            }
            else if ((r111.Text == r22.Text) && (r22.Text == r3.Text) && (!r111.Enabled))
            {
                r1.Enabled = false;
                r11.Enabled = false;
                r2.Enabled = false;
                r222.Enabled = false;
                r33.Enabled = false;
                r333.Enabled = false;
                check = true;
            }
            String wons = "";
            if (check == true)
            {
                t1.Enabled = true;

                if (radio == false)
                {
                    wons = "player 1 Won";
                }
                else if (radio == true)
                {
                    wons = "Player1";
                }
                t1.Text = wons;


            }





        }

        private void s2_Click(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                s2.Enabled = true;
                radio = true;
                b1.Enabled = true;
            }
            else
            {

                radio = false;
                b1.Enabled = true;
                s2.Enabled = true;
            }
            s2.Enabled = false;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            r1.Enabled = true;
            r11.Enabled = true;
            r111.Enabled = true;
            r2.Enabled = true;
            r22.Enabled = true;
            r222.Enabled = true;
            r3.Enabled = true;
            r33.Enabled = true;
            r333.Enabled = true;
            t1.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tiktakto tk = new tiktakto();
            tk.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helpless :)");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tis is tiktak game. Single player easy to play with computer");
        }

        private void bclick(object sender, MouseEventArgs e)
        {

            try
            {
                Button b = (Button)sender;
                Random ran = new Random();
                if (radio == true)
                {
                    b.Text = "T";


                    for (int i = 1; i <= end; i++)
                    {


                        int rr = ran.Next(1, end - 1);

                        if (r1.TabIndex == rr && r1.Text == "")
                        {

                            r1.Text = "F";
                            r1.Enabled = false;

                            break;
                        }
                        else if (r2.TabIndex == rr && r2.Text == "")
                        {
                            r2.Text = "F";
                            r2.Enabled = false;
                            break;
                        }
                        else if (r3.TabIndex == rr && r3.Text == "")
                        {
                            r3.Text = "F";
                            r3.Enabled = false;
                            break;
                        }
                        else if (r11.TabIndex == rr && r11.Text == "")
                        {
                            r11.Text = "F";
                            r11.Enabled = false;
                            break;
                        }
                        else if (r111.TabIndex == rr && r111.Text == "")
                        {
                            r111.Text = "F";
                            r111.Enabled = false;
                            break;
                        }
                        else if (r22.TabIndex == rr && r22.Text == "")
                        {
                            r22.Text = "F";
                            r22.Enabled = false;
                            break;
                        }
                        else if (r222.TabIndex == rr && r222.Text == "")
                        {
                            r222.Text = "F";
                            r222.Enabled = false;
                            break;
                        }
                        else if (r33.TabIndex == rr && r33.Text == "")
                        {
                            r33.Text = "F";
                            r33.Enabled = false;
                            break;
                        }
                        else if (r333.TabIndex == rr && r333.Text == "")
                        {
                            r333.Text = "F";
                            r333.Enabled = false;
                            break;

                        }


                    }
                    b.Enabled = false;
                }

                else if (radio == false)
                {
                    b.Text = "X";


                    for (int i = 1; i <= end; i++)
                    {


                        int rr = ran.Next(1, end - 1);

                        if (r1.TabIndex == rr && r1.Text == "")
                        {

                            r1.Text = "T";
                            r1.Enabled = false;

                            break;
                        }
                        else if (r2.TabIndex == rr && r2.Text == "")
                        {
                            r2.Text = "T";
                            r2.Enabled = false;
                            break;
                        }
                        else if (r3.TabIndex == rr && r3.Text == "")
                        {
                            r3.Text = "T";
                            r3.Enabled = false;
                            break;
                        }
                        else if (r11.TabIndex == rr && r11.Text == "")
                        {
                            r11.Text = "T";
                            r11.Enabled = false;
                            break;
                        }
                        else if (r111.TabIndex == rr && r111.Text == "")
                        {
                            r111.Text = "T";
                            r111.Enabled = false;
                            break;
                        }
                        else if (r22.TabIndex == rr && r22.Text == "")
                        {
                            r22.Text = "T";
                            r22.Enabled = false;
                            break;
                        }
                        else if (r222.TabIndex == rr && r222.Text == "")
                        {
                            r222.Text = "T";
                            r222.Enabled = false;
                            break;
                        }
                        else if (r33.TabIndex == rr && r33.Text == "")
                        {
                            r33.Text = "T";
                            r33.Enabled = false;
                            break;
                        }
                        else if (r333.TabIndex == rr && r333.Text == "")
                        {
                            r333.Text = "T";
                            r333.Enabled = false;
                            break;

                        }


                    }

                }
                b.Enabled = false;
                t1.Enabled = false;
                won();
                count++;
            }
            catch (Exception ex) { }

        }
    }
}
