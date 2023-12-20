﻿using System;
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
                        ThongTinNhanVien form = new ThongTinNhanVien(tbusername.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (role.Trim().ToLower().Equals("admin"))
                    {
                        //Nếu tìm được tài khoản có phân quyền là admin
                        this.Hide();
                        ThongTinNhanVien form = new ThongTinNhanVien(tbusername.Text);
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
    }
}
