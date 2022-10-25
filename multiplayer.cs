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
    public partial class multiplayer : Form
    {
        public multiplayer()
        {
            InitializeComponent();
        }
        bool val;
        bool vals;
        int countclick = 0;
        private void bclick(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (val == true)
                {
                    b.Text = "T";

                }


                else if (val == false)
                {
                    b.Text = "F";
                }



                val = !val;
                vals = !vals;
                t1.Enabled = false;

                b.Enabled = false;
                countclick++;
                win();
            }
            catch { }

        }
        private void win()
        {
            t1.Enabled = false;
            bool winner = false;
            bool draw = false;
            if ((r1.Text == r11.Text) && (r11.Text == r111.Text) && (!r1.Enabled))
            {
                r2.Enabled = false;
                r22.Enabled = false;
                r222.Enabled = false;
                r3.Enabled = false;
                r33.Enabled = false;
                r333.Enabled = false;
                winner = true;
            }
            else if ((r2.Text == r22.Text) && (r22.Text == r222.Text) && (!r2.Enabled))
            {
                r1.Enabled = false;
                r11.Enabled = false;
                r111.Enabled = false;
                r3.Enabled = false;
                r33.Enabled = false;
                r333.Enabled = false;

                winner = true;
            }
            else if ((r3.Text == r33.Text) && (r33.Text == r333.Text) && (!r3.Enabled))
            {
                r2.Enabled = false;
                r22.Enabled = false;
                r222.Enabled = false;
                r1.Enabled = false;
                r11.Enabled = false;
                r111.Enabled = false;
                winner = true;
            }
            else if ((r1.Text == r2.Text) && (r2.Text == r3.Text) && (!r1.Enabled))
            {
                r11.Enabled = false;
                r22.Enabled = false;
                r33.Enabled = false;
                r111.Enabled = false;
                r222.Enabled = false;
                r333.Enabled = false;
                winner = true;
            }
            else if ((r111.Text == r222.Text) && (r222.Text == r333.Text) && (!r111.Enabled))
            {
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r11.Enabled = false;
                r22.Enabled = false;
                r33.Enabled = false;
                winner = true;
            }
            else if ((r11.Text == r22.Text) && (r22.Text == r33.Text) && (!r11.Enabled))
            {
                r1.Enabled = false;
                r2.Enabled = false;
                r3.Enabled = false;
                r111.Enabled = false;
                r222.Enabled = false;
                r333.Enabled = false;
                winner = true;
            }
            else if ((r1.Text == r22.Text) && (r22.Text == r333.Text) && (!r1.Enabled))
            {
                r11.Enabled = false;
                r111.Enabled = false;
                r2.Enabled = false;
                r222.Enabled = false;
                r3.Enabled = false;
                r33.Enabled = false;
                winner = true;
            }
            else if ((r111.Text == r22.Text) && (r22.Text == r3.Text) && (!r111.Enabled))
            {
                r1.Enabled = false;
                r11.Enabled = false;
                r2.Enabled = false;
                r222.Enabled = false;
                r33.Enabled = false;
                r333.Enabled = false;
                winner = true;
            }
            else if (countclick == 9)
            {

                draw = true;

            }


            String won = "";
            if (winner == true)
            {


                t1.Enabled = false;
                if (val == false)
                {
                    won = "Player 1";

                }



                else if (val == true)
                {
                    won = "Player1";
                }

                t1.Text = won + "Hurrah";
            }
            else if (draw == true)
            {
                t1.Enabled = false;
                won = "DRAW THIS MATCH";
                t1.Text = won;
            }


        }

        private void s2_Click(object sender, EventArgs e)
        {
            t1.Enabled = false;
            if (rd1.Checked)
            {
                val = true;

                b1.Enabled = true;

            }
            else if (rd2.Checked)
            {

                val = false;

                b1.Enabled = true;
            }
            s2.Enabled = false;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
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
    }
    }
