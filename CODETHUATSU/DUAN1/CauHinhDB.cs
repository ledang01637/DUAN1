using DUAN1.Properties;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace DUAN1
{
    public partial class CauHinhDB : Form
    {
        private bool viewPass = false;
        public CauHinhDB()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void lblCheckConn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIP.Text)
                || String.IsNullOrWhiteSpace(txtDBName.Text)
                || String.IsNullOrWhiteSpace(txtUsername.Text)
                || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Chưa nhập đủ thông tin kết nối",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            } else
            {
                String cs = "Data Source=" + txtIP.Text + ";"
                      + "Initial Catalog=" + txtDBName.Text + ";"
                      + "User id=" + txtUsername.Text + ";"
                      + "Password=" + txtPassword.Text + ";";
                try
                {
                    using (SqlConnection conn = new SqlConnection(cs))
                    {
                        conn.Open();
                        MessageBox.Show(
                            "Kết nối thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        conn.Close();
                        btnSaveConn.Enabled = true;
                    }
                } catch (Exception)
                {
                    MessageBox.Show(
                        "Kết nối thất bại",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            if (viewPass)
            {
                btnViewPass.Image = Resources.icons8_eyeclose_24;
                txtPassword.PasswordChar = '*';
            }
            else
            {
                btnViewPass.Image = Resources.icons8_eye_24;
                txtPassword.PasswordChar = '\0';
            }
            viewPass = !viewPass;
        }

        private void btnSaveConn_Click(object sender, EventArgs e)
        {
            String cs = "Data Source=" + txtIP.Text + ";"
                      + "Initial Catalog=" + txtDBName.Text + ";"
                      + "User id=" + txtUsername.Text + ";"
                      + "Password=" + txtPassword.Text + ";";
            using (StreamWriter outfile = new StreamWriter(Constant.connFilePath))
            {
                outfile.Write(cs);
                MessageBox.Show(
                    "Đã lưu kết nối",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
