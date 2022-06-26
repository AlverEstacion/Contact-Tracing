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
            var alldata = Directory.GetFiles(@"C:\Users\Alver\source\repos\Contact-Tracing\Infos");
            foreach (var file in alldata)
            {
                string allcontents = File.ReadAllText(file);
                alldataLbl.Text = alldataLbl.Text + "\n" + allcontents + "\n";
;            }
        }
    }
}
