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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var data = Directory.GetFiles(@"C:\Users\Alver\source\repos\Contact-Tracing\Infos");
            foreach (var file in data)
            {
                string allcontent = File.ReadAllText(file);
                label1.Text = label1.Text + "\n" + allcontent + "\n";
            }
        }
    }
}
