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
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        //Form
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                UpdateGV();
            }
        }

        private void UpdateGV()
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

        //Thêm 
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            tbmakhachhang.ReadOnly = false;
            tbtenkhachhang.ReadOnly = false;
            tbsdt.Enabled = true;
            tbtimkiem.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string maKH = tbmakhachhang.Text;
            string tenKH = tbtenkhachhang.Text;
            string sdt = tbsdt.Text;

            // Kiểm tra xem các trường thông tin đã được nhập đầy đủ
            if (string.IsNullOrEmpty(maKH) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
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

            MessageBox.Show("Thêm nhân viên thành công");

            // Xóa nội dung trong TextBox sau khi lưu thành công
            tbmakhachhang.Text = "";
            tbtenkhachhang.Text = "";
            tbsdt.Text = "";

            UpdateGV();
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

                    // You don't need to set them.ma_kh again; it's redundant.

                    db.SaveChanges();
                }
            }
            MessageBox.Show("Sửa thành công");
            UpdateGV();
            
        }
        //Xóa khách hàng
        private void btnxoa_Click(object sender, EventArgs e)
        {   
            if(tbmakhachhang.Text == null)
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
                UpdateGV();
            }
            
            
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
            tbmakhachhang.Text = "";
            tbtenkhachhang.Text = "";
            tbsdt.Text = "";
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;

            UpdateGV();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
        }
    }
}
