using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1
{
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon(String username)
        {
            InitializeComponent();
            tbusername.Text = username;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {

                //mã háo đơn
                cbbmahoadon.Items.Clear();
                db.hoa_don.ToList().ForEach(row => cbbmahoadon.Items.Add(row.ma_hd));
                //mã chi tiết kho hàng hàng hóa
                cbbmakhohangchitiet.Items.Clear();
                db.khohang_hanghoa.ToList().ForEach(row => cbbmakhohangchitiet.Items.Add(row.makho_hangchitiet));

                dataGridView1.Rows.Clear();

                db.chi_tiet_hoa_don.ToList().ForEach(cthd =>
                {
                    dataGridView1.Rows.Add(
                    cthd.macthd,
                    cthd.ma_hd,
                    cthd.makho_hangchitiet,
                    cthd.so_luong,
                    cthd.thanh_tien
                    );
                }
                );

                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                btnhuy.Enabled = false;
                btnluu.Enabled = false;

                tbmachitiethoadon.ReadOnly = true;
                cbbmahoadon.Enabled = false;
                cbbmakhohangchitiet.Enabled = false;
                tbthanhtien.ReadOnly = true;
                tbsoluong.ReadOnly = true;

            }
        }
        private void UpdateDGV()
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {

                //mã háo đơn
                cbbmahoadon.Items.Clear();
                db.hoa_don.ToList().ForEach(row => cbbmahoadon.Items.Add(row.ma_hd));
                //mã chi tiết kho hàng hàng hóa
                cbbmakhohangchitiet.Items.Clear();
                db.khohang_hanghoa.ToList().ForEach(row => cbbmakhohangchitiet.Items.Add(row.makho_hangchitiet));

                dataGridView1.Rows.Clear();

                db.chi_tiet_hoa_don.ToList().ForEach(cthd =>
                {
                    dataGridView1.Rows.Add(
                    cthd.macthd,
                    cthd.ma_hd,
                    cthd.makho_hangchitiet,
                    cthd.so_luong,
                    cthd.thanh_tien
                    );
                }
                );
            }
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon hd = new QuanLyHoaDon(tbusername.Text);
            hd.ShowDialog();
            this.Close();
        }
        //btn thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = true;

            tbmachitiethoadon.ReadOnly = true;
            cbbmahoadon.Enabled = true;
            cbbmakhohangchitiet.Enabled = true;
            tbthanhtien.ReadOnly = true;
            tbsoluong.ReadOnly = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //try
            //{
            using (DUAN1Entities db = new DUAN1Entities())
            {
                khohang_hanghoa khhh = new khohang_hanghoa();
                chi_tiet_hoa_don cthd = new chi_tiet_hoa_don();

                chi_tiet_hoa_don cthoadon = db.chi_tiet_hoa_don.FirstOrDefault(x => x.makho_hangchitiet.Equals(khhh.makho_hangchitiet));
                hang_hoa hanghoa = db.hang_hoa.FirstOrDefault(x => x.ma_hang_hoa.Equals(khhh.ma_hang_hoa));


                cthd.ma_hd = cbbmahoadon.Text;
                cthd.makho_hangchitiet = cbbmakhohangchitiet.Text;
                cthd.so_luong = int.Parse(tbsoluong.Text);
                cthd.thanh_tien = cthd.so_luong * khhh.hang_hoa.gia_ban;

                db.chi_tiet_hoa_don.Add(cthd);
                db.SaveChanges();

                MessageBox.Show("Thêm thành công");
                UpdateDGV();
            }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Không được để trống");
            //}
        }
    }
}
