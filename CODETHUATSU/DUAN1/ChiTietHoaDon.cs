﻿using System;
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
                    cthd.khohang_hanghoa.hang_hoa.ten,
                    cthd.so_luong,
                    cthd.thanh_tien
                    );
                }
                );

                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                btnhuy.Enabled = true;
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
                khohang_hanghoa khhh = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet.Equals(cbbmakhohangchitiet.Text));
                dataGridView1.Rows.Clear();
                db.chi_tiet_hoa_don.ToList().ForEach(cthd =>
                {
                    dataGridView1.Rows.Add(
                    cthd.macthd,
                    cthd.ma_hd,
                    cthd.khohang_hanghoa.hang_hoa.ten,
                    cthd.so_luong,
                    cthd.thanh_tien
                    );
                }
                );
                
            }
        }
        private void ThongKe()
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                khohang_hanghoa khhh = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet.Equals(cbbmakhohangchitiet.Text));
                if(khhh != null)
                {
                    khhh.so_luong -= int.Parse(tbsoluong.Text);
                    db.SaveChanges();
                }
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
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            tbmachitiethoadon.ReadOnly = true;
            cbbmahoadon.Enabled = true;
            cbbmakhohangchitiet.Enabled = true;
            tbthanhtien.ReadOnly = true;
            tbsoluong.ReadOnly = false;
        }
        //btn lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    chi_tiet_hoa_don cthd = new chi_tiet_hoa_don();
                    khohang_hanghoa khhh = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet.Equals(cbbmakhohangchitiet.Text));
                    hang_hoa hanghoa = db.hang_hoa.FirstOrDefault(x => x.ma_hang_hoa.Equals(khhh.ma_hang_hoa));

                    cthd.ma_hd = cbbmahoadon.Text;
                    cthd.makho_hangchitiet = cbbmakhohangchitiet.Text;
                    if (int.Parse(tbsoluong.Text) > 0)
                    {
                        if ((khhh.so_luong - int.Parse(tbsoluong.Text)) < 0)
                        {
                            MessageBox.Show("Số lượng phải bé hơn hoặc bằng số lượng trong kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            cthd.so_luong = int.Parse(tbsoluong.Text);
                            cthd.thanh_tien = cthd.so_luong * hanghoa.gia_ban;
                            db.chi_tiet_hoa_don.Add(cthd);
                            db.SaveChanges();
                            MessageBox.Show("Thêm thành công");
                            ThongKe();
                            UpdateDGV();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không được để trống");
            }
        }
        //btn xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maCTHD = int.Parse(tbmachitiethoadon.Text);
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    chi_tiet_hoa_don delete = db.chi_tiet_hoa_don.Where(x => x.macthd == maCTHD).FirstOrDefault();

                    db.chi_tiet_hoa_don.Remove(delete);
                    db.SaveChanges();
                }
                MessageBox.Show("Xóa thành công ");
                UpdateDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần xóa ");
            }
        }
        //btn sửa
        private void btnsua_Click(object sender, EventArgs e)
        {
            int maCTHD = int.Parse(tbmachitiethoadon.Text);
            using (DUAN1Entities db = new DUAN1Entities())
            {
                chi_tiet_hoa_don edit = db.chi_tiet_hoa_don.FirstOrDefault(x => x.macthd == maCTHD);
                khohang_hanghoa khhh = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet.Equals(cbbmakhohangchitiet.Text));
                hang_hoa hanghoa = db.hang_hoa.FirstOrDefault(x => x.ma_hang_hoa.Equals(khhh.ma_hang_hoa));
                if (edit != null)
                {
                    edit.macthd = int.Parse(tbmachitiethoadon.Text);
                    edit.ma_hd = cbbmahoadon.Text;
                    edit.makho_hangchitiet = cbbmakhohangchitiet.Text;
                    if(int.Parse(tbsoluong.Text) <= 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    edit.so_luong = int.Parse(tbsoluong.Text);
                    edit.thanh_tien = edit.so_luong * hanghoa.gia_ban;
                    db.SaveChanges();
                    ThongKe();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn");
                }

                UpdateDGV();
            }
        }
        // xem hiển thị
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];
            int MaCTHD = int.Parse(rowData.Cells[0].Value.ToString());
            using (DUAN1Entities db = new DUAN1Entities())
            {
                chi_tiet_hoa_don cthd = db.chi_tiet_hoa_don.Where(x => x.macthd == MaCTHD).FirstOrDefault();

                if (cthd != null)
                {
                    tbmachitiethoadon.Text = cthd.macthd.ToString();
                    cbbmahoadon.Text = cthd.ma_hd;
                    cbbmakhohangchitiet.Text = cthd.makho_hangchitiet;
                    tbsoluong.Text = cthd.so_luong.ToString();
                    tbthanhtien.Text = cthd.thanh_tien.ToString();
                }
                btnxoa.Enabled = true;
                btnsua.Enabled = true;
                btnhuy.Enabled = true;
                btnluu.Enabled = false;

                tbmachitiethoadon.ReadOnly = true;
                cbbmahoadon.Enabled = true;
                cbbmakhohangchitiet.Enabled = true;
                tbsoluong.ReadOnly = false;
                tbthanhtien.ReadOnly = true;
            }
        }
        //btn hủy
        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmachitiethoadon.ReadOnly = true;
            cbbmahoadon.Enabled = false;
            cbbmakhohangchitiet.Enabled = false;
            tbthanhtien.ReadOnly = true;
            tbsoluong.ReadOnly = true;

            tbmachitiethoadon.Text = " ";
            cbbmahoadon.Text = " ";
            cbbmakhohangchitiet.Text = " ";
            tbsoluong.Text = " ";
            tbthanhtien.Text = " ";
            tbtimkiem.Text = " ";
            UpdateDGV();

        }
        //btn tìm kiếm
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
                    List<chi_tiet_hoa_don> listhd = db.chi_tiet_hoa_don.Where(x => x.ma_hd.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listhd.ToList().ForEach(cthd =>
                    {
                        dataGridView1.Rows.Add(
                        cthd.macthd,
                        cthd.ma_hd,
                        cthd.makho_hangchitiet,
                        cthd.so_luong,
                        cthd.thanh_tien);
                    }
                    );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }




        //
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
