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
using ZXing;
using ZXing.QrCode;

namespace DUAN1
{
    public partial class QuetQR : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public QuetQR()
        {
            InitializeComponent();
        }

        private void btnStarQuetQr_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbChonCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
        }

        private void QuetQR_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbbChonCamera.Items.Add(filterInfo.Name);
            }cbbChonCamera
            .SelectedIndex = 0;
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (ptbCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ptbCamera.Image);
                if (result != null)
                {
                    tbShowQR.Text = result.ToString();
                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                    }
                }
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QuetQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void btnTaoQR_Click(object sender, EventArgs e)
        {
            var options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 300,
                Height = 300,
            };
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            barcodeWriter.Options = options;
            if (!string.IsNullOrEmpty(tbTaoQR.Text))
            {
                Bitmap result = barcodeWriter.Write(tbTaoQR.Text);
                ptbQR.Image = result;
            }
        }

        private void btnLuuQR_Click(object sender, EventArgs e)
        {
            if (ptbQR.Image != null)
            {
                Bitmap myBitmap = (Bitmap)ptbQR.Image;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = ptbQR.Text + ".jpg";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    myBitmap.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void btnThoatQR_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
            this.Hide();
            QuanLyHoaDon ql = new QuanLyHoaDon("nhanvien");
            ql.ShowDialog();
            this.Close();
        }
    }
}
