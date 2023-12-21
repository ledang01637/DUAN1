using System.Drawing;
using System.Windows.Forms;
using DUAN1.Properties;

namespace DUAN1
{
    public partial class ManHinhChinh : Form
    {
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

        private void btnhanghoa_Click(object sender, System.EventArgs e)
        {
            btnchitiethanghoa.BackColor = Color.FromArgb(0, 0, 0);
            btnchitiethanghoa.ForeColor = Color.White;

            btnhanghoa.BackColor = Color.FromArgb(176, 224, 230);
            btnhanghoa.ForeColor = Color.Black;
            this.IsMdiContainer = true;
            QuanLyHangHoa formQLHH= new QuanLyHangHoa("a");
            //formDangNhap.TopLevel = false;
            //this.Controls.Add(formDangNhap);
            //formDangNhap.Dock = DockStyle.Bottom;
            formQLHH.MdiParent = this;
            formQLHH.Show();
        }

        private void btnkhohang_Click(object sender, System.EventArgs e)
        {
            //xóa màu btnhanghoa
            btnhanghoa.BackColor = Color.FromArgb(0,0,0);
            btnhanghoa.ForeColor = Color.White;

            //
            btnchitiethanghoa.BackColor = Color.FromArgb(176, 224, 230);
            btnchitiethanghoa.ForeColor = Color.Black;




            this.IsMdiContainer = true;
            //formDangNhap.TopLevel = false;
            //this.Controls.Add(formDangNhap);
            //formDangNhap.Dock = DockStyle.Bottom;


            QuanLyHangHoa formQLHH = new QuanLyHangHoa("a");
            ChiTietHangHoa formCTHH = new ChiTietHangHoa("a");

            // Ẩn form QuanLyHangHoa (QLHH) và hiển thị form ChiTietHangHoa (CTHH)
            formQLHH.Hide();
            formCTHH.MdiParent = this;
            formCTHH.Show();
        }
    }
}
