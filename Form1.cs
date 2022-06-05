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
            System.IO.StreamWriter file = new StreamWriter(@"C:\Users\Alver\OneDrive\Documents\Contact Tracing\" + tboxLastname.Text + ".text", true);
            file.WriteLine("First name: " + tboxFirstname.Text);
            file.WriteLine("Middle name: " + tboxSecondname.Text);
            file.WriteLine("Last name: " + tboxLastname.Text);
            file.WriteLine("Suffix: " + tboxSuffix.Text);
            file.WriteLine("Birth date: " + tboxBirthDate.Text);
            file.WriteLine("Mobile No.: " + tboxMobileNo.Text);
            file.WriteLine("Email: " + tboxEmail.Text);
            file.WriteLine("Region: " + tboxRegion.Text);
            file.WriteLine("City: " + tboxCity.Text);
            file.WriteLine("Barangay: " + tboxBarangay.Text);
            file.WriteLine("Full Address: " + tboxFulladd.Text);
            file.Close();
            MessageBox.Show("Thankyou for your response", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tboxFirstname.Text = "";
            tboxSecondname.Text = "";
            tboxLastname.Text = "";
            tboxSuffix.Text = "";
            tboxBirthDate.Text = "";
            tboxMobileNo.Text = "";
            tboxEmail.Text = "";
            tboxRegion.Text = "";
            tboxCity.Text = "";
            tboxBarangay.Text = "";
            tboxFulladd.Text = "";
        }
    }
}
