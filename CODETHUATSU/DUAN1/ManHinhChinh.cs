using System.Drawing;
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

        private void ManHinhChinh_Load(object sender, System.EventArgs e)
        {
            this.IsMdiContainer = true;
            Login formDangNhap = new Login();
            //formDangNhap.TopLevel = false;
            //this.Controls.Add(formDangNhap);
            //formDangNhap.Dock = DockStyle.Bottom;
            formDangNhap.MdiParent = this;
            formDangNhap.Show();
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
            ThongTinNhanVien formTTNV = new ThongTinNhanVien("a");
            formTTNV.MdiParent = this;
            formTTNV.Show();
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
            QuanLyHangHoa formQLHH= new QuanLyHangHoa("a");
            formQLHH.MdiParent = this;
            formQLHH.Show();
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
            ChiTietHangHoa formCTHH = new ChiTietHangHoa("a");
            formCTHH.MdiParent = this;
            formCTHH.Show();
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
            QuanLyHoaDon formQLHD = new QuanLyHoaDon("a");
            formQLHD.MdiParent = this;
            formQLHD.Show();
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
            ChiTietHoaDon formCTHD = new ChiTietHoaDon("a");
            formCTHD.MdiParent = this;
            formCTHD.Show();
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
            QuanLyNhanVien formQLNV = new QuanLyNhanVien("a");
            formQLNV.MdiParent = this;
            formQLNV.Show();
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
            QuanLyKhachHang formQLKH = new QuanLyKhachHang("a");
            formQLKH.MdiParent = this;
            formQLKH.Show();
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
            ThongKe formTK = new ThongKe("a");
            formTK.MdiParent = this;
            formTK.Show();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

            this.InitializeComponent();

        }
    }
}
