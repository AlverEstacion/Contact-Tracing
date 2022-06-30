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
using AForge;
using ZXing;
using ZXing.Aztec;
using System.IO;

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
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
                Devices.Items.Add(filterInfo.Name);
            Devices.SelectedIndex = 0;
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[Devices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Scanner.Image = (Bitmap)eventArgs.Frame.Clone();        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Scanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)Scanner.Image);
                if (result != null)
                {
                    timer1.Stop();                  
                    MessageBox.Show("Thank you for your response");
                    string infos = result.ToString();
                    StringBuilder builder = new StringBuilder(infos);
                    infos = builder.ToString();
                    string Showinfo = infos;
                    MessageBox.Show(Showinfo);
                    StreamWriter file = new StreamWriter(@"C:\Users\Alver\source\repos\Contact-Tracing\Infos\QrCodeSubmit.Txt");
                    file.WriteLine(Showinfo);
                    file.Close();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }

            }
        }
    }
}
