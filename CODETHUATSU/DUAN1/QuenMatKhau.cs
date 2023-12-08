using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.Entity.Validation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Security.Cryptography;

namespace DUAN1
{
    public partial class QuenMatKhau : Form
    {
        readonly int code = new Random().Next(10000,99999);
        bool focusUser, focusPw1, focusPw2, focusXN;
        bool isTextUser, isTextPw1, isTextPw2, isTextXN;
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        #region Mouse
        private void btngui_MouseHover(object sender, EventArgs e)
        {
            btngui.BackColor = Color.CadetBlue; 
        }
        private void btngui_MouseLeave(object sender, EventArgs e)
        {
            btngui.BackColor = Color.PaleTurquoise;
        }

        private void btngui_MouseMove(object sender, MouseEventArgs e)
        {
            btngui.BackColor = Color.CadetBlue;
        }
        private void btnsubmit_MouseHover(object sender, EventArgs e)
        {
            btnsubmit.BackColor = Color.CadetBlue;
        }

        private void btnsubmit_MouseMove(object sender, MouseEventArgs e)
        {
            btnsubmit.BackColor = Color.CadetBlue;
        }

        private void btnsubmit_MouseLeave(object sender, EventArgs e)
        {
            btnsubmit.BackColor = Color.PaleTurquoise;
        }
        #endregion
        private void btngui_Click(object sender, EventArgs e)
        {
            SendEmail();
        }
        protected void SendEmail()
        {
            string from = "danglhpc06254@fpt.edu.vn";
            string pw = "nkpbolujrxlizknl";
            string context = "CodeThuatSu gửi quý khách, " +
                "\n\tCó phải bạn đã quên mật khẩu?" +
                "\n\tĐây là mã OTP quên mật khẩu của bạn: " + code + 
                "\n\tVui lòng không cung cấp mã này cho bất kì ai!" +
                "\n\tNếu bạn không muốn thay đổi mật khẩu, vui lòng bỏ qua thông báo này." +
                "\n\nCảm ơn.";
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            if(getEmail(tbemail.Text.ToLower().Trim()))
            {
                string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                Regex regex = new Regex(strRegex);
                if (regex.IsMatch(tbemail.Text))
                {
                    mail.To.Add(tbemail.Text);
                    mail.Subject = "OTP xác nhận đổi mật khẩu";
                    mail.Body = context;

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(from, pw);
                    smtpClient.EnableSsl = true;
                    smtpClient.Port = 587;
                    try
                    {
                        smtpClient.Send(mail);
                        MessageBox.Show("Đã gửi OTP vui lòng kiểm tra email của bạn");

                    }
                    catch
                    {
                        MessageBox.Show("Email gửi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }  
            }
            else
            {
                MessageBox.Show("Email không có trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int xacNhan;
            if(int.TryParse(tbxacnhan.Text,out xacNhan))
            {
                if (xacNhan == code)
                {
                    if (tbpassword1.Text.Trim().Equals(tbpassword2.Text.Trim()) && getTK(tbusername.Text.Trim()))
                    {
                        if (tbpassword2.Text.Trim().Length >= 5 && tbpassword1.Text.Trim().Length >= 5)
                        {
                            using (DUAN1Entities dUAN1Entities = new DUAN1Entities())
                            {
                                //Mã hóa
                                DBHandler dBHanler = new DBHandler();
                                String Hash = dBHanler.GetMD5(tbpassword1.Text);
                                dang_nhap dang_ = dUAN1Entities.dang_nhap.FirstOrDefault(a => a.tai_khoan.Equals(tbusername.Text.Trim()));
                                dang_.mat_khau = Hash;
                                try
                                {
                                    dUAN1Entities.SaveChanges();
                                }
                                catch (Exception excpt)
                                {
                                    Console.WriteLine(excpt.Message);
                                }
                                MessageBox.Show("Cập nhật mật khẩu mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu phải lớn hơn 4 kí tự ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }  
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("OTP không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lỗi nhập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        public bool getTK(string tk)
        {
            using (DUAN1Entities dUAN1Entities = new DUAN1Entities())
            {
                dang_nhap dang_ = dUAN1Entities.dang_nhap.FirstOrDefault(a => a.tai_khoan.Equals(tk));
                if(dang_ != null)
                {
                    return true;
                }
                return false;
            } 
        }
        public bool getEmail(string email)
        {
            using (DUAN1Entities dUAN1Entities = new DUAN1Entities())
            {
                dang_nhap dang_ = dUAN1Entities.dang_nhap.FirstOrDefault(a => a.email.Equals(email));
                if (dang_ != null)
                {
                    return true;
                }
                return false;
            }
        }
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            //User
            if (focusUser)
            {
                if (tbusername.Text.Trim() == "" || tbusername.Text.Trim() == null)
                {
                    Pen p = new Pen(Color.Red);
                    int GrX = groupBox2.Location.X;
                    int GrY = groupBox2.Location.Y;
                    e.Graphics.DrawRectangle(p, new Rectangle(tbusername.Location.X - GrX - 1, tbusername.Location.Y - GrY - 1, tbusername.Width + 1, tbusername.Height + 1));
                }
                else if (isTextUser)
                {
                    Pen p = new Pen(Color.LawnGreen);
                    int GrX = groupBox2.Location.X;
                    int GrY = groupBox2.Location.Y;
                    e.Graphics.DrawRectangle(p, new Rectangle(tbusername.Location.X - GrX - 1, tbusername.Location.Y - GrY - 1, tbusername.Width + 1, tbusername.Height + 1));
                }
            }
            else
            {
                tbusername.BorderStyle = BorderStyle.FixedSingle;
            }
            //Pw1
            if (focusPw1)
            {
                if (tbpassword1.Text.Trim() == "" || tbpassword1.Text.Trim() == null || tbpassword1.Text.Length < 5)
                {
                    Pen p = new Pen(Color.Red);
                    int GrX = groupBox2.Location.X;
                    int GrY = groupBox2.Location.Y;
                    e.Graphics.DrawRectangle(p, new Rectangle(tbpassword1.Location.X - GrX - 1, tbpassword1.Location.Y - GrY - 1, tbpassword1.Width + 1, tbpassword1.Height + 1));
                }
                else if (isTextPw1)
                {
                    Pen p = new Pen(Color.LawnGreen);
                    int GrX = groupBox2.Location.X;
                    int GrY = groupBox2.Location.Y;
                    e.Graphics.DrawRectangle(p, new Rectangle(tbpassword1.Location.X - GrX - 1, tbpassword1.Location.Y - GrY - 1, tbpassword1.Width + 1, tbpassword1.Height + 1));
                }
            }
            else
            {
                tbpassword1.BorderStyle = BorderStyle.FixedSingle;
            }
            //Pw2
            if (focusPw2)
            {
                if (tbpassword2.Text.Trim() == "" || tbpassword2.Text.Trim() == null || tbpassword2.Text.Length < 5)
                {
                    Pen p = new Pen(Color.Red);
                    int GrX = groupBox2.Location.X;
                    int GrY = groupBox2.Location.Y;
                    e.Graphics.DrawRectangle(p, new Rectangle(tbpassword2.Location.X - GrX - 1, tbpassword2.Location.Y - GrY - 1, tbpassword2.Width + 1, tbpassword2.Height + 1));
                }
                else if (isTextPw2)
                {
                    Pen p = new Pen(Color.LawnGreen);
                    int GrX = groupBox2.Location.X;
                    int GrY = groupBox2.Location.Y;
                    e.Graphics.DrawRectangle(p, new Rectangle(tbpassword2.Location.X - GrX - 1, tbpassword2.Location.Y - GrY - 1, tbpassword2.Width + 1, tbpassword2.Height + 1));
                }
            }
            else
            {
                tbpassword2.BorderStyle = BorderStyle.FixedSingle;
            }
            //XN
            if (focusXN)
            {
                if (tbxacnhan.Text.Trim() == "" || tbxacnhan.Text.Trim() == null)
                {
                    Pen p = new Pen(Color.Red);
                    int GrX = groupBox2.Location.X;
                    int GrY = groupBox2.Location.Y;
                    e.Graphics.DrawRectangle(p, new Rectangle(tbxacnhan.Location.X - GrX - 1, tbxacnhan.Location.Y - GrY - 1, tbxacnhan.Width + 1, tbxacnhan.Height + 1));
                }
                else if (isTextXN)
                {
                    Pen p = new Pen(Color.LawnGreen);
                    int GrX = groupBox2.Location.X;
                    int GrY = groupBox2.Location.Y;
                    e.Graphics.DrawRectangle(p, new Rectangle(tbxacnhan.Location.X - GrX - 1, tbxacnhan.Location.Y - GrY - 1, tbxacnhan.Width + 1, tbxacnhan.Height + 1));
                }
            }
            else
            {
                tbxacnhan.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        #region eventTextBox
        private void tbusername_Enter(object sender, EventArgs e)
        {
            focusUser = true;
            this.Refresh();
        }
        private void tbusername_Leave(object sender, EventArgs e)
        {
            focusUser = false;
            this.Refresh();
        }
        private void tbusername_TextChanged(object sender, EventArgs e)
        {
            isTextUser = true;
            this.Refresh();
        }
        private void tbpassword1_Enter(object sender, EventArgs e)
        {
            focusPw1 = true;
            this.Refresh();
        }
        private void tbpassword1_Leave(object sender, EventArgs e)
        {
            focusPw1 = false;
            this.Refresh();
        }
        private void tbpassword1_TextChanged(object sender, EventArgs e)
        {
            isTextPw1 = true;
            this.Refresh();
        }
        private void tbpassword2_Enter(object sender, EventArgs e)
        {
            focusPw2 = true;
            this.Refresh();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void tbpassword2_Leave(object sender, EventArgs e)
        {
            focusPw2 = false;
            this.Refresh();
        }
        private void tbpassword2_TextChanged(object sender, EventArgs e)
        {
            isTextPw2 = true;
            this.Refresh();
        }
        private void tbxacnhan_Enter(object sender, EventArgs e)
        {
            focusXN = true;
            this.Refresh();
        }
        private void tbxacnhan_Leave(object sender, EventArgs e)
        {
            focusXN = false;
            this.Refresh();
        }
        private void tbxacnhan_TextChanged(object sender, EventArgs e)
        {
            isTextXN = true;
            this.Refresh();
        }
        #endregion
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
