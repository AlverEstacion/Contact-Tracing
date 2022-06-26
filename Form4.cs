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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var dateFiles = Directory.GetFiles(@"C:\Users\Alver\source\repos\Contact-Tracing\Infos\Dates");
            foreach (string file in dateFiles)
            {
                string dates = File.ReadAllText(file);
                label1.Text = label1.Text + dates + "\n";
            }
        }
    }
}
