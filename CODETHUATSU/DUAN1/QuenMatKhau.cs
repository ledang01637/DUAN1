using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DUAN1
{
    public partial class QuenMatKhau : Form
    {
        readonly int code = GetCode.Code;
        bool focusUser, focusPw1, focusPw2, focusXN;
        bool isTextUser, isTextPw1, isTextPw2, isTextXN;
        public QuenMatKhau()
        {
            InitializeComponent();
            this.BackColor = Constant.greyColor;
            btnsubmit.BackColor = Constant.cyanColor;
            btnthoat.BackColor = Color.Transparent;
        }
        #region Mouse
        private void btnsubmit_MouseHover(object sender, EventArgs e)
        {
            btnsubmit.BackColor = Color.LightCyan;
        }

        private void btnsubmit_MouseMove(object sender, MouseEventArgs e)
        {
            btnsubmit.BackColor = Color.LightCyan;
        }

        private void btnsubmit_MouseLeave(object sender, EventArgs e)
        {
            btnsubmit.BackColor = Constant.cyanColor;
        }
        #endregion
        #region Btn
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (tbpassword1.Text.Trim().Equals(tbpassword2.Text.Trim()))
            {
                if (tbpassword2.Text.Trim().Length >= 5 && tbpassword1.Text.Trim().Length >= 5)
                {
                    using (DAXuongEntities dUAN1Entities = new DAXuongEntities())
                    {
                        //Mã hóa
                        Constant.ChangeDatabase(dUAN1Entities);
                        DBHandler dBHanler = new DBHandler();
                        String Hash = dBHanler.GetMD5(tbpassword1.Text);
                        dang_nhap dang_ = dUAN1Entities.dang_nhap.FirstOrDefault(a => a.nhan_vien.email.Trim().ToLower().Equals(GetCode.Email));
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
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                        this.Close();
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
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            LayCode qmk = new LayCode();
            qmk.ShowDialog();
            this.Close();
        }
        #endregion
        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            //User
            //if (focusUser)
            //{
            //    if (string.IsNullOrEmpty(tbemail.Text))
            //    {
            //        Pen p = new Pen(Color.Red);
            //        e.Graphics.DrawRectangle(p, new Rectangle(tbemail.Location.X - 1, tbemail.Location.Y - 1, tbemail.Width + 1, tbemail.Height + 1));
            //    }
            //    else if (isTextUser)
            //    {
            //        Pen p = new Pen(Color.LawnGreen);
            //        e.Graphics.DrawRectangle(p, new Rectangle(tbemail.Location.X - 1, tbemail.Location.Y - 1, tbemail.Width + 1, tbemail.Height + 1));
            //    }
            //}
            //else
            //{
            //    tbemail.BorderStyle = BorderStyle.FixedSingle;
            //}
            //Pw1
            if (focusPw1)
            {
                if (string.IsNullOrEmpty(tbpassword1.Text) || tbpassword1.Text.Length < 5)
                {
                    Pen p = new Pen(Color.Blue);
                    e.Graphics.DrawRectangle(p, new Rectangle(tbpassword1.Location.X  - 1, tbpassword1.Location.Y - 1, tbpassword1.Width + 1, tbpassword1.Height + 1));
                }
                else if (isTextPw1)
                {
                    Pen p = new Pen(Color.LawnGreen);
                    e.Graphics.DrawRectangle(p, new Rectangle(tbpassword1.Location.X  - 1, tbpassword1.Location.Y - 1, tbpassword1.Width + 1, tbpassword1.Height + 1));
                }
            }
            else
            {
                tbpassword1.BorderStyle = BorderStyle.FixedSingle;
            }
            //Pw2
            if (focusPw2)
            {
                if (string.IsNullOrEmpty(tbpassword2.Text) || tbpassword2.Text.Length < 5)
                {
                    Pen p = new Pen(Color.Blue);
                    e.Graphics.DrawRectangle(p, new Rectangle(tbpassword2.Location.X  - 1, tbpassword2.Location.Y - 1, tbpassword2.Width + 1, tbpassword2.Height + 1));
                }
                else if (isTextPw2)
                {
                    Pen p = new Pen(Color.LawnGreen);
                    e.Graphics.DrawRectangle(p, new Rectangle(tbpassword2.Location.X  - 1, tbpassword2.Location.Y - 1, tbpassword2.Width + 1, tbpassword2.Height + 1));
                }
            }
            else
            {
                tbpassword2.BorderStyle = BorderStyle.FixedSingle;
            }
            //XN
            //if (focusXN)
            //{
            //    if (string.IsNullOrEmpty(tbxacnhan.Text))
            //    {
            //        Pen p = new Pen(Color.Red);
            //        e.Graphics.DrawRectangle(p, new Rectangle(tbxacnhan.Location.X  - 1, tbxacnhan.Location.Y - 1, tbxacnhan.Width + 1, tbxacnhan.Height + 1));
            //    }
            //    else if (isTextXN)
            //    {
            //        Pen p = new Pen(Color.LawnGreen);
            //        e.Graphics.DrawRectangle(p, new Rectangle(tbxacnhan.Location.X  - 1, tbxacnhan.Location.Y - 1, tbxacnhan.Width + 1, tbxacnhan.Height + 1));
            //    }
            //}
            //else
            //{
            //    tbxacnhan.BorderStyle = BorderStyle.FixedSingle;
            //}
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
        
    }
}
