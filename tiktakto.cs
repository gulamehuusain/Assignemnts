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
    public partial class tiktakto : Form
    {
        public tiktakto()
        {
            InitializeComponent();
        }

        private void tiktakto_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            this.Hide();
            singleplayer sg = new singleplayer();
            sg.Show();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            tiktakto tk = new tiktakto();

            multiplayer ml = new multiplayer();
            ml.Show();
            this.Hide();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
