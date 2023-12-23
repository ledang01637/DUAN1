using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DUAN1.Properties;

namespace DUAN1
{
    public partial class Login : Form
    {
        private bool viewPass = false;
        public Login()
        {
            InitializeComponent();
            btnsubmit.BackColor = Constant.cyanColor;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            String MaHoaMatKhau = GetMD5(tbpassword.Text);
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
                String role = DBHandler.Login(tbusername.Text, MaHoaMatKhau);
                if (role != null)
                {
                    
                    if (role.Trim().ToLower().Equals("nhanvien"))
                    {
                        //Nếu tìm được tài khoản có phân quyền là nhanvien
                        this.Hide();
                        ManHinhChinh form = new ManHinhChinh();
                        form.NhanGiaTri(tbusername.Text);
                        form.ShowDialog();
                    }
                    else if (role.Trim().ToLower().Equals("admin"))
                    {
                        //Nếu tìm được tài khoản có phân quyền là admin
                        this.Hide();
                        ManHinhChinh form = new ManHinhChinh();
                        form.NhanGiaTri(tbusername.Text);
                        form.Show();
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
        public string GetMD5(String chuoi)
        {
            String str_Md5 = "";
            byte[] mang = Encoding.UTF8.GetBytes(chuoi);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            mang = md5.ComputeHash(mang);
            foreach (byte b in mang)
            {
                str_Md5 += b.ToString();
            }
            return str_Md5;
        }

        private void quenmatkhau_Click(object sender, EventArgs e)
        {
            LayCode layCode = new LayCode();
            this.Hide();
            layCode.Show();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            //Lưu tài khoản vào bảng tạm
            tbusername.Text = Properties.Settings.Default.Username;
            tbpassword.Text = Properties.Settings.Default.Password;
            if (Properties.Settings.Default.Username != "")
            {
                cbghinhodn.Checked = true;
            }
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {
            tbusername.Text = tbusername.Text.ToLower();
            tbusername.SelectionStart = tbusername.Left;
            tbusername.SelectionLength = 0;
        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            tbpassword.Text = tbpassword.Text.ToLower();
            tbpassword.SelectionStart = tbpassword.Left;
            tbpassword.SelectionLength = 0;
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            if(viewPass)
            {
                btnViewPass.Image = Resources.icons8_eyeclose_24;
                tbpassword.PasswordChar = '*';
            } else
            {
                btnViewPass.Image = Resources.icons8_eye_24;
                tbpassword.PasswordChar = '\0';
            }
            viewPass = !viewPass;
        }

        private void btnsubmit_MouseHover(object sender, EventArgs e)
        {
            btnsubmit.BackColor = Color.LightCyan;
        }

        private void btnsubmit_MouseLeave(object sender, EventArgs e)
        {
            btnsubmit.BackColor = Constant.cyanColor;
        }

        private void btnsubmit_MouseMove(object sender, MouseEventArgs e)
        {
            btnsubmit.BackColor = Color.LightCyan;
        }
    }
}
