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
            tbusername.Text = username;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                updatedgv();
                tbmanhanvien.Enabled = false;
            }
        }

        private void updatedgv()
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                dataGridView1.Rows.Clear();
                db.nhan_vien.ToList().ForEach(kh =>
                {
                    dataGridView1.Rows.Add(
                        kh.ma_nv,
                        kh.ten_nv,
                        kh.sdt
                   );
                }
                );
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            tbmanhanvien.ReadOnly = false;
            tbtennhanvien.ReadOnly = false;
            tbsdt.Enabled = true;
            tbtimkiem.Enabled = true;

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
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    nhan_vien nganhduocchon = db.nhan_vien
                        .Where(x => x.ma_nv == tbmanhanvien.Text)
                        .FirstOrDefault();
                    them.ma_nv = nganhduocchon.ma_nv;
                    db.nhan_vien.Add(them);
                    db.SaveChanges();
                }
                updatedgv();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                nhan_vien them = db.nhan_vien
                    .Where(x => x.ma_nv == tbmanhanvien.Text)
                    .FirstOrDefault();
                them.ten_nv = tbtennhanvien.Text;
                them.sdt = tbsdt.Text;
                them.sdt = tbsdt.Text;
                nhan_vien thongtinkh = db.nhan_vien
                    .Where(x => x.ma_nv == tbmanhanvien.Text).FirstOrDefault();
                them.ma_nv = thongtinkh.ma_nv;
                db.SaveChanges();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                nhan_vien xoa = db.nhan_vien.Where(x => x.ma_nv == tbmanhanvien.Text).FirstOrDefault();
                db.nhan_vien.Remove(xoa);
                db.SaveChanges();
            }
            updatedgv();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbmanhanvien.Text = "";
            tbtennhanvien.Text = "";
            tbsdt.Text = "";
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;
        }

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
                    List<nhan_vien> listhd = db.nhan_vien.Where(x => x.ma_nv.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listhd.ToList().ForEach(hd =>
                    {
                        dataGridView1.Rows.Add(
                        hd.ma_nv,
                        hd.ten_nv,
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
    }
}
