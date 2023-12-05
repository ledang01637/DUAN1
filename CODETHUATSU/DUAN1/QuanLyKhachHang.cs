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
        DataSet ds = new DataSet();
        public QuanLyKhachHang(String username)
        {
            InitializeComponent();
            tbusername.Text = username;
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
            using (DUAN1Entities db = new DUAN1Entities())
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
            using (DUAN1Entities db = new DUAN1Entities())
            {
                dataGridView1.Rows.Clear();

                db.khach_hang.ToList().ForEach(kh =>
                {
                    dataGridView1.Rows.Add(
                        kh.ma_kh,
                        kh.ten_kh,
                        kh.sdt
                   );
                }
                );
            }
        }
        //Lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            string maKH = tbmakhachhang.Text;
            string tenKH = tbtenkhachhang.Text;
            string sdt = tbsdt.Text;

            // Kiểm tra xem các trường thông tin đã được nhập đầy đủ
            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return;
            }

            // Thêm khách hàng vào cơ sở dữ liệu
            using (DUAN1Entities db = new DUAN1Entities())
            {
                khach_hang KH = new khach_hang();
                KH.ma_kh = maKH;
                KH.ten_kh = tenKH;
                KH.sdt = sdt;

                db.khach_hang.Add(KH);
                db.SaveChanges();
            }

            MessageBox.Show("Thêm khách hàng thành công");

            // Xóa nội dung trong TextBox sau khi lưu thành công
            tbmakhachhang.Text = "";
            tbtenkhachhang.Text = "";
            tbsdt.Text = "";

            updatedgv();
        }

        //sửa thông tin khách hàng
        private void btnsua_Click(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                khach_hang them = db.khach_hang
                    .Where(x => x.ma_kh == tbmakhachhang.Text)
                    .FirstOrDefault();

                if (them != null)
                {
                    them.ten_kh = tbtenkhachhang.Text;
                    them.sdt = tbsdt.Text;

                    db.SaveChanges();
                }
                MessageBox.Show("Sửa thành công");
            }
            updatedgv();
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
                using (DUAN1Entities db = new DUAN1Entities())
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

                using (DUAN1Entities db = new DUAN1Entities())
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
            using (DUAN1Entities db = new DUAN1Entities())
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
    }
}
