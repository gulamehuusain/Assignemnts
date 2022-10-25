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
    public partial class BCE : Form
    {
        public BCE()
        {
            InitializeComponent();
        }
        int b, f, l, i;
        private void base1_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(base1.Text);
        }

        private void limit1_TextChanged(object sender, EventArgs e)
        {
            l = Convert.ToInt16(limit1.Text);
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            f = Convert.ToInt16(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (i = b; i < l; i = i * f)
            {

                lb1.Items.Add(i);


            }

        }
    }
    }

