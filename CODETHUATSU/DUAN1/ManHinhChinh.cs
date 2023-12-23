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
            activeForm.Show();

            String RoleTK = DBHandler.CheckTK(tbusername.Text);
            if (RoleTK.Equals("nhanvien"))
            {
                //Nếu nhân viên tồn tại, tên nhân viên và số điện thoại sẽ xuất ra trong text box dựa theo mã nhân viên ở tbmanhanvien
                btnnhanvien.Enabled = false;
            }
            else if (RoleTK.Equals("admin"))
            {
                //Nếu nhân viên không tồn tại, tên và số điện thoại của chủ shop sẽ truyền vào vì chỉ có một chủ shop duy nhất
                btnnhanvien.Enabled = true;

            }
        }

        private void Logout_Click(object sender, System.EventArgs e)
        {

        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

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

            btnthongtinnv.BackColor = Color.FromArgb(176, 224, 230);
            btnthongtinnv.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ThongTinNhanVien(tbusername.Text);
            activeForm.MdiParent = this;
            activeForm.Show();
        }

        private void btnhanghoa_Click(object sender, System.EventArgs e)
        {
            ResetColorButton();
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
            activeForm.Show();
        }

        private void btnkhohang_Click(object sender, System.EventArgs e)
        {
            ResetColorButton();

            btnchitiethanghoa.BackColor = Color.FromArgb(176, 224, 230);
            btnchitiethanghoa.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ChiTietHangHoa();
            activeForm.MdiParent = this;
            activeForm.Show();
        }

        private void btnhoadon_Click(object sender, System.EventArgs e)
        {
            ResetColorButton();

            btnhoadon.BackColor = Color.FromArgb(176, 224, 230);
            btnhoadon.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new QuanLyHoaDon();
            activeForm.MdiParent = this;
            activeForm.Show();
        }

        private void btnChiTietHoaDon_Click(object sender, System.EventArgs e)
        {
            ResetColorButton();

            btnChiTietHoaDon.BackColor = Color.FromArgb(176, 224, 230);
            btnChiTietHoaDon.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ChiTietHoaDon();
            activeForm.MdiParent = this;
            activeForm.Show();
        }

        private void btnnhanvien_Click(object sender, System.EventArgs e)
        {
            ResetColorButton();

            btnnhanvien.BackColor = Color.FromArgb(176, 224, 230);
            btnnhanvien.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new QuanLyNhanVien();
            activeForm.MdiParent = this;
            activeForm.Show();
        }

        private void btnkhachhang_Click(object sender, System.EventArgs e)
        {
            ResetColorButton();

            btnkhachhang.BackColor = Color.FromArgb(176, 224, 230);
            btnkhachhang.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new QuanLyKhachHang();
            activeForm.MdiParent = this;
            activeForm.Show();
        }

        private void btnthongke_Click(object sender, System.EventArgs e)
        {
            ResetColorButton();

            btnthongke.BackColor = Color.FromArgb(176, 224, 230);
            btnthongke.ForeColor = Color.Black;
            if (activeForm != null)
            {
                activeForm.Hide();
                activeForm.Dispose();
            }
            activeForm = new ThongKe();
            activeForm.MdiParent = this;
            activeForm.Show();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void tbusername_Click(object sender, System.EventArgs e)
        {

        }
    }
}
