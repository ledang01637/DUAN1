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
            label2.Text = username;
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            ////Hiển thị thông tin nhân viên
            using (DAXuongEntities db = new DAXuongEntities())
            {

                dang_nhap dn = db.dang_nhap.Where(x => x.tai_khoan.Equals(label2.Text)).FirstOrDefault();
                nhan_vien nv = db.nhan_vien.Where(x => x.ma_nv.Equals(dn.ma_nv)).FirstOrDefault();
                String RoleTK = DBHandler.CheckTK(label2.Text);
                if (RoleTK.Equals("nhanvien"))
                {
                    //Nếu nhân viên tồn tại, tên nhân viên và số điện thoại sẽ xuất ra trong text box dựa theo mã nhân viên ở tbmanhanvien
                    tbmanhanvien.Text = nv.ma_nv;
                    tbtennhanvien.Text = nv.ten_nv;
                    tbsdt.Text = nv.sdt;
                    tbemail.Text = nv.email;
                }
                else if (RoleTK.Equals("admin"))
                {
                    //Nếu nhân viên không tồn tại, tên và số điện thoại của chủ shop sẽ truyền vào vì chỉ có một chủ shop duy nhất
                    tbmanhanvien.Text = nv.ma_nv;
                    tbtennhanvien.Text = nv.ten_nv;
                    tbsdt.Text = nv.sdt;
                    tbemail.Text = nv.email;
                }
            }
            tbemail.ReadOnly = true; 
            tbmanhanvien.ReadOnly = true;
            tbtennhanvien.ReadOnly = true;
            tbsdt.ReadOnly = true;

        }

        public void nhanmanv(String manv)
        {
            tbmanhanvien.Text = manv;
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
            //this.Hide();
            //QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa();
            //quanLyHangHoa.ShowDialog();
            //this.Close();
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHangHoa khhh = new ChiTietHangHoa();
            khhh.ShowDialog();
            this.Close();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon qlhd = new QuanLyHoaDon();
            qlhd.ShowDialog();
            this.Close();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.ShowDialog();
            this.Close();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            qlkh.ShowDialog();
            this.Close();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
            this.Close();
        }

        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien tinNhanVien = new ThongTinNhanVien(label2.Text);
            this.Hide();
            tinNhanVien.ShowDialog();
            this.Close();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            //ChiTietHoaDon tinNhanVien = new ChiTietHoaDon();
            //this.Hide();
            //tinNhanVien.ShowDialog();
            //this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
