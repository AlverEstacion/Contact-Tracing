using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Contact Trace was made by Jose Alver H. Estacion", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter file = new StreamWriter(@"C:\Users\Alver\OneDrive\Documents\Contact Tracing\test.text");
            file.WriteLine("Firstname: " + Tbox1.Text);
            file.WriteLine("Middlename: " + Tbox2.Text);
            file.Close();
        }
    }
}
