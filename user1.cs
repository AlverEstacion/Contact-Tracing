using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Contact_Tracing
{
    public partial class user1 : UserControl
    {
        public user1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        private void user1_Load(object sender, EventArgs e)
        {

        }
    }
}
