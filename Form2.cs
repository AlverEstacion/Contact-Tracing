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

namespace Contact_Tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ShwallBtn_Click(object sender, EventArgs e)
        {
            Form3 alldata = new Form3();
            alldata.ShowDialog();
        }

        private void datebtn_Click(object sender, EventArgs e)
        {
            List<string> byDate = new List<string>();
            string Date = frm2Date.Text;
            int results = 0;
            var textfiles = Directory.EnumerateFiles(@"C:\Users\Alver\source\repos\Contact-Tracing\Infos");
            foreach (string file in textfiles)
            {
                string allcontents = File.ReadAllText(file);
                if (allcontents.Contains(Date))
                {
                    byDate.Add(allcontents);
                    results++;
                    continue;
                }
            }
            if (results == 0)
            {
                MessageBox.Show("No records found");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\Alver\source\repos\Contact-Tracing\Infos\Dates\RecordsbyDate.txt");
                foreach (string contents in byDate)
                {
                    file.WriteLine(contents);
                }
                file.Close();
                MessageBox.Show("Found " + results + "records on selected date");
                if (MessageBox.Show("Show the records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Form4 date = new Form4();
                    date.ShowDialog();
                }   
            }
        }
    }
}
