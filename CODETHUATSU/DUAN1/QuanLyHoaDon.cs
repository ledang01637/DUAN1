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
        public QuanLyHoaDon(String username)
        {
            InitializeComponent();
            tbusername.Text = username;
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dtpngaylap.Format = DateTimePickerFormat.Short;
            dtpngaylap.CustomFormat = "dd/MM/yyyy";

            using (DUAN1Entities db = new DUAN1Entities())
            {

                //mã khách hàng
                cbbmakhachhang.Items.Clear();
                db.khach_hang.ToList().ForEach(row => cbbmakhachhang.Items.Add(row.ma_kh));
                //mã nhân viên
                cbbmanv.Items.Clear();
                db.nhan_vien.ToList().ForEach(row => cbbmanv.Items.Add(row.ma_nv));
                //mã hàng hóa
                cbbmahanghoa.Items.Clear();
                db.hang_hoa.ToList().ForEach(row => cbbmahanghoa.Items.Add(row.ma_hang_hoa));

                dataGridView1.Rows.Clear();
                
                db.hoa_don.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.ma_kh,
                    hd.ma_nv,
                    DateTime.Parse(hd.ngay_lap.ToString(),CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.so_luong,
                    hd.thanh_tien,
                    hd.trang_thai
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
                cbbmahanghoa.Enabled = false;
                tbthanhtien.ReadOnly = true;
                tbsoluong.ReadOnly = true;
                tbtrangthai.ReadOnly = true;
                dtpngaylap.Enabled = false;
            }
        }

        // Cập nhật  DGV
        private void UpdateDGV()
        {
            dataGridView1.Rows.Clear();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                dataGridView1.Rows.Clear();

                db.hoa_don.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.ma_kh,
                    hd.ma_nv,
                    DateTime.Parse(hd.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.so_luong,
                    hd.thanh_tien,
                    hd.trang_thai
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
            using (DUAN1Entities db = new DUAN1Entities())
            {
                hoa_don hd = db.hoa_don.Where(x => x.ma_hd == MaHD).FirstOrDefault();

                tbmahoadon.Text = hd.ma_hd;
                cbbmakhachhang.Text = hd.ma_kh;
                cbbmanv.Text = hd.ma_nv;
                dtpngaylap.Text = hd.ngay_lap.ToString();
                tbsoluong.Text = hd.so_luong.ToString();
                tbthanhtien.Text = hd.thanh_tien.ToString();
                tbtrangthai.Text = hd.trang_thai; 

            }

            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = true;
            cbbmanv.Enabled = true;
            cbbmahanghoa.Enabled = true;
            tbthanhtien.ReadOnly = false;
            tbsoluong.ReadOnly = false;
            tbtrangthai.ReadOnly = false;
            dtpngaylap.Enabled = true;
            if(tbmahoadon.Text != null || tbmahoadon.Text != "")
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
            cbbmahanghoa.Enabled = true;
            tbsoluong.ReadOnly = false;
            tbtrangthai.ReadOnly = false;
            dtpngaylap.Enabled = true;
            UpdateDGV();
        }

        //chức năng lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                String maHH = cbbmahanghoa.Text;
                int soLuong = int.Parse(tbsoluong.Text);

                using (DUAN1Entities db = new DUAN1Entities())
                {
                    hang_hoa hangHoa = db.hang_hoa.FirstOrDefault(x => x.ma_hang_hoa == maHH);
                    if (hangHoa != null)
                    {
                        hoa_don addhd = new hoa_don();
                        addhd.ma_hd = tbmahoadon.Text;
                        addhd.ma_kh = cbbmakhachhang.Text;
                        addhd.ma_nv = cbbmanv.Text;
                        addhd.ngay_lap = dtpngaylap.Value;
                        addhd.so_luong = soLuong;
                        addhd.thanh_tien = hangHoa.gia_ban * soLuong;
                        addhd.trang_thai = tbtrangthai.Text;

                        db.hoa_don.Add(addhd);
                        db.SaveChanges();

                        MessageBox.Show("Thêm thành công");
                        UpdateDGV();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hàng hóa");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không được để trống");
            }
        }

        //chức năng xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (DUAN1Entities db = new DUAN1Entities())
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
            cbbmahanghoa.Text = "";
            cbbmakhachhang.Text = "";
            cbbmanv.Text = "";
            tbsoluong.Text = "";
            tbthanhtien.Text = "";
            dtpngaylap.Text = "";
            tbtrangthai.Text = "";

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = false;
            cbbmanv.Enabled = false;
            cbbmahanghoa.Enabled = false;
            tbsoluong.ReadOnly = true;
            tbtrangthai.ReadOnly = true;
            dtpngaylap.Enabled = false;
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

                using (DUAN1Entities db = new DUAN1Entities())
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
                        hd.so_luong,
                        hd.thanh_tien,
                        hd.trang_thai);
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
            using (DUAN1Entities db = new DUAN1Entities())
            {
                string maHH = cbbmahanghoa.Text;
                int soLuong = int.Parse(tbsoluong.Text);

                hang_hoa hangHoa = db.hang_hoa.FirstOrDefault(x => x.ma_hang_hoa == maHH);
                if (hangHoa != null)
                {
                    hoa_don edit = db.hoa_don.FirstOrDefault(hd => hd.ma_hd == tbmahoadon.Text);
                    if (edit != null)
                    {
                        edit.ma_kh = cbbmakhachhang.Text;
                        edit.ma_nv = cbbmanv.Text;
                        edit.ngay_lap = dtpngaylap.Value;
                        edit.so_luong = soLuong;
                        edit.thanh_tien = hangHoa.gia_ban * soLuong;
                        edit.trang_thai = tbtrangthai.Text;
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
        private void btnthoat_Click(object sender, EventArgs e)
        {
            //Nút thoát ra ngoài form Đăng nhập
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }
        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa(tbusername.Text);
            quanLyHangHoa.ShowDialog();
            this.Close();
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHangHangHoa khhh = new KhoHangHangHoa(tbusername.Text);
            khhh.ShowDialog();
            this.Close();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon qlhd = new QuanLyHoaDon(tbusername.Text);
            qlhd.ShowDialog();
            this.Close();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien qlnv = new QuanLyNhanVien(tbusername.Text);
            qlnv.ShowDialog();
            this.Close();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang qlkh = new QuanLyKhachHang(tbusername.Text);
            qlkh.ShowDialog();
            this.Close();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe tk = new ThongKe(tbusername.Text);
            tk.ShowDialog();
            this.Close();
        }
        //Print HoaDon
        private readonly PrintDocument docToPrint = new PrintDocument();
        readonly int  y = 0;
        readonly int height = 300;
        readonly int width = 228;
        private void btninhoadon_Click(object sender, EventArgs e)
        {
            var dtg2 = dtgv2.Rows.Count;
            if (dtg2 > 0)
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
            string title = "HOA DON BAN HANG\n\nTên hàng   Giá   Số lượng";
            StringFormat stringFormat = new StringFormat(StringFormatFlags.NoClip);
            Rectangle rectangle = new Rectangle(new Point(height, y), new Size(width, height));
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;
            Font printFont = new Font("Arial", 11, FontStyle.Bold);
            e.Graphics.DrawString(title, printFont, Brushes.Black, rectangle, stringFormat);

            using (DUAN1Entities entities = new DUAN1Entities())
            {
                string TenHang = "";
                string Gia = "";
                string SL = "";
                int cao = 50;
                double TongTien = 0;
                double ThanhTien = 0;
                var cthd = entities.chi_tiet_hoa_don.ToList().Where(a => a.ma_hd.Equals(tbmahoadon.Text));
                foreach(var item in cthd)
                {
                    StringFormat stringFormatBody = new StringFormat(StringFormatFlags.NoClip);
                    Rectangle rectangleBody = new Rectangle(new Point(height, y + cao), new Size(width, height));
                    stringFormatBody.LineAlignment = StringAlignment.Center;
                    stringFormatBody.Alignment = StringAlignment.Center;
                    Font printFontBody = new Font("Arial", 10, FontStyle.Regular);
                    TenHang = item.khohang_hanghoa.hang_hoa.ten;
                    Gia = item.khohang_hanghoa.hang_hoa.gia_ban.ToString();
                    SL = item.khohang_hanghoa.so_luong.ToString();
                    TongTien = (double)item.khohang_hanghoa.hang_hoa.gia_ban * (double)item.khohang_hanghoa.so_luong;
                    ThanhTien += /*(double)item.khohang_hanghoa.hang_hoa.gia_ban*/ TongTien;
                    e.Graphics.DrawString(TenHang + "     " + Gia + "     " + SL, printFontBody, Brushes.Black, rectangleBody, stringFormatBody);
                    cao += 20;
                }
                StringFormat stringFormatFooter = new StringFormat(StringFormatFlags.NoClip);
                Rectangle rectangleFooter = new Rectangle(new Point(height, y + cao + 30), new Size(width, height));
                stringFormatFooter.LineAlignment = StringAlignment.Center;
                stringFormatFooter.Alignment = StringAlignment.Center;
                Font printFontFooter = new Font("Arial", 10, FontStyle.Bold);

                e.Graphics.DrawString("Thành tiền: " + ThanhTien.ToString("#,##0"), printFontFooter, Brushes.Black, rectangleFooter, stringFormatFooter);
            }
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
            using(DUAN1Entities entities = new DUAN1Entities())
            {
                dtgv2.Rows.Clear();
                var cthd = entities.chi_tiet_hoa_don.ToList().Where(a => a.ma_hd.Equals(MaHD));

                if(cthd != null)
                {
                    cthd.ToList().ForEach(row => dtgv2.Rows.Add(
                    row.khohang_hanghoa.hang_hoa.ten,
                    row.khohang_hanghoa.hang_hoa.gia_ban.ToString(),
                    row.khohang_hanghoa.so_luong.ToString()
                    ));
                }
            }
        }
        private void QuetMaQR_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuetQR quetQR = new QuetQR();
            quetQR.ShowDialog();
            this.Close();
        }
        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien tinNhanVien = new ThongTinNhanVien(tbusername.Text);
            this.Hide();
            tinNhanVien.ShowDialog();
            this.Close();
        }
    }
}
