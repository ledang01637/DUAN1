using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DUAN1
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien(String username)
        {
            InitializeComponent();
            usernamenv.Text = username;
            tbtimkiem.KeyDown += tbtimkiem_KeyDown;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                updatedgv();
                tbmanhanvien.Enabled = false;
            }
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;

            tbcv.ReadOnly = true;
            tbmanhanvien.ReadOnly = true;
            tbtennhanvien.ReadOnly = true;
            tbsdt.Enabled = false;
        }

        private void updatedgv()
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                dataGridView1.Rows.Clear();

                db.nhan_vien.ToList().ForEach(nv =>
                    dataGridView1.Rows.Add(
                        nv.ma_nv,
                        nv.ten_nv,
                        nv.sdt,
                        nv.email
                   )
                );
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;

            tbcv.ReadOnly = false;
            tbmanhanvien.ReadOnly = false;
            tbtennhanvien.ReadOnly = false;
            tbsdt.Enabled = true;
            tbmanhanvien.Enabled = true;
        }

        

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (ValidateFields())
            {
                string maNV = tbmanhanvien.Text;
                string tenNV = tbtennhanvien.Text;
                string sdt = tbsdt.Text;
                string email = tbcv.Text;

                using (DAXuongEntities db = new DAXuongEntities())
                {
                    nhan_vien nv = db.nhan_vien
                        .Where(x => x.ma_nv == maNV)
                        .FirstOrDefault();

                    if (nv == null) // Check if the record doesn't exist
                    {
                        nhan_vien them = new nhan_vien();
                        them.ma_nv = maNV;
                        them.ten_nv = tenNV;
                        them.sdt = sdt;
                        them.email = email;

                        db.nhan_vien.Add(them);
                        db.SaveChanges();
                        updatedgv();

                        MessageBox.Show("Thêm nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                    }
                }

                tbmanhanvien.Text = "";
                tbtennhanvien.Text = "";
                tbsdt.Text = "";
                tbcv.Text = "";

                updatedgv();
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra số điện thoại theo các quy tắc hợp lệ
            // Ví dụ: Độ dài phải là 10 chữ số, chỉ chứa các ký tự số, vv.
            // Bạn có thể tùy chỉnh quy tắc theo yêu cầu của mình.

            // Xóa khoảng trắng và dấu gạch ngang trong số điện thoại
            string cleanedNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

            // Kiểm tra độ dài số điện thoại (ví dụ: 10 chữ số)
            if (cleanedNumber.Length != 10)
            {
                return false;
            }

            // Kiểm tra xem tất cả các ký tự là số
            foreach (char c in cleanedNumber)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        private bool ValidateFields()
        {
            string maNV = tbmanhanvien.Text;
            string tenNV = tbtennhanvien.Text;
            string sdt = tbsdt.Text;
            string email = tbcv.Text;

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
                return false;
            }

            if (!IsValidPhoneNumber(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            if (!IsValidPhoneNumber(sdt) & !IsValidEmail(email))
            {
                MessageBox.Show("Email và số điện thoại không hợp lệ");
                return false;
            }

            return true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(ValidateFields())
    {
                string maNV = tbmanhanvien.Text;
                string tenNV = tbtennhanvien.Text;
                string sdt = tbsdt.Text;
                string email = tbcv.Text;

                using (DAXuongEntities db = new DAXuongEntities())
                {
                    nhan_vien them = db.nhan_vien
                        .Where(x => x.ma_nv == maNV)
                        .FirstOrDefault();

                    if (them != null)
                    {
                        them.ma_nv = maNV;
                        them.ten_nv = tenNV;
                        them.sdt = sdt;
                        them.email = email;

                        db.SaveChanges();

                        MessageBox.Show("Sửa thành công");
                        updatedgv();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên với mã nhân viên này");
                    }
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                nhan_vien xoa = db.nhan_vien.Where(x => x.ma_nv.Equals(tbmanhanvien.Text)).FirstOrDefault();
                //dang_nhap xoa2 = db.dang_nhap.Where(x => x.ma_nv.Equals(xoa.ma_nv)).FirstOrDefault();
                //db.dang_nhap.Remove(xoa2);
                db.nhan_vien.Remove(xoa);
                db.SaveChanges();

                MessageBox.Show("Xóa thành công");
            }
            updatedgv();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnthem.Enabled = true;

            tbcv.ReadOnly = true;
            tbmanhanvien.ReadOnly = true;
            tbtennhanvien.ReadOnly = true;
            tbsdt.Enabled = false;

            tbmanhanvien.Text = "";
            tbtennhanvien.Text = "";
            tbsdt.Text = "";
            tbcv.Text = " ";

            updatedgv();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbtimkiem.Text.Equals(""))
                {
                    tbtimkiem.Text = "";
                }

                using (DAXuongEntities db = new DAXuongEntities())
                {
                    List<nhan_vien> listhd = db.nhan_vien.Where(x => x.ma_nv.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listhd.ToList().ForEach(hd =>
                    {
                        dataGridView1.Rows.Add(
                        hd.ma_nv,
                        hd.ten_nv,
                        hd.sdt,
                        hd.email
                       );
                    }
                    );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
           
        }

        private void tbtimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btntimkiem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];

            String Manv = rowData.Cells[0].Value.ToString();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                nhan_vien nv = db.nhan_vien.Where(x => x.ma_nv == Manv).FirstOrDefault();
                tbmanhanvien.Text = nv.ma_nv;
                tbtennhanvien.Text = nv.ten_nv;
                tbsdt.Text = nv.sdt;
                tbcv.Text = nv.email;
            }

            btnthem.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            tbmanhanvien.ReadOnly = true;

        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            //Nút thoát ra ngoài form Đăng nhập
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }
        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa(usernamenv.Text);
            quanLyHangHoa.ShowDialog();
            this.Close();
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHangHangHoa khhh = new KhoHangHangHoa(usernamenv.Text);
            khhh.ShowDialog();
            this.Close();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon qlhd = new QuanLyHoaDon(usernamenv.Text);
            qlhd.ShowDialog();
            this.Close();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien qlnv = new QuanLyNhanVien(usernamenv.Text);
            qlnv.ShowDialog();
            this.Close();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang qlkh = new QuanLyKhachHang(usernamenv.Text);
            qlkh.ShowDialog();
            this.Close();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe tk = new ThongKe(usernamenv.Text);
            tk.ShowDialog();
            this.Close();
        }

        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien tinNhanVien = new ThongTinNhanVien(usernamenv.Text);
            this.Hide();
            tinNhanVien.ShowDialog();
            this.Close();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon tinNhanVien = new ChiTietHoaDon(usernamenv.Text);
            this.Hide();
            tinNhanVien.ShowDialog();
            this.Close();
        }

        private void lbmanhanvien_Click(object sender, EventArgs e)
        {

        }

        private void tbmanhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
