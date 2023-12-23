using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace DUAN1
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            //tbusername.Text = username;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            using (DAXuongEntities db = new DAXuongEntities())
            {

                dataGridView1.Rows.Clear();

                DateTime today = DateTime.Today;
                var lateday = today.AddDays(-10);

                var hoaDonList = db.hoa_don.Where(cthd => cthd.ngay_lap <= today && cthd.ngay_lap >= lateday);
                var Key = db.chi_tiet_hoa_don.GroupBy(a => a.chitiet_hanghoa.hang_hoa.ten);

                foreach (var hoaDon in hoaDonList)
                {
                    var ChiTietHoaDon = db.chi_tiet_hoa_don.FirstOrDefault(cthd => cthd.ma_hd == hoaDon.ma_hd);
                    
                    dataGridView1.Rows.Add(
                        hoaDon.ma_hd,
                        DateTime.Parse(hoaDon.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                        ChiTietHoaDon.dongia,
                        ChiTietHoaDon.so_luong,
                        hoaDon.chi_tiet_hoa_don.Count(),
                        hoaDon.chi_tiet_hoa_don.Sum(a => a.dongia).Value.ToString("#,##0")
                    ); ;
                }
            }

        }

        ////btn hóa đơn
        //private void btnhoadon_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyHoaDon form = new QuanLyHoaDon(tbusername.Text);
        //    form.ShowDialog();
        //    this.Close();
        //}

        ////btn thoát
        //private void btnthoat_Click(object sender, EventArgs e)
        //{
        //    //Nút thoát ra ngoài form Đăng nhập
        //    this.Hide();
        //    Login form = new Login();
        //    form.ShowDialog();
        //    this.Close();
        //}

        ////btn hàng hóa
        //private void btnhanghoa_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa(tbusername.Text);
        //    quanLyHangHoa.ShowDialog();
        //    this.Close();
        //}

        ////btn kho hàng
        //private void btnkhohang_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ChiTietHangHoa khhh = new ChiTietHangHoa(tbusername.Text);
        //    khhh.ShowDialog();
        //    this.Close();
        //}

        ////btn nhân viên
        //private void btnnhanvien_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyNhanVien qlnv = new QuanLyNhanVien(tbusername.Text);
        //    qlnv.ShowDialog();
        //    this.Close();
        //}

        ////btn nhân viên
        //private void btnkhachhang_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyKhachHang qlkh = new QuanLyKhachHang(tbusername.Text);
        //    qlkh.ShowDialog();
        //    this.Close();
        //}

        ////btn thống kê
        //private void btnthongke_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ThongKe tk = new ThongKe(tbusername.Text);
        //    tk.ShowDialog();
        //    this.Close();
        //}

        ////btn thông tin nhân viên
        //private void btnthongtinnv_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ThongTinNhanVien ttnv = new ThongTinNhanVien(tbusername.Text);
        //    ttnv.ShowDialog();
        //    this.Close();
        //}

        //private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ChiTietHoaDon ttnv = new ChiTietHoaDon(tbusername.Text);
        //    ttnv.ShowDialog();
        //    this.Close();
        //}

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtptungay.Value.Date;
                DateTime toDate = dtpdenngay.Value.Date;

                if (dtptungay.Value.Year <= 1990 || dtpdenngay.Value.Year > DateTime.Today.Year)
                {
                    MessageBox.Show("Năm không nhỏ hơn 1990 và lớn hơn năm hiện tại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (DAXuongEntities db = new DAXuongEntities())
                    {
                        List<hoa_don> listhd = db.hoa_don
                            .Where(x => x.ngay_lap >= fromDate && x.ngay_lap < toDate)
                            .ToList();

                        dataGridView1.Rows.Clear();

                        listhd.ForEach(hd =>
                        {
                            var CTHD = db.chi_tiet_hoa_don.FirstOrDefault(cthd => cthd.ma_hd == hd.ma_hd);

                            chi_tiet_hoa_don cthh = db.chi_tiet_hoa_don.FirstOrDefault(x => x.ma_hd == hd.ma_hd);
                            

                            if (hd != null)
                            {
                                dataGridView1.Rows.Add(
                                        hd.ma_hd,
                                        hd.ngay_lap,
                                        cthh.chitiet_hanghoa.gia_ban,
                                        cthh.so_luong,
                                        listhd.Count(),
                                        cthh.dongia);
                            }
                        });
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }
    }
}
