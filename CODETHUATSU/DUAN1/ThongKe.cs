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

namespace DUAN1
{
    public partial class ThongKe : Form
    {
        public ThongKe(String username)
        {
            InitializeComponent();
            tbusername.Text = username;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            dtpngaylap.Format = DateTimePickerFormat.Short;
            dtpngaylap.CustomFormat = "dd/MM/yyyy";

            using (DUAN1Entities db = new DUAN1Entities())
            {


                dataGridView1.Rows.Clear();

                var hoaDonList = db.chi_tiet_hoa_don.ToList();


                foreach (var CTHoaDon in hoaDonList)
                {
                    var CTHD = db.chi_tiet_hoa_don.FirstOrDefault(kh => kh.makho_hangchitiet == CTHoaDon.makho_hangchitiet);
                    var HoaDon = db.hoa_don.FirstOrDefault(kh => kh.ma_hd == CTHoaDon.ma_hd);

                    var KHHH = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet.Equals(CTHD.makho_hangchitiet));
                    var hanghoa = db.hang_hoa.FirstOrDefault(x => x.ma_hang_hoa.Equals(KHHH.ma_hang_hoa));

                    dataGridView1.Rows.Add(
                        CTHD.makho_hangchitiet,
                        DateTime.Parse(HoaDon.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                        CTHoaDon.thanh_tien,
                        CTHoaDon.so_luong,
                        CTHD != null ? KHHH.so_luong - CTHoaDon.so_luong : 0
                    ); ;
                }
            }

        }

        //hiển thị
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];

            string MaKHCT = rowData.Cells[0].Value.ToString();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                khohang_hanghoa khhh = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet == MaKHCT);
                chi_tiet_hoa_don cthd = db.chi_tiet_hoa_don.FirstOrDefault(x => x.makho_hangchitiet.Equals(khhh.makho_hangchitiet));
                hoa_don hd = db.hoa_don.FirstOrDefault(x => x.ma_hd.Equals(cthd.ma_hd));

                tbmakhohangchitiet.Text = khhh.makho_hangchitiet;
                dtpngaylap.Text = hd.ngay_lap.ToString();
                tbgia.Text = cthd.thanh_tien.ToString();
                tbsoluongdaban.Text = cthd.so_luong.ToString();
                tbsltrongkho.Text = (khhh.so_luong - cthd.so_luong).ToString();


            }
        }

        //tìm kiếm theo ngày và mã
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbtimkiem.Text))
                {
                    tbtimkiem.Text = "";
                }
                else
                {
                    DateTime fromDate = dtptungay.Value.Date;
                    DateTime toDate = dtpdenngay.Value.Date.AddDays(1); // Add 1 day to include the end date


                    using (DUAN1Entities db = new DUAN1Entities())
                    {
                        List<chi_tiet_hoa_don> listhd = db.chi_tiet_hoa_don.Where(x => x.makho_hangchitiet.Equals(tbtimkiem.Text) &&
                        (x.hoa_don.ngay_lap >= fromDate && x.hoa_don.ngay_lap <= toDate)).ToList();
                        dataGridView1.Rows.Clear();
                        listhd.ToList().ForEach(cthd =>
                        {
                            dataGridView1.Rows.Add(
                            cthd.makho_hangchitiet,
                            cthd.hoa_don.ngay_lap,
                            cthd.thanh_tien,
                            cthd.so_luong,
                            cthd.khohang_hanghoa.so_luong);
                        }
                        );
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }
    

        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbtimkiem.Text = " ";
            ThongKe_Load(null, EventArgs.Empty);
        }

        //btn hóa đơn
        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon form = new QuanLyHoaDon(tbusername.Text);
            form.ShowDialog();
            this.Close();
        }

        //btn thoát
        private void btnthoat_Click(object sender, EventArgs e)
        {
            //Nút thoát ra ngoài form Đăng nhập
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

        //btn hàng hóa
        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa(tbusername.Text);
            quanLyHangHoa.ShowDialog();
            this.Close();
        }

        //btn kho hàng
        private void btnkhohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHangHangHoa khhh = new KhoHangHangHoa(tbusername.Text);
            khhh.ShowDialog();
            this.Close();
        }

        //btn nhân viên
        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien qlnv = new QuanLyNhanVien(tbusername.Text);
            qlnv.ShowDialog();
            this.Close();
        }

        //btn nhân viên
        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang qlkh = new QuanLyKhachHang(tbusername.Text);
            qlkh.ShowDialog();
            this.Close();
        }

        //btn thống kê
        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe tk = new ThongKe(tbusername.Text);
            tk.ShowDialog();
            this.Close();
        }

        //btn thông tin nhân viên
        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinNhanVien ttnv = new ThongTinNhanVien(tbusername.Text);
            ttnv.ShowDialog();
            this.Close();
        }



    }
}
