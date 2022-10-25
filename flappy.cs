using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace mycal
{
    public partial class flappy : Form
    {
        public flappy()
        {
            InitializeComponent();
        }
        int speed = 8;
        int pspeed = 10;
        int score = 0;
        private void flappy_Load(object sender, EventArgs e)
        {

        }

        private void pi1_Click(object sender, EventArgs e)
        {
          
        }

        private void times_Tick(object sender, EventArgs e)
        {
            b1.Top += speed;
            pi2.Left -= pspeed;
            pi1.Left -= pspeed;
          
            if (pi1.Left < -50) {

                pi1.Left = 650;
                score++;
            }
            if (pi2.Left < -55) {

                pi2.Left = 450;
                score++;
            }
            if (pi1.Left < -50 && pi2.Left < -50) {

                pi2.Left = 650;
                pi1.Left = 650;
                score++;

            }
            if (b1.Bounds.IntersectsWith(pi1.Bounds) || b1.Bounds.IntersectsWith(pi2.Bounds)) {
                String sc = "";
                times.Stop();
                sc = score.ToString();
                MessageBox.Show("Your score card is "+sc);
            
            }

        }
       
      

        private void getdown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }



       



       

        private void flappy_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.S)
            {

                speed = 8;

            }

        }

        private void flappy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.S)
            {

                speed = -8;
            }
        }

        private void pi2_Click(object sender, EventArgs e)
        {

        }
    }
}
