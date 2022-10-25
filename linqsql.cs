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
    public partial class linqsql : Form
    {
        public linqsql()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db=new DataClasses1DataContext();
        private void linqsql_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var st = new stdinfo
            {
                Name= textBox1.Text,
                Roll_no = textBox2.Text,
                Class = textBox3.Text,
                number = textBox4.Text,
            };
            db.stdinfos.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("INSERTED");
            
          

        }
         void load() {
            var totals = from s in db.stdinfos select s;
             dataGridView1.DataSource = totals;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           var  st = (from s in db.stdinfos where s.Roll_no == (textBox2.Text) select s).First();
            db.stdinfos.DeleteOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("delted");
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var st = (from s in db.stdinfos where s.Roll_no == (textBox2.Text) select s).First();
            st.Name = textBox1.Text;
            st.Class = textBox3.Text;
            st.number = textBox4.Text;
            db.SubmitChanges();
            MessageBox.Show("Updated");
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var st=(from s in db.stdinfos where s.Roll_no == (textBox2.Text) select s).First();
            textBox1.Text = st.Name.ToString();
            db.SubmitChanges();
            MessageBox.Show("SELECT");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var st = (from s in db.stdinfos select s);
            dataGridView1.DataSource = st;

        }

        private void insert_Paint(object sender, PaintEventArgs e)
        {

        }
    }  }
    

