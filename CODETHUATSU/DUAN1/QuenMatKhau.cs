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

namespace DUAN1
{
    public partial class QuenMatKhau : Form
    {
        int code = new Random().Next(10000,99999);
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
            string context = "Code của bạn là: " + code;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            if(tbemail.Text == null || tbemail.Text == "")
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                Regex regex = new Regex(strRegex);
                if (regex.IsMatch(tbemail.Text))
                {
                    mail.To.Add(tbemail.Text);
                    mail.Subject = "Code quên mật khẩu";
                    mail.Body = context;

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(from, pw);
                    smtpClient.EnableSsl = true;
                    smtpClient.Port = 587;
                    try
                    {
                        smtpClient.Send(mail);
                        MessageBox.Show("Email send Succesfull");
                    }
                    catch
                    {
                        MessageBox.Show("Email send Error", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
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
                        using (DUAN1Entities dUAN1Entities = new DUAN1Entities())
                        {
                            //Mã hóa
                            DBHanler dBHanler = new DBHanler();
                            String Hash = dBHanler.GetMD5(tbpassword1.Text);
                            dang_nhap dang_ = dUAN1Entities.dang_nhap.FirstOrDefault(a => a.tai_khoan.Equals(tbusername.Text.Trim()));
                            dang_.mat_khau = Hash;
                            try
                            {
                                dUAN1Entities.SaveChanges();
                            } catch (Exception excpt)
                            {
                                Console.WriteLine(excpt.Message);
                            }
                            MessageBox.Show("Cập nhật mật khẩu mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không khớp ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Code không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
