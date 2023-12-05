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
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            tbmakhachhang.ReadOnly = false;
            tbtenkhachhang.ReadOnly = false;
            tbsdt.Enabled = true;
            tbtimkiem.Enabled = true;
        }
        //Form
        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                updatedgv();
                tbmakhachhang.Enabled = false;
            }
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
            if (tbmakhachhang.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                khach_hang them = new khach_hang();
                them.ma_kh = tbmakhachhang.Text;
                them.ten_kh = tbtenkhachhang.Text;
                them.sdt = tbsdt.Text;
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    khach_hang nganhduocchon = db.khach_hang
                        .Where(x => x.ma_kh == tbmakhachhang.Text)
                        .FirstOrDefault();
                    them.ma_kh = nganhduocchon.ma_kh;
                    db.khach_hang.Add(them);
                    db.SaveChanges();
                }
                updatedgv();
            }
        }
        //sửa thông tin khách hàng
        private void btnsua_Click(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                khach_hang them = db.khach_hang
                    .Where(x => x.ma_kh == tbmakhachhang.Text)
                    .FirstOrDefault();
                them.ten_kh = tbtenkhachhang.Text;
                them.sdt = tbsdt.Text;
                them.sdt = tbsdt.Text;
                khach_hang thongtinkh = db.khach_hang
                    .Where(x => x.ma_kh == tbmakhachhang.Text).FirstOrDefault();
                them.ma_kh = thongtinkh.ma_kh;
                db.SaveChanges();
            }
        }
        //Xóa khách hàng
        private void btnxoa_Click(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                khach_hang xoa = db.khach_hang.Where(x => x.ma_kh == tbmakhachhang.Text).FirstOrDefault();
                db.khach_hang.Remove(xoa);
                db.SaveChanges();
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
            tbmakhachhang.Text = "";
            tbtenkhachhang.Text = "";
            tbsdt.Text = "";
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }
    }
}
