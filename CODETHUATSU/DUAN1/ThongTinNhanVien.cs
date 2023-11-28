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
            using (DUAN1Entities db = new DUAN1Entities())
            {
                List<nhan_vien> lnv = db.nhan_vien.Where(x => x.ma_nv.Equals(tbtaikhoan.Text)).ToList();
                if(lnv.Any())
                {
                    //Nếu nhân viên tồn tại, tên nhân viên và số điện thoại sẽ xuất ra trong text box dựa theo mã nhân viên ở tbmanhanvien
                    nhan_vien nv = db.nhan_vien.Where(x => x.ma_nv.Equals(tbtaikhoan.Text)).FirstOrDefault();
                    tbmanhanvien.Text = nv.ma_nv;
                    tbtennhanvien.Text = nv.ten_nv;
                    tbsdt.Text = nv.sdt;
                    btnnhanvien.Enabled = false;
                }
                else
                {
                    //Nếu nhân viên không tồn tại, tên và số điện thoại của chủ shop sẽ truyền vào vì chỉ có một chủ shop duy nhất
                    tbtennhanvien.Text = "";
                    tbsdt.Text = "";
                    tbmanhanvien.Text = "";
                    tbtaikhoan.Text = "";
                    btnnhanvien.Enabled = true;
                }
            }
            
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

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
