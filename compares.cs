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
namespace Assignemnts
{
    public partial class compares : Form
    {
        public compares()
        {
            InitializeComponent();
        }
        IEnumerable<FileInfo> groupse;
        IEnumerable<FileInfo> groupsf;
        IEnumerable<FileInfo> filelist;
        IEnumerable<FileInfo> filelists;
        /*IEnumerable<String> filenames;*/

        List<String> filenames = new List<String>();

        List<String> filenamess = new List<String>();
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result;

            using (FolderBrowserDialog objects = new FolderBrowserDialog())
            {
                objects.SelectedPath = "e:";
                result = objects.ShowDialog();

                if (result == DialogResult.OK)
                {

                    t1.Text = objects.SelectedPath;
                    DirectoryInfo dir = new DirectoryInfo(t1.Text);
                    filelist = dir.GetFiles("*.*", SearchOption.AllDirectories);

                    groupse = from filess in filelist select filess;


                    foreach (FileInfo file in groupse)
                    {

                        filenames.Add(file.Name);




                    }
                    foreach (String i in filenames)
                    {
                        l1.Items.Add(i);

                    }



                }


            }




            using (FolderBrowserDialog obj = new FolderBrowserDialog())
            {
                obj.SelectedPath = "e:";
                result = obj.ShowDialog();

                if (result == DialogResult.OK)
                {

                    t2.Text = obj.SelectedPath;
                    DirectoryInfo dir = new DirectoryInfo(t2.Text);
                    filelists = dir.GetFiles("*.*", SearchOption.AllDirectories);
                    groupsf = from filess in filelists select filess;
                    foreach (FileInfo fil in groupsf)
                    {
                        filenamess.Add(fil.Name);

                    }
                    foreach (String i in filenamess)
                    {
                        l1.Items.Add(i);
                    }

                }

            }



        }

        private void comp_Click(object sender, EventArgs e)
        {
            var li1 = filenames.Intersect(filenamess).ToList();

            if (li1.Count > 0)
            {
                foreach (String i in li1)
                {

                    l2.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("NO FILE");
            }

        }

        private void compares_Load(object sender, EventArgs e)
        {

        }
    }
}
