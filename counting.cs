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
    public partial class counting : Form
    {
        public counting()
        {
            InitializeComponent();
        }
        String [] ss;
        private void b1_Click(object sender, EventArgs e)
        {
            String[] dt = t1.Text.Split();
            IEnumerable<String> dataa = from dts in dt where dts.Length.Equals(3) select dts;

            foreach (String s in dataa) {

               
                l1.Items.Add(s);
            }
           
        }

        private void counting_Load(object sender, EventArgs e)
        {

        }
    }
}
