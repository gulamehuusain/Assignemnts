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
    public partial class movingbutton : Form
    {
        public movingbutton()
        {
            InitializeComponent();
        }
        int i;
        private void close1_Click(object sender, EventArgs e)
        {
            {
                if (i < 10)
                {

                    close1.Location = new Point(width(), heigth());
                    i++;
                }
            }
            
        }
        private int width()
        {
            int ran;
            int max = this.Width;
            Random r = new Random();
            ran = r.Next(0, max);
            return ran;

        }
        private int heigth()
        {
            //int height = this.Height;

            // return height;
            return 0;
        }
    }
}
