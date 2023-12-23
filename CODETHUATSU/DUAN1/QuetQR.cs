using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.Drawing.Printing;

namespace DUAN1
{
    public partial class QuetQR : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private bool hasResult = false;
        public QuetQR()
        {
            InitializeComponent();
        }
        private void QuetQR_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptbCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ptbCamera.Image);
                if (result != null)
                {
                    ChiTietHoaDon.MaCTHH = int.Parse(result.Text);
                    hasResult = true;
                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                    }
                    this.Hide();
                }
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QuetQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!hasResult)
            {
                ChiTietHoaDon.MaCTHH = 0;
            }
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

    }
}
