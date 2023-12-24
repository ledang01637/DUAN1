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
                        Constant.ChangeDatabase(db);
                        List<hoa_don> listhd = db.hoa_don
                            .Where(x => x.ngay_lap >= fromDate && x.ngay_lap < toDate)
                            .ToList();

                        dataGridView1.Rows.Clear();

                        var hoaDonList = (from hd in db.hoa_don
                                          join cthd in db.chi_tiet_hoa_don on hd.ma_hd equals cthd.ma_hd

                                          select new
                                          {
                                              HoaDon = hd,
                                              ChiTietHoaDon = cthd,
                                          }).Where(cthd => cthd.HoaDon.ma_hd.Equals(cthd.ChiTietHoaDon.ma_hd)).ToList();

                        foreach (var item in hoaDonList)
                        {
                            //var countHD = db.hoa_don.Where(x => x.ma_hd.Equals(item.ChiTietHoaDon.ma_hd)).FirstOrDefault();

                            dataGridView1.Rows.Add(
                                item.HoaDon.ma_hd,
                                DateTime.Parse(item.HoaDon.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                                item.ChiTietHoaDon.dongia,
                                item.ChiTietHoaDon.so_luong,
                                item.HoaDon.chi_tiet_hoa_don.Count(),
                                item.HoaDon.chi_tiet_hoa_don.Sum(a => a.dongia).Value.ToString("#,##0")
                            ); ;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
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
                        Constant.ChangeDatabase(db);
                        List<hoa_don> listhd = db.hoa_don
                            .Where(x => x.ngay_lap >= fromDate && x.ngay_lap < toDate)
                            .ToList();

                        dataGridView1.Rows.Clear();

                        var hoaDonList = (from hd in db.hoa_don
                                          join cthd in db.chi_tiet_hoa_don on hd.ma_hd equals cthd.ma_hd

                                          select new
                                          {
                                              HoaDon = hd,
                                              ChiTietHoaDon = cthd,
                                          }).Where(cthd => cthd.HoaDon.ma_hd.Equals(cthd.ChiTietHoaDon.ma_hd)).ToList();

                        foreach (var item in hoaDonList)
                        {
                            //var countHD = db.hoa_don.Where(x => x.ma_hd.Equals(item.ChiTietHoaDon.ma_hd)).FirstOrDefault();

                            dataGridView1.Rows.Add(
                                item.HoaDon.ma_hd,
                                DateTime.Parse(item.HoaDon.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                                item.ChiTietHoaDon.dongia,
                                item.ChiTietHoaDon.so_luong,
                                item.HoaDon.chi_tiet_hoa_don.Count(),
                                item.HoaDon.chi_tiet_hoa_don.Sum(a => a.dongia).Value.ToString("#,##0")
                            ); ;
                        }
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
