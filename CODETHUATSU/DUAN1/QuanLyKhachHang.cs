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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang(String username)
        {
            InitializeComponent();
            tbusername.Text = username;
            tbtimkiem.KeyDown += tbtimkiem_KeyDown;
        }
        //Thêm 
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;


            tbmakhachhang.ReadOnly = false;
            tbmakhachhang.Enabled = true;
            tbtenkhachhang.ReadOnly = false;
            tbsdt.ReadOnly = false;
            tbsdt.Enabled = true;
        }
        //Form
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                updatedgv();
                tbmakhachhang.Enabled = false;
            }

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;


            tbmakhachhang.ReadOnly = true;
            tbtenkhachhang.ReadOnly = true;
            tbsdt.Enabled = false;
        }
        //Update
        private void updatedgv()
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                dataGridView1.Rows.Clear();

                db.khach_hang.ToList().ForEach(kh =>

                    dataGridView1.Rows.Add(
                        kh.ma_kh,
                        kh.ten_kh,
                        kh.sdt
                   )

                );
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
            string maKH = tbmakhachhang.Text;
            string tenKH = tbtenkhachhang.Text;
            string sdt = tbsdt.Text;

            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return false;
            }

            if (sdt.Length != 10 || !IsValidPhoneNumber(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại có độ dài 10 chữ số và chỉ chứa các ký tự số.");
                return false;
            }

            return true;
        }

        //Lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string maKH = tbmakhachhang.Text;
                string tenKH = tbtenkhachhang.Text;
                string sdt = tbsdt.Text;

                using (DAXuongEntities db = new DAXuongEntities())
                {
                    khach_hang KH = new khach_hang();
                    KH.ma_kh = maKH;
                    KH.ten_kh = tenKH;
                    KH.sdt = sdt;

                    db.khach_hang.Add(KH);
                    db.SaveChanges();
                }

                MessageBox.Show("Thêm khách hàng thành công");

                tbmakhachhang.Text = "";
                tbtenkhachhang.Text = "";
                tbsdt.Text = "";

                updatedgv();
            }
        }

        //sửa thông tin khách hàng
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string maNV = tbmakhachhang.Text;
                string tenNV = tbtenkhachhang.Text;
                string sdt = tbsdt.Text;
               

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
        //Xóa khách hàng
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tbmakhachhang.Text == null)
            {
                MessageBox.Show("Nhập đúng mã khách hàng cần xóa");
            }
            else
            {
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    khach_hang xoa = db.khach_hang.Where(x => x.ma_kh == tbmakhachhang.Text).FirstOrDefault();
                    db.khach_hang.Remove(xoa);
                    db.SaveChanges();
                }
                MessageBox.Show("Xóa thành công");
            }
            updatedgv();
        }
        //Tìm kiếm khách hàng
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
                    List<khach_hang> listhd = db.khach_hang.Where(x => x.ma_kh.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listhd.ToList().ForEach(hd =>
                    {
                        dataGridView1.Rows.Add(
                        hd.ma_kh,
                        hd.ten_kh,
                        hd.sdt
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnthem.Enabled = true;


            tbmakhachhang.ReadOnly = true;
            tbtenkhachhang.ReadOnly = true;
            tbsdt.Enabled = false;

            tbmakhachhang.Text = "";
            tbtenkhachhang.Text = "";
            tbsdt.Text = "";


            updatedgv();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];

            String MaKH = rowData.Cells[0].Value.ToString();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                khach_hang kh = db.khach_hang.Where(x => x.ma_kh == MaKH).FirstOrDefault();
                tbmakhachhang.Text = kh.ma_kh;
                tbtenkhachhang.Text = kh.ten_kh;
                tbsdt.Text = kh.sdt;
            }
            btnthem.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;

            tbmakhachhang.ReadOnly = true;
            tbtenkhachhang.ReadOnly = false;
            tbmakhachhang.Enabled = true;
            tbsdt.ReadOnly = false;
            tbsdt.Enabled = true;
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
            QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa(tbusername.Text);
            quanLyHangHoa.ShowDialog();
            this.Close();
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHangHangHoa khhh = new KhoHangHangHoa(tbusername.Text);
            khhh.ShowDialog();
            this.Close();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon qlhd = new QuanLyHoaDon(tbusername.Text);
            qlhd.ShowDialog();
            this.Close();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien qlnv = new QuanLyNhanVien(tbusername.Text);
            qlnv.ShowDialog();
            this.Close();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang qlkh = new QuanLyKhachHang(tbusername.Text);
            qlkh.ShowDialog();
            this.Close();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe tk = new ThongKe(tbusername.Text);
            tk.ShowDialog();
            this.Close();
        }

        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien tinNhanVien = new ThongTinNhanVien(tbusername.Text);
            this.Hide();
            tinNhanVien.ShowDialog();
            this.Close();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon tinNhanVien = new ChiTietHoaDon(tbusername.Text);
            this.Hide();
            tinNhanVien.ShowDialog();
            this.Close();
        }
    }
}
