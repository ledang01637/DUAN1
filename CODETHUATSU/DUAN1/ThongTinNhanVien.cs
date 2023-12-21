using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1
{
    public partial class ThongTinNhanVien : Form
    {
        public ThongTinNhanVien(String username)
        {
            //Mã nhân viên sẽ là tài khoản nhân viên nên khi đăng nhập vào tài khoản, username sẽ truyền vào textbox tbmanhanvien
            InitializeComponent();
            tbtaikhoan.Text = username;
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            //Hiển thị thông tin nhân viên
            //using (DUAN1Entities db = new DUAN1Entities())
            //{
            //    nhan_vien nv = db.nhan_vien.Where(x => x.tai_khoan_dangnhap.Equals(tbtaikhoan.Text)).FirstOrDefault();
            //    List<nhan_vien> lnv = db.nhan_vien.Where(x => x.tai_khoan_dangnhap.Equals(tbtaikhoan.Text)).ToList();
            //    String RoleTK = DBHandler.CheckTK(tbtaikhoan.Text);
            //    if (RoleTK.Equals("nhanvien"))
            //    {
            //        //Nếu nhân viên tồn tại, tên nhân viên và số điện thoại sẽ xuất ra trong text box dựa theo mã nhân viên ở tbmanhanvien
            //        tbmanhanvien.Text = nv.ma_nv;
            //        tbtennhanvien.Text = nv.ten_nv;
            //        tbsdt.Text = nv.sdt;
            //        btnnhanvien.Enabled = false;
            //    }
            //    else if(RoleTK.Equals("admin"))
            //    {
            //        //Nếu nhân viên không tồn tại, tên và số điện thoại của chủ shop sẽ truyền vào vì chỉ có một chủ shop duy nhất
            //        tbmanhanvien.Text = nv.ma_nv;
            //        tbtennhanvien.Text = nv.ten_nv;
            //        tbsdt.Text = nv.sdt;
            //        btnnhanvien.Enabled = true;
            //    }
            //}

            tbmanhanvien.Enabled = false;
            tbtennhanvien.Enabled = false;
            tbsdt.Enabled = false;
            tbtaikhoan.Enabled = false;
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
            QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa(tbtaikhoan.Text);
            quanLyHangHoa.ShowDialog();
            this.Close();
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHangHoa khhh = new ChiTietHangHoa(tbtaikhoan.Text);
            khhh.ShowDialog();
            this.Close();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon qlhd = new QuanLyHoaDon(tbtaikhoan.Text);
            qlhd.ShowDialog();
            this.Close();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien qlnv = new QuanLyNhanVien(tbtaikhoan.Text);
            qlnv.ShowDialog();
            this.Close();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang qlkh = new QuanLyKhachHang(tbtaikhoan.Text);
            qlkh.ShowDialog();
            this.Close();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe tk = new ThongKe(tbtaikhoan.Text);
            tk.ShowDialog();
            this.Close();
        }

        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien tinNhanVien = new ThongTinNhanVien(tbtaikhoan.Text);
            this.Hide();
            tinNhanVien.ShowDialog();
            this.Close();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon tinNhanVien = new ChiTietHoaDon(tbtaikhoan.Text);
            this.Hide();
            tinNhanVien.ShowDialog();
            this.Close();
        }
    }
}
