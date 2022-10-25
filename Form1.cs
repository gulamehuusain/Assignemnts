using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace Assignemnts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xl = new XmlDocument();

                xl.Load("F:\\Assignemnts\\Assignemnts\\XMLFile3.xml");

                foreach (XmlNode node in xl.DocumentElement)
                {

                    String type = node.Attributes[0].InnerText;

                    if (type == t1.Text)
                    {
                        foreach (XmlNode chnode in node.ChildNodes)
                        {
                            l1.Items.Add(chnode.InnerText);


                        }

                    }

                }

            }
            catch (Exception ex) {

                MessageBox.Show("DATA" + ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("F:\\Assignemnts\\Assignemnts\\XMLFile3.xml");
            d1.DataSource = ds.Tables[0];

            dataGridView1.DataSource = ds.Tables[1];
            DialogResult result;
            /* using ( OpenFileDialog obj= new OpenFileDialog())
             {
                 obj.InitialDirectory = "e:";
                 result = obj.ShowDialog();

                 if (result == DialogResult.OK)
                 {
                     *//* DataSet ds = new DataSet();
                      ds.ReadXml(obj.FileName);
                      d1.DataSource = ds.Tables[0];
                      dataGridView1.DataSource = ds.Tables[1];*//*

                     var filename = obj.FileName;
                     var currentDirectory = Directory.GetCurrentDirectory();
                     var purchaseOrderFilepath = Path.Combine(currentDirectory, filename);
                     //MessageBox.Show(purchaseOrderFilepath);
                     XElement purchaseOrder = XElement.Load(purchaseOrderFilepath);

                     IEnumerable<string> partNos = from item in purchaseOrder.Descendants("Item")
                                                   select (string)item.Attribute("PartNumber");

                     IEnumerable<string> products = from item in purchaseOrder.Descendants("Item")
                                                    select (string)item.Value;

                     foreach (string pn in partNos)
                     {
                         l1.Items.Add(pn);
                     }
                     foreach (string pts in products)
                     {
                         MessageBox.Show(pts);
                     }


 */

        
                }
            
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            using (OpenFileDialog of = new OpenFileDialog()) { 
            of.InitialDirectory ="e:";
            result=of.ShowDialog();
                if (result == DialogResult.OK) {

                    XDocument doc = XDocument.Load(of.FileName);
                    XElement product = new XElement("Address", new XAttribute("Type", "bill"),
                   new XElement("Name", "rafy"),
                   new XElement("Street", "Adyala"),
                    new XElement("City", "RAWALindi"),
                     new XElement("State","PAk"),
                      new XElement("Zip", "NUML"),
                       new XElement("Country","PAK"));

                    doc.Root.Add(product);
                    doc.Save(of.FileName);
                    DataSet ds = new DataSet();
                    ds.ReadXml(of.FileName);
                    d1.DataSource = ds.Tables[0];
                    dataGridView1.DataSource = ds.Tables[1];

                }
            
            
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;
            using (OpenFileDialog op = new OpenFileDialog()) {
                op.InitialDirectory = "f:";            
                result = op.ShowDialog();
                if (result == DialogResult.OK) {
                    XDocument doc = XDocument.Load(op.FileName);
                    XElement deleted = doc.Element("Order").Element("Address");
                       
                    if (deleted != null) {

                        deleted.Remove();
                        doc.Save(op.FileName);
                    }
                   
                    DataSet ds = new DataSet();
                    ds.ReadXml(op.FileName);
                    d1.DataSource = ds.Tables[0];
                    dataGridView1.DataSource = ds.Tables[1];
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            
            
            
            
            
            
            }



        }

    }

