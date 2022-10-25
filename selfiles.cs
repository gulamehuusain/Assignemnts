using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mycal
{
    public partial class selfiles : Form
    {
        public selfiles()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        String filepath;
        private void b1_Click(object sender, EventArgs e)
        {
            
            DialogResult result;
            using (OpenFileDialog obj = new OpenFileDialog())
            {

                obj.InitialDirectory = "e:";
                obj.Filter = "txt files|*.txt  |All files  |*.txt;*.pdf;*.*";
            
                result = obj.ShowDialog();
                filepath=obj.FileName;
               

            }
            if (result == DialogResult.OK)
            {
                t1.Text = filepath;
                b2.Enabled = true;
                if (filepath.Equals("*.jpg"))
                {
                    p1.Enabled = true;
                    p1.Load(filepath);
                }
                else {
                    p1.Enabled = false;
                
                }
            }

        }

        private void b3_Click(object sender, EventArgs e)
        {
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
