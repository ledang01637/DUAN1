using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Lưu tài khoản vào bản tạm
            tbusername.Text = Properties.Settings.Default.Username;
            tbpassword.Text = Properties.Settings.Default.Password;
            if(Properties.Settings.Default.Username != "")
            {
                cbghinhodn.Checked = true;
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //check box đăng nhập
            if (tbusername.Text == "" || tbpassword.Text == "")
            {
                //Bắt lỗi để trống
                MessageBox.Show(
                    "Vui lòng nhập đủ tài khoản và mật khẩu",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                //Tạo một biến role để truyền tài khoản và mật khẩu vào DBHandler để tìm tài khoản và phân quyền của tài khoản đó
                String role = DBHandler.Login(tbusername.Text, tbpassword.Text);
                if (role != null)
                {
                    if (role.Equals("nhanvien"))
                    {
                        //Nếu tìm được tài khoản có phân quyền là nhanvien
                        this.Hide();
                        ThongTinNhanVien form = new ThongTinNhanVien(tbusername.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("admin"))
                    {
                        //Nếu tìm được tài khoản có phân quyền là admin
                        this.Hide();
                        ThongTinNhanVien form = new ThongTinNhanVien("admin");
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //Nếu tài khoản đã tồn tại nhưng chưa được cấp quyền sẽ hiển thị thông báo
                        MessageBox.Show(
                            "Tài khoản chưa được cấp quyền",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                   
                }
                else
                {
                    //Tài khoản hoặc mật khẩu sai
                    MessageBox.Show(
                        "Tài khoản hoặc mật khẩu chưa đúng",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }


            }
        }

        private void cbhienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            //check box hiển thị và ẩn mật khẩu
            if (cbhienmatkhau.Checked)
            {
                tbpassword.PasswordChar = '\0';
            }
            else
            {
                tbpassword.PasswordChar = '*';
            }
        }

        private void cbghinhodn_CheckedChanged(object sender, EventArgs e)
        {
            //check box ghi nhớ tài khoản
            if(tbusername.Text != "" && tbpassword.Text != "")
            {
                if (cbghinhodn.Checked == true)
                {
                    String users = tbusername.Text;
                    String pass = tbpassword.Text;
                    Properties.Settings.Default.Username = users;
                    Properties.Settings.Default.Password = pass;
                    Properties.Settings.Default.Save();

                }
                else
                {
                    Properties.Settings.Default.Reset();

                }
            }
        }
        
    }
}
