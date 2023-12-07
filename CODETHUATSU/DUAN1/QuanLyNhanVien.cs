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
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }


        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                dataGridView1.Rows.Clear();

                db.nhan_vien.ToList().ForEach(nv =>
                    dataGridView1.Rows.Add(
                        nv.ma_nv,
                        nv.ten_nv,
                        nv.sdt,
                        nv.tai_khoan_dangnhap
                   )
                );
            }


            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;

            tbcv.ReadOnly = true;
            tbmanhanvien.ReadOnly = true;
            tbtennhanvien.ReadOnly = true;
            tbsdt.Enabled = false;
        }

        private void UpdateGV()
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                dataGridView1.Rows.Clear();

                db.nhan_vien.ToList().ForEach(nv =>
                    dataGridView1.Rows.Add(
                        nv.ma_nv,
                        nv.ten_nv,
                        nv.sdt,
                        nv.tai_khoan_dangnhap
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

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (tbmanhanvien.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                nhan_vien them = new nhan_vien();
                them.ma_nv = tbmanhanvien.Text;
                them.ten_nv = tbtennhanvien.Text;
                them.sdt = tbsdt.Text;
                them.tai_khoan_dangnhap = tbcv.Text;
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    nhan_vien nv = db.nhan_vien
                        .Where(x => x.ma_nv == tbmanhanvien.Text)
                        .FirstOrDefault();

                    if (nv == null) // Check if the record doesn't exist
                    {
                        db.nhan_vien.Add(them);
                        db.SaveChanges();
                        UpdateGV();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại");
                    }
                }

            }
            UpdateGV();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                nhan_vien sua = db.nhan_vien
                    .Where(x => x.ma_nv == tbmanhanvien.Text)
                    .FirstOrDefault();

                if (sua != null)
                {
                    sua.ten_nv = tbtennhanvien.Text;
                    sua.sdt = tbsdt.Text;

                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công");

                    // Reset các TextBox sau khi sửa thành công
                    tbmanhanvien.Text = "";
                    tbtennhanvien.Text = "";
                    tbsdt.Text = "";
                    tbcv.Text = "";

                    UpdateGV();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbmanhanvien.Text))
            {
                MessageBox.Show("Nhập đúng mã nhân viên cần xóa");
            }
            else
            {
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    nhan_vien xoa = db.nhan_vien.Where(x => x.ma_nv == tbmanhanvien.Text).FirstOrDefault();
                    if (xoa != null)
                    {
                        db.nhan_vien.Remove(xoa);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công");

                        // Reset các TextBox sau khi xóa thành công
                        tbmanhanvien.Text = "";
                        tbtennhanvien.Text = "";
                        tbsdt.Text = "";

                        UpdateGV();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên có mã nhân viên đã nhập");
                    }
                }
            }
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

            UpdateGV();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbtimkiem.Text))
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!!");
                }
                else
                {
                    using (DUAN1Entities db = new DUAN1Entities())
                    {
                        khach_hang khachHang = db.khach_hang.FirstOrDefault(x => x.ma_kh == tbtimkiem.Text);

                        if (khachHang != null)
                        {
                            // Tìm thấy khách hàng, hiển thị thông tin trên DataGridView
                            dataGridView1.Rows.Clear();
                            dataGridView1.Rows.Add(khachHang.ma_kh, khachHang.ten_kh, khachHang.sdt);
                        }
                        else
                        {
                            // Không tìm thấy khách hàng
                            MessageBox.Show("Không tìm thấy khách hàng có mã đã nhập");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình tìm kiếm");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];

            String Manv = rowData.Cells[0].Value.ToString();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                nhan_vien nv = db.nhan_vien.Where(x => x.ma_nv == Manv).FirstOrDefault();
                tbmanhanvien.Text = nv.ma_nv;
                tbtennhanvien.Text = nv.ten_nv;
                tbsdt.Text = nv.sdt;
                tbcv.Text = nv.tai_khoan_dangnhap;
            }

            btnthem.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            tbmanhanvien.ReadOnly = true;

        }
    }
}
