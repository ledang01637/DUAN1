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
    }
}
