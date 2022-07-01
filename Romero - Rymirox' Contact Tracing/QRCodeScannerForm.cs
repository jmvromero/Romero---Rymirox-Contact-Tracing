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
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using ZXing.QrCode;
namespace Romero___Rymirox__Contact_Tracing
{
    public partial class QRCodeScannerForm : Form
    {
        public QRCodeScannerForm()
        {
            InitializeComponent();
        }

        private FilterInfoCollection filter;
        private VideoCaptureDevice captureDevice;

        private void QRCodeScannerForm_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
                comboBox1.Items.Add(filterInfo.Name);
            comboBox1.SelectedIndex = 0;
        }

        private void startbuttonQRCSF1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[comboBox1.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
           
           
           
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxQRCSF1.Image = (Bitmap)eventArgs.Frame.Clone();   
        }

        private void QRCodeScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            //if(captureDevice.IsRunning)
                //captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxQRCSF1 != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result1 = barcode.Decode((Bitmap)pictureBoxQRCSF1.Image);
                if(result1 != null)
                {
                    
                    timer1.Stop();
                    textBox1.Text = result1.ToString();
                    //if (captureDevice.IsRunning)
                    //    captureDevice.Stop();

                }

            }
            
        }

        private void readbuttonQRCSF2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartingScreenForm startingScreenForm = new StartingScreenForm();   
            startingScreenForm.ShowDialog();
        }
    }
}
