﻿using System;
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
using System.Globalization;
using System.Drawing.Printing;

namespace DUAN1
{
    public partial class QuetQR : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        List<hang_hoa> dsHang = new List<hang_hoa>();
        public QuetQR(string userName)
        {
            InitializeComponent();
            tbusername.Text = userName;
        }

        private void btnStarQuetQr_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbChonCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            tbShowQR.Text = "";
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptbCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ptbCamera.Image);
                if (result != null )
                {
                    tbShowQR.Text = result.ToString();
                    using (DUAN1Entities HangHoa_ = new DUAN1Entities())
                    {
                        hang_hoa hh = new hang_hoa();
                        if (String.IsNullOrWhiteSpace(tbShowQR.Text))
                        {
                            MessageBox.Show("Vui lòng thêm hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        hh.ma_hang_hoa = result.ToString();
                        dataGridView1.Rows.Clear();
                        dsHang.Add(hh);
                        foreach (var item in dsHang)
                        {
                            using (DUAN1Entities du = new DUAN1Entities())
                            {
                                var hang = du.hang_hoa.Where(a => a.ma_hang_hoa.Equals(item.ma_hang_hoa));

                                foreach (var ytem in hang)
                                {
                                    dataGridView1.Rows.Add(
                                        ytem.ma_hang_hoa,
                                        ytem.ten
                                        );
                                }
                            }
                        } 
                    }
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

        
        private void btnThemHang_Click(object sender, EventArgs e)
        {
            //using (DUAN1Entities HangHoa_ = new DUAN1Entities())
            //{
            //    hang_hoa hh = new hang_hoa();
            //    if(String.IsNullOrWhiteSpace(tbShowQR.Text))
            //    {
            //        MessageBox.Show("Vui lòng thêm hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    hh.ma_hang_hoa = tbShowQR.Text;
            //    dsHang.Add(hh);
            //    tbShowQR.Text = "";
            //}
            //var confirmResult = MessageBox.Show(
            //   "Đã thêm, bạn có muốn tiếp tục quét QR ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (confirmResult == DialogResult.Yes)
            //{
            //    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbbChonCamera.SelectedIndex].MonikerString);
            //    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //    videoCaptureDevice.Start();
            //    timer1.Start();
            //}
            //else
            //{
            //    if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            //    {
            //        videoCaptureDevice.Stop();
            //    }
            //    MessageBox.Show("Vui lòng thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        //Print HoaDon
        private readonly PrintDocument docToPrint = new PrintDocument();
        readonly int y = 0;
        readonly int height = 300;
        readonly int width = 220;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
            int ds = dsHang.Count;
            if (ds > 0)
            {
                PrintDialog PrintDialog1 = new PrintDialog();
                docToPrint.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", width, height);
                PrintDialog1.AllowSomePages = true;
                PrintDialog1.ShowHelp = true;
                PrintDialog1.Document = docToPrint;

                DialogResult result = PrintDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    docToPrint.PrintPage += new PrintPageEventHandler(document_PrintPage);
                    docToPrint.Print();
                }
            }
            else
            {
                MessageBox.Show("Lỗi không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            string title = "HÓA ĐƠN BÁN HÀNG\nShopQuanAoCodeThuatSu\nĐịa chỉ: Cần Thơ\n\nTên hàng   Giá   Số lượng";
            StringFormat stringFormat = new StringFormat(StringFormatFlags.NoClip);
            Rectangle rectangle = new Rectangle(new Point(height, y), new Size(width, height));
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
            Font printFont = new Font("Arial", 11, FontStyle.Bold);
            e.Graphics.DrawString(title, printFont, Brushes.Black, rectangle, stringFormat);

            using (DUAN1Entities entities = new DUAN1Entities())
            {
                string TenHang = "";
                double Gia = 0;
                int SL = 1;
                int cao = 50;
                double TongTien = 0;
                double ThanhTien = 0;
                foreach(var ds in dsHang)
                {
                    var cthd = entities.hang_hoa.Where(a => a.ma_hang_hoa.Equals(ds.ma_hang_hoa));
                    foreach (var item in cthd)
                    {
                        StringFormat stringFormatBody = new StringFormat(StringFormatFlags.NoClip);
                        Rectangle rectangleBody = new Rectangle(new Point(height, y + cao), new Size(width, height));
                        stringFormatBody.LineAlignment = StringAlignment.Center;
                        stringFormatBody.Alignment = StringAlignment.Center;
                        Font printFontBody = new Font("Arial", 10, FontStyle.Regular);
                        TenHang = item.ten;
                        Gia = (double)item.gia_ban;
                        TongTien = (double)item.gia_ban * SL;
                        ThanhTien += TongTien;
                        e.Graphics.DrawString(TenHang + "     " + Gia.ToString("#,##0") + "     " + SL, printFontBody, Brushes.Black, rectangleBody, stringFormatBody);
                        cao += 20;
                    }
                }
                StringFormat stringFormatFooter = new StringFormat(StringFormatFlags.NoClip);
                Rectangle rectangleFooter = new Rectangle(new Point(height, y + cao + 30), new Size(width, height));
                stringFormatFooter.LineAlignment = StringAlignment.Center;
                stringFormatFooter.Alignment = StringAlignment.Center;
                Font printFontFooter = new Font("Arial", 10, FontStyle.Bold);

                e.Graphics.DrawString("----------\nThành tiền: " + ThanhTien.ToString("#,##0"), printFontFooter, Brushes.Black, rectangleFooter, stringFormatFooter);
            }
        }
    }
}
