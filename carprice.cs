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
    public partial class carprice : Form
    {
        public carprice()
        {
            InitializeComponent();
        }
        double ans, ans1;

        double a, b;

        int c, d;

        private void button1_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt16(t1.Text);
            d = Convert.ToInt16(t2.Text);
            a = Convert.ToInt16(n3.Value);

            ans1 = (c * d) * a / 100;
            n3.Text = ans1.ToString();

        }



        private void carprice_Load(object sender, EventArgs e)
        {

        }
    }
}
