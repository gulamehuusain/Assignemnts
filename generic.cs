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
    public partial class generic : Form
    {
        public generic()
        {
            InitializeComponent();
        }

        int a = 10;
        int b = 5;
        int swap;
        private void button1_Click(object sender, EventArgs e)
        {
            void Displayss<T>(T a, T b, T swap)
            {


                swap = a;
                a = b;
                b = swap;



                MessageBox.Show("result" + a + b);
            }
            Displayss(a, b, swap);




        }

        private void generic_Load(object sender, EventArgs e)
        {

        }
    }
}
