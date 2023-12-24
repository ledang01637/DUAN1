using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Printing;

namespace DUAN1
{
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
            //tbusername.Text = username;
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dtpngaylap.Format = DateTimePickerFormat.Short;
            dtpngaylap.CustomFormat = "dd/MM/yyyy";

            using (DAXuongEntities db = new DAXuongEntities())
            {

                //mã khách hàng
                cbbmakhachhang.Items.Clear();
                db.khach_hang.ToList().ForEach(row => cbbmakhachhang.Items.Add(row.ten_kh));
                //mã nhân viên
                cbbmanv.Items.Clear();
                db.nhan_vien.ToList().ForEach(row => cbbmanv.Items.Add(row.ten_nv));

                dataGridView1.Rows.Clear();

                db.hoa_don.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.khach_hang.ten_kh,
                    hd.nhan_vien.ten_nv,
                    DateTime.Parse(hd.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.trang_thai,
                    hd.tongtien

                    );
                }
                );

                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                btnhuy.Enabled = false;
                btnluu.Enabled = false;

                tbmahoadon.ReadOnly = true;
                cbbmakhachhang.Enabled = false;
                cbbmanv.Enabled = false;
                dtpngaylap.Enabled = false;
                tbtongtien.ReadOnly = true;
            }
        }

        // Cập nhật  DGV
        private void UpdateDGV()
        {
            dataGridView1.Rows.Clear();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                dataGridView1.Rows.Clear();

                db.hoa_don.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.khach_hang.ten_kh,
                    hd.nhan_vien.ten_nv,
                    DateTime.Parse(hd.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.trang_thai,
                    hd.tongtien
                    );
                }
                );
            }


        }

        // DataGridView lấy thông tin khi click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];
            String MaHD = rowData.Cells[0].Value.ToString();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                hoa_don hd = db.hoa_don.Where(x => x.ma_hd == MaHD).FirstOrDefault();

                tbmahoadon.Text = hd.ma_hd;
                cbbmakhachhang.Text = hd.khach_hang.ten_kh;
                cbbmanv.Text = hd.nhan_vien.ten_nv;
                dtpngaylap.Text = hd.ngay_lap.ToString();
                tbtrangthai.Text = hd.trang_thai;
                tbtongtien.Text = hd.tongtien.ToString();

            }

            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = true;
            cbbmanv.Enabled = true;
            tbtrangthai.ReadOnly = false;
            dtpngaylap.Enabled = true;
            tbtongtien.ReadOnly = true;
            if (tbmahoadon.Text != null || tbmahoadon.Text != "")
            {
                layTenHH(tbmahoadon.Text);
            }
        }
        
        //chức năng thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            tbmahoadon.ReadOnly = false;
            cbbmakhachhang.Enabled = true;
            cbbmanv.Enabled = true;
            tbtrangthai.ReadOnly = false;
            dtpngaylap.Enabled = true;
            tbtongtien.ReadOnly = false;

            UpdateDGV();
        }

        //chức năng lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            //try
            //{

                hoa_don addhd = new hoa_don();
                using (DAXuongEntities db = new DAXuongEntities())
                {

                    var kh = db.khach_hang.FirstOrDefault(a => a.ten_kh.Equals(cbbmakhachhang.Text));
                    var nv = db.nhan_vien.FirstOrDefault(a => a.ten_nv.Equals(cbbmanv.Text));

                    addhd.ma_hd = tbmahoadon.Text;
                    addhd.ma_kh = kh.ma_kh;
                    addhd.ma_nv = nv.ma_nv;
                    addhd.ngay_lap = dtpngaylap.Value;
                    addhd.trang_thai = tbtrangthai.Text;
                    addhd.tongtien = float.Parse(tbtongtien.Text);

                    db.hoa_don.Add(addhd);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công");
                    UpdateDGV();
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Không được để trống");
            //}
}

        //chức năng xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    hoa_don delete = db.hoa_don.Where(x => x.ma_hd == tbmahoadon.Text).FirstOrDefault();

                    db.hoa_don.Remove(delete);
                    db.SaveChanges();
                }
                MessageBox.Show("Xóa thành công ");
                UpdateDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần xóa ");
            }
        }

        // Chức năng hủy reload lại form
        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbmahoadon.Text = "";
            cbbmakhachhang.Text = "";
            cbbmanv.Text = "";
            dtpngaylap.Text = "";
            tbtrangthai.Text = "";
            tbtongtien.Text = "";

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = false;
            cbbmanv.Enabled = false;
            tbtrangthai.ReadOnly = true;
            dtpngaylap.Enabled = false;
            tbtongtien.ReadOnly = true;
        }

        // Chức năng tìm kiếm theo mã
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbtimkiem.Text.Equals(""))
                {
                    tbtimkiem.Text = "";
                }

                using (DAXuongEntities db = new DAXuongEntities())
                {
                    List<hoa_don> listhd = db.hoa_don.Where(x => x.ma_hd.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listhd.ToList().ForEach(hd =>
                    {
                        dataGridView1.Rows.Add(
                        hd.ma_hd,
                        hd.ma_kh,
                        hd.ma_nv,
                        hd.ngay_lap,
                        hd.trang_thai,
                        hd.tongtien);
                    }
                    );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }
        
        //chức năng sủa
        private void btnsua_Click(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                string maHD = tbmahoadon.Text;

                hoa_don hd = db.hoa_don.FirstOrDefault(x => x.ma_hd == maHD);
                if (hd != null)
                {
                    hoa_don edit = db.hoa_don.FirstOrDefault(x => x.ma_hd == tbmahoadon.Text);
                    if (edit != null)
                    {
                        edit.ma_hd = tbmahoadon.Text;
                        edit.ma_kh = cbbmakhachhang.Text;
                        edit.ma_nv = cbbmanv.Text;
                        edit.ngay_lap = dtpngaylap.Value;
                        edit.trang_thai = tbtrangthai.Text;
                        edit.tongtien = int.Parse(tbtongtien.Text);
                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hàng hóa");
                }

                UpdateDGV();
            }
        }

        //Print HoaDon
        private readonly PrintDocument docToPrint = new PrintDocument();
        readonly int x = 0;
        readonly int y = 0;
        readonly int height = 30;
        readonly int width = 220;
        private void btninhoadon_Click(object sender, EventArgs e)
        {
            var dtg2 = dtgv2.Rows.Count;
            if (dtg2 > 0)
            {
                PrintDialog PrintDialog1 = new PrintDialog();
                docToPrint.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", width, height+200);
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
            string title = "HÓA ĐƠN BÁN HÀNG";
            StringFormat stringFormat = new StringFormat(StringFormatFlags.NoClip);
            Rectangle rectangle = new Rectangle(x + 1, y,width,height);
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
            Font printFont = new Font("Arial", 11, FontStyle.Bold);
            e.Graphics.DrawString(title, printFont, Brushes.Black, rectangle, stringFormat);
               
            string head = "ShopQuanAoCodeThuatSu\nĐịa chỉ: Cần Thơ\nTên hàng   Giá   Số lượng";
            StringFormat stringFormat2 = new StringFormat(StringFormatFlags.NoClip);
            Rectangle rectangle2 = new Rectangle(x + 1, y + height,width,height + 30);
            stringFormat2.LineAlignment = StringAlignment.Center;
            stringFormat2.Alignment = StringAlignment.Center;
            Font printFont2 = new Font("Arial", 10, FontStyle.Regular);
            e.Graphics.DrawString(head, printFont2, Brushes.Black, rectangle2, stringFormat2);

            //using (DUAN1Entities entities = new DUAN1Entities())
            //{
            //    string TenHang = "";
            //    string Gia = "";
            //    string SL = "";
            //    int cao = 50;
            //    double TongTien = 0;
            //    double ThanhTien = 0;
            //    var cthd = entities.chi_tiet_hoa_don.ToList().Where(a => a.ma_hd.Equals(tbmahoadon.Text));
            //    foreach (var item in cthd)
            //    {
            //        StringFormat stringFormatBody = new StringFormat(StringFormatFlags.NoClip);
            //        Rectangle rectangleBody = new Rectangle(x + 1, y + cao + 30, width,height);
            //        stringFormatBody.LineAlignment = StringAlignment.Center;
            //        stringFormatBody.Alignment = StringAlignment.Center;
            //        Font printFontBody = new Font("Arial", 9, FontStyle.Regular);
            //        TenHang = item.khohang_hanghoa.hang_hoa.ten;
            //        Gia = item.khohang_hanghoa.hang_hoa.gia_ban.ToString();
            //        SL = item.khohang_hanghoa.so_luong.ToString();
            //        TongTien = (double)item.khohang_hanghoa.hang_hoa.gia_ban * (double)item.khohang_hanghoa.so_luong;
            //        ThanhTien += TongTien;
            //        e.Graphics.DrawString(TenHang + "     " + Gia + "     " + SL, printFontBody, Brushes.Black, rectangleBody, stringFormatBody);
            //        cao += 20;
            //    }
            //    StringFormat stringFormatFooter = new StringFormat(StringFormatFlags.NoClip);
            //    Rectangle rectangleFooter = new Rectangle(x + 1, y + cao + 30, width, height);
            //    stringFormatFooter.LineAlignment = StringAlignment.Center;
            //    stringFormatFooter.Alignment = StringAlignment.Center;
            //    Font printFontFooter = new Font("Arial", 10, FontStyle.Regular);

            //    e.Graphics.DrawString("----------\nThành tiền: " + ThanhTien.ToString("#,##0"), printFontFooter, Brushes.Black, rectangleFooter, stringFormatFooter);
            //}
        }
        private static readonly string[] VietNamChar = new string[]
        {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
        };
        public static string LocDau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
        public void layTenHH(string MaHD)
        {
            //using(DUAN1Entities entities = new DUAN1Entities())
            //{
            //    dtgv2.Rows.Clear();
            //    var cthd = entities.chi_tiet_hoa_don.ToList().Where(a => a.ma_hd.Equals(MaHD));

            //    if(cthd != null)
            //    {
            //        cthd.ToList().ForEach(row => dtgv2.Rows.Add(
            //        row.khohang_hanghoa.hang_hoa.ten,
            //        row.khohang_hanghoa.hang_hoa.gia_ban.ToString(),
            //        row.so_luong.ToString()
            //        ));
            //    }
            //}
        }
        private void QuetMaQR_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuetQR quetQR = new QuetQR("a");
            quetQR.ShowDialog();
            this.Close();
        }


    }
}
