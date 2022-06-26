using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Sbmtbtn_Click(object sender, EventArgs e)
        {
            if (Usertbox.Text == "Alver Estacion" && Passtbox.Text == "alver123")
            {
                Usertbox.Text = "";
                Passtbox.Text = "";
                Form2 records = new Form2();
                this.Visible = false;
                records.ShowDialog();           
            }
            else
            {
                MessageBox.Show("Wrong Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Usertbox.Text = "";
                Passtbox.Text = "";
            }
        }
    }
}
