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
            userc1.Hide();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter file = new StreamWriter(@"C:\Users\Alver\source\repos\Contact-Tracing\Infos\" + tboxLastname.Text + ", " + tboxFirstname.Text + ".txt", true);
            file.WriteLine("First name: " + tboxFirstname.Text);
            file.WriteLine("Middle name: " + tboxmiddlename.Text);
            file.WriteLine("Last name: " + tboxLastname.Text);
            file.WriteLine("Suffix: " + tboxSuffix.Text);
            file.WriteLine("Birth date: " + tboxBirthDate.Text);
            file.WriteLine("Mobile No.: " + tboxMobileNo.Text);
            file.WriteLine("Email: " + tboxEmail.Text);
            file.WriteLine("Region: " + tboxst.Text);
            file.WriteLine("City: " + tboxStname.Text);
            file.WriteLine("Barangay: " + tboxcity.Text);
            file.WriteLine("Date: " + Date.Text);
            file.Close();
            MessageBox.Show("Thankyou for your response", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tboxFirstname.Text = "First name";
            tboxFirstname.ForeColor = Color.Silver;
            tboxmiddlename.Text = "Middle name";
            tboxmiddlename.ForeColor = Color.Silver;
            tboxLastname.Text = "Last name";
            tboxLastname.ForeColor = Color.Silver;
            tboxSuffix.Text = "Suffix(e.g. Sr., Jr., III)";
            tboxSuffix.ForeColor = Color.Silver;
            tboxBirthDate.Text = "MM/dd/yyyy";
            tboxBirthDate.ForeColor = Color.Silver;
            tboxMobileNo.Text = "Mobile No.";
            tboxMobileNo.ForeColor = Color.Silver;
            tboxEmail.Text = "Email";
            tboxEmail.ForeColor = Color.Silver;
            tboxst.Text = "Street No.";
            tboxst.ForeColor = Color.Silver;
            tboxStname.Text = "Street/Town name";
            tboxStname.ForeColor = Color.Silver;
            tboxcity.Text = "City/Provinces";
            tboxcity.ForeColor = Color.Silver;
        }
        private void tboxFirstname_Enter(object sender, EventArgs e)
        {
            if (tboxFirstname.Text == "First name")
            {
                tboxFirstname.Text = "";
                tboxFirstname.ForeColor = Color.Black;
            }
        }

        private void tboxFirstname_Leave(object sender, EventArgs e)
        {
            if (tboxFirstname.Text == "")
            {
                tboxFirstname.Text = "First name";
                tboxFirstname.ForeColor = Color.Silver;
            }
        }

        private void tboxmiddlename_Enter(object sender, EventArgs e)
        {
            if (tboxmiddlename.Text == "Middle name")
            {
                tboxmiddlename.Text = "";
                tboxmiddlename.ForeColor = Color.Black;
            }
        }

        private void tboxmiddlename_Leave(object sender, EventArgs e)
        {
            if (tboxmiddlename.Text == "")
            {
                tboxmiddlename.Text = "Middle name";
                tboxmiddlename.ForeColor = Color.Silver;
            }
        }

        private void tboxLastname_Enter(object sender, EventArgs e)
        {
            if (tboxLastname.Text == "Last name")
            {
                tboxLastname.Text = "";
                tboxLastname.ForeColor = Color.Black;
            }
        }

        private void tboxLastname_Leave(object sender, EventArgs e)
        {
            if (tboxLastname.Text == "")
            {
                tboxLastname.Text = "Last name";
                tboxLastname.ForeColor = Color.Silver;
            }
        }

        private void tboxSuffix_Enter(object sender, EventArgs e)
        {
            if (tboxSuffix.Text == "Suffix(e.g. Sr., Jr., III)")
            {
                tboxSuffix.Text = "";
                tboxSuffix.ForeColor = Color.Black;
            }
        }

        private void tboxSuffix_Leave(object sender, EventArgs e)
        {
            if (tboxSuffix.Text == "")
            {
                tboxSuffix.Text = "Suffix(e.g. Sr., Jr., III)";
                tboxSuffix.ForeColor = Color.Silver;
            }
        }

        private void tboxBirthDate_Enter(object sender, EventArgs e)
        {
            if (tboxBirthDate.Text == "MM/dd/yyy")
            {
                tboxBirthDate.Text = "";
                tboxBirthDate.ForeColor = Color.Black;
            }
        }

        private void tboxBirthDate_Leave(object sender, EventArgs e)
        {
            if (tboxBirthDate.Text == "")
            {
                tboxBirthDate.Text = "MM/dd/yyyy";
                tboxBirthDate.ForeColor = Color.Silver;
            }
        }
        private void tboxMobileNo_Enter(object sender, EventArgs e)
        {
            if (tboxMobileNo.Text == "Mobile No.")
            {
                tboxMobileNo.Text = "";
                tboxMobileNo.ForeColor = Color.Black;
            }
        }
        private void tboxMobileNo_Leave(object sender, EventArgs e)
        {
            if (tboxMobileNo.Text == "")
            {
                tboxMobileNo.Text = "Mobile No.";
                tboxMobileNo.ForeColor = Color.Silver;
            }
        }

        private void tboxEmail_Enter(object sender, EventArgs e)
        {
            if (tboxEmail.Text == "Email")
            {
                tboxEmail.Text = "";
                tboxEmail.ForeColor = Color.Black;
            }
        }

        private void tboxEmail_Leave(object sender, EventArgs e)
        {
            if (tboxEmail.Text == "")
            {
                tboxEmail.Text = "Email";
                tboxEmail.ForeColor = Color.Silver;
            }

        }

        private void tboxst_Enter(object sender, EventArgs e)
        {
            if (tboxst.Text == "Street No.")
            {
                tboxst.Text = "";
                tboxst.ForeColor = Color.Black;
            }
        }

        private void tboxst_Leave(object sender, EventArgs e)
        {
            if (tboxst.Text == "")
            {
                tboxst.Text = "Street No.";
                tboxst.ForeColor = Color.Silver;
            }
        }

        private void tboxStname_Enter(object sender, EventArgs e)
        {
            if (tboxStname.Text == "Street/Town name")
            {
                tboxStname.Text = "";
                tboxStname.ForeColor = Color.Black;
            }
        }

        private void tboxStname_Leave(object sender, EventArgs e)
        {
            if (tboxStname.Text == "")
            {
                tboxStname.Text = "Street/Town name";
                tboxStname.ForeColor = Color.Silver;
            }
        }

        private void tboxcity_Enter(object sender, EventArgs e)
        {
            if (tboxcity.Text == "City/Provinces")
            {
                tboxcity.Text = "";
                tboxcity.ForeColor = Color.Black;
            }
        }

        private void tboxcity_Leave(object sender, EventArgs e)
        {
            if (tboxcity.Text == "")
            {
                tboxcity.Text = "City/Provinces";
                tboxcity.ForeColor = Color.Silver;
            }
        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            Form5 show = new Form5();
            show.ShowDialog();
        }

        private void agetbox_Enter(object sender, EventArgs e)
        {
            if (agetbox.Text == "Age")
            {
                agetbox.Text = "";
                agetbox.ForeColor = Color.Black;
            }
        }

        private void agetbox_Leave(object sender, EventArgs e)
        {
            if (agetbox.Text == "")
            {
                agetbox.Text = "Age";
                agetbox.ForeColor= Color.Silver;
            }
        }

        private void ScannerBTN_Click(object sender, EventArgs e)
        {
            userc1.Show();
            userc1.BringToFront();
        }
    }
}