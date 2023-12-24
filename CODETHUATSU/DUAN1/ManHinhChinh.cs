using System.Data.Entity;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using DUAN1.Properties;

namespace DUAN1
{
    public partial class ManHinhChinh : Form
    {
        private Form activeForm;
        public ManHinhChinh()
        {
            InitializeComponent();

            Header.BackColor = Constant.redColor;
            SideBar.BackColor = Constant.blueColor;           
        }

        public void NhanGiaTri(string username)
        {
            tbusername.Text = username;
        }
        string User = "";
        private void ManHinhChinh_Load(object sender, System.EventArgs e)
        {
            this.IsMdiContainer = true;
            //Login formDangNhap = new Login();

            ////formDangNhap.TopLevel = false;
            ////this.Controls.Add(formDangNhap);
            ////formDangNhap.Dock = DockStyle.Bottom;

            //formDangNhap.MdiParent = this;
            //formDangNhap.Show();

            btnthongtinnv.BackColor = Color.FromArgb(176, 224, 230);
            btnthongtinnv.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ThongTinNhanVien(tbusername.Text) ;
            activeForm.MdiParent = this;
            lblTenForm.Text = "Thông tin nhân viên";
            activeForm.Show();
            User = DBHandler.CheckTK(tbusername.Text);
            Role();
        }
        private void Role()
        {
            if (User.Equals("nhanvien"))
            {
                //Nếu nhân viên tồn tại, tên nhân viên và số điện thoại sẽ xuất ra trong text box dựa theo mã nhân viên ở tbmanhanvien
                btnnhanvien.Enabled = false;
                btnnhanvien.BackColor = Color.Gray;

            }
            else if (User.Equals("admin"))
            {
                //Nếu nhân viên không tồn tại, tên và số điện thoại của chủ shop sẽ truyền vào vì chỉ có một chủ shop duy nhất
                btnnhanvien.Enabled = true;
                btnnhanvien.Cursor = Cursors.Hand;
            }
        }
        private void Logout_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void ResetColorButton()
        {
            btnthongtinnv.BackColor = Color.FromArgb(0, 0, 0);
            btnthongtinnv.ForeColor = Color.White;

            btnhanghoa.BackColor = Color.FromArgb(0, 0, 0);
            btnhanghoa.ForeColor = Color.White;

            btnchitiethanghoa.BackColor = Color.FromArgb(0, 0, 0);
            btnchitiethanghoa.ForeColor = Color.White;

            btnhoadon.BackColor = Color.FromArgb(0, 0, 0);
            btnhoadon.ForeColor = Color.White;

            btnChiTietHoaDon.BackColor = Color.FromArgb(0, 0, 0);
            btnChiTietHoaDon.ForeColor = Color.White;

            btnnhanvien.BackColor = Color.FromArgb(0, 0, 0);
            btnnhanvien.ForeColor = Color.White;

            btnkhachhang.BackColor = Color.FromArgb(0, 0, 0);
            btnkhachhang.ForeColor = Color.White;

            btnthongke.BackColor = Color.FromArgb(0, 0, 0);
            btnthongke.ForeColor = Color.White;


        }
        private void btnthongtinnv_Click(object sender, System.EventArgs e)
        {
            
            ResetColorButton();
            Role();
            btnthongtinnv.BackColor = Color.FromArgb(176, 224, 230);
            btnthongtinnv.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ThongTinNhanVien(tbusername.Text);
            activeForm.MdiParent = this;
            lblTenForm.Text = "Thông tin nhân viên";
            activeForm.Show();
        }

        private void btnhanghoa_Click(object sender, System.EventArgs e)
        {
            
            ResetColorButton();
            Role();
            btnhanghoa.BackColor = Color.FromArgb(176, 224, 230);
            btnhanghoa.ForeColor = Color.Black;
            this.IsMdiContainer = true;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new QuanLyHangHoa();
            activeForm.MdiParent = this;
            lblTenForm.Text = "Quản lý hàng hóa";
            activeForm.Show();
        }

        private void btnkhohang_Click(object sender, System.EventArgs e)
        {
            
            ResetColorButton();
            Role();
            btnchitiethanghoa.BackColor = Color.FromArgb(176, 224, 230);
            btnchitiethanghoa.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ChiTietHangHoa();
            activeForm.MdiParent = this;
            lblTenForm.Text = "Quản lý chi tiết hàng hóa";
            activeForm.Show();
        }

        private void btnhoadon_Click(object sender, System.EventArgs e)
        {
            
            ResetColorButton();
            Role();
            btnhoadon.BackColor = Color.FromArgb(176, 224, 230);
            btnhoadon.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new QuanLyHoaDon(tbusername.Text);
            activeForm.MdiParent = this;
            lblTenForm.Text = "Quản lý hóa đơn";
            activeForm.Show();
        }

        private void btnChiTietHoaDon_Click(object sender, System.EventArgs e)
        {
           
            ResetColorButton();
            Role();
            btnChiTietHoaDon.BackColor = Color.FromArgb(176, 224, 230);
            btnChiTietHoaDon.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ChiTietHoaDon();
            activeForm.MdiParent = this;
            lblTenForm.Text = "Quản lý chi tiết hóa đơn";
            activeForm.Show();
        }

        private void btnnhanvien_Click(object sender, System.EventArgs e)
        {
           
            ResetColorButton();
            Role();
            btnnhanvien.BackColor = Color.FromArgb(176, 224, 230);
            btnnhanvien.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new QuanLyNhanVien();
            activeForm.MdiParent = this;
            lblTenForm.Text = "Quản lý nhân viên";
            activeForm.Show();
        }

        private void btnkhachhang_Click(object sender, System.EventArgs e)
        {
           
            ResetColorButton();
            Role();
            btnkhachhang.BackColor = Color.FromArgb(176, 224, 230);
            btnkhachhang.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new QuanLyKhachHang();
            activeForm.MdiParent = this;
            lblTenForm.Text = "Quản lý khách hàng";
            activeForm.Show();
        }

        private void btnthongke_Click(object sender, System.EventArgs e)
        {
            
            ResetColorButton();
            Role();
            btnthongke.BackColor = Color.FromArgb(176, 224, 230);
            btnthongke.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ThongKe();
            activeForm.MdiParent = this;
            lblTenForm.Text = "Quản lý thống kê";
            activeForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
