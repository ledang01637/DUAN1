using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;


namespace DUAN1
{
    public partial class LayCode : Form
    {
        DateTime tgGui;
        public LayCode()
        {
            InitializeComponent();
            this.BackColor = Constant.greyColor;
            btngui.BackColor = Constant.cyanColor;
            btnXacNhanCode.BackColor = Color.LightGray;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btngui_Click(object sender, EventArgs e)
        {
            SendEmail();
        }
        protected void SendEmail()
        {
            GetCode.Code = new Random().Next(10000, 99999);
            GetCode.Email = tbemail.Text.ToLower();
            string from = "danglhpc06254@fpt.edu.vn";
            string pw = "nkpbolujrxlizknl";
            string context = "CodeThuatSu gửi quý khách, " +
                "\n\tCó phải bạn đã quên mật khẩu?" +
                "\n\tĐây là mã OTP quên mật khẩu của bạn: " + GetCode.Code +
                "\n\tVui lòng không cung cấp mã này cho bất kì ai!" +
                "\n\tNếu bạn không muốn thay đổi mật khẩu, vui lòng bỏ qua thông báo này." +
                "\n\nCảm ơn.";
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            if (getEmail(tbemail.Text.ToLower().Trim()))
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
                        tgGui = DateTime.Now;
                        tbxacnhan.Enabled = true;
                        btnXacNhanCode.Enabled = true;
                        btnXacNhanCode.BackColor = Constant.cyanColor;
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
        public bool getEmail(string email)
        {
            using (DAXuongEntities dUAN1Entities = new DAXuongEntities())
            {
                dang_nhap dang_ = dUAN1Entities.dang_nhap.FirstOrDefault(a => a.nhan_vien.email.Equals(email));
                if (dang_ != null)
                {
                    return true;
                }
                return false;
            }
        }
        private void btngui_MouseHover(object sender, EventArgs e)
        {
            btngui.BackColor = Color.LightCyan;
        }
        private void btngui_MouseLeave(object sender, EventArgs e)
        {
            btngui.BackColor = Constant.cyanColor;
        }

        private void btngui_MouseMove(object sender, MouseEventArgs e)
        {
            btngui.BackColor = Color.LightCyan;
        }

        private void btnXacNhanCode_Click(object sender, EventArgs e)
        {
            DateTime tgNhap = DateTime.Now;
            double tg = (tgNhap - tgGui).TotalSeconds;
            if (tg > 30)
            {
                MessageBox.Show("Thời gian quá hạn", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int xacNhan;
                if (int.TryParse(tbxacnhan.Text, out xacNhan))
                {
                    if (xacNhan == GetCode.Code)
                    {
                        QuenMatKhau qmk = new QuenMatKhau();
                        this.Hide();
                        qmk.ShowDialog();
                        this.Close();
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
        }
    }
}
