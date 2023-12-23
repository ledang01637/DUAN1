﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DUAN1
{
    public partial class ChiTietHangHoa : Form
    {
        List<chitiet_hanghoa> dsChiTietHH;
        String imagePath = "";
        public ChiTietHangHoa()
        {
            InitializeComponent();
            //tbusername.Text = username;
        }

        private void ChiTietHangHoa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            using (DAXuongEntities db = new DAXuongEntities())
            {
                List<chitiet_hanghoa> cthh = db.chitiet_hanghoa.ToList();
                foreach(var item in cthh)
                {
                    cbbTenHang.Items.Add(item.hang_hoa.ten);
                }
            }

            btnluu.Enabled = false;

            cbbTenHang.Enabled = false;
            tbMau.ReadOnly = true;
            tbSize.ReadOnly = true;
            tbGiaban.ReadOnly = true;
            tbGianhap.ReadOnly = true;
            tbSL.ReadOnly = true;

            UpdateDGV();
        }

        //Cập nhật  DGV
        private void UpdateDGV()
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                List<chitiet_hanghoa> cthh = db.chitiet_hanghoa.ToList();
                cbbTenHang.Items.Clear();
                foreach (var item in cthh)
                {
                    cbbTenHang.Items.Add(item.hang_hoa.ten);
                }
            }
            dataGridView1.Rows.Clear();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                var cthh = db.chitiet_hanghoa.ToList();
                
                dsChiTietHH = DBHandler.getListChiTietHangHoa();
                dataGridView1.Rows.Clear();
                cthh.ForEach(row => dataGridView1.Rows.Add(
                    row.id,
                    row.ma_hang_hoa,
                    row.size,
                    row.mau_sac,
                    row.gia_nhap,
                    row.gia_ban,
                    row.hinh,
                    row.soluong
                ));
                dataGridView1.Update();
            }
        }

        // DataGridView lấy thông tin khi click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = (sender as DataGridView).CurrentCell;
            var row = dataGridView1.Rows[cell.RowIndex];

            tbID.Text = row.Cells[0].Value?.ToString();
            tbSize.Text = row.Cells[2].Value?.ToString();
            tbMau.Text = row.Cells[3].Value?.ToString();
            tbGianhap.Text = row.Cells[4].Value?.ToString();
            tbGiaban.Text = row.Cells[5].Value?.ToString();
            tbSL.Text = row.Cells[7].Value?.ToString();

            var MaHH = row.Cells[1].Value?.ToString();
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            chitiet_hanghoa selectedSP = dsChiTietHH[selectedRowIndex];

            using (DAXuongEntities db = new DAXuongEntities())
            {
                hang_hoa hh = db.hang_hoa.FirstOrDefault(a => a.ma_hang_hoa.Equals(MaHH));
                cbbTenHang.Text = hh.ten;
            }
            if (!String.IsNullOrEmpty(selectedSP.hinh))
            {
                ptbHinh.Image = Image.FromFile(@"" + selectedSP.hinh);
            }
            else
            {
                ptbHinh.Image = null;
                imagePath = "";
            }
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            cbbTenHang.Enabled = true;
            btnluu.Enabled = false;

            cbbTenHang.Enabled = true;
            tbMau.Enabled = true;
            tbSize.Enabled = true;
            tbSL.Enabled = true;
            tbGianhap.ReadOnly = false;
            tbGiaban.ReadOnly = false;
            tbGiaban.Enabled = true;
            tbID.ReadOnly = true;

        }

        // Chức năng thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnhuy.Enabled = true;

            cbbTenHang.Enabled = true;
            tbMau.ReadOnly = false;
            tbSize.ReadOnly = false;
            tbGiaban.ReadOnly = false;
            tbGianhap.ReadOnly = false;
            tbSL.ReadOnly = false;
            UpdateDGV();
        }

        // Chức năng luu
        private void btnluu_Click(object sender, EventArgs e)
        {
            int GiaNhap = 0;
            int GiaBan = 0;
            int SL = 0;
            if (int.TryParse(tbGianhap.Text, out GiaNhap)
                && int.TryParse(tbGiaban.Text, out GiaBan) && int.TryParse(tbSL.Text, out SL))
            {
                using(DAXuongEntities db = new DAXuongEntities())
                {
                    chitiet_hanghoa spCTHH = new chitiet_hanghoa();
                    hang_hoa hh = db.hang_hoa.FirstOrDefault(a => a.ten.Equals(cbbTenHang.Text));
                    spCTHH.mau_sac = tbMau.Text;
                    spCTHH.size = tbSize.Text;
                    spCTHH.gia_nhap = GiaNhap;
                    spCTHH.gia_ban = GiaBan;
                    spCTHH.soluong = SL;
                    spCTHH.ma_hang_hoa = hh.ma_hang_hoa;
                    if (ptbHinh != null && ptbHinh.Image != null)
                    {
                        spCTHH.hinh = imagePath;
                    }
                    if (DBHandler.addChiTietHangHoa(spCTHH))
                    {
                        MessageBox.Show("Đã thêm sản phẩm");
                        this.UpdateDGV();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Thêm mới thất bại",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }  
            }
            else
            {
                MessageBox.Show(
                    "Chưa nhập đúng thông tin",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //Chức năng xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            
        }

        // Chức năng hủy reload lại form
        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            cbbTenHang.Text = "";
            tbMau.Text = "";
            tbSize.Text = "";
            tbSL.Text = "";
            tbGianhap.Text = "";
            tbGiaban.Text = "";


            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;

            cbbTenHang.Enabled = false;
            tbMau.Enabled = false;
            tbSize.Enabled = false;
            tbSL.Enabled = false;
            tbGianhap.ReadOnly = true;
            tbGiaban.Enabled = false;
            tbID.ReadOnly = true;
        }

        // Chức năng sửa
        private void btnsua_Click(object sender, EventArgs e)
        {
            int GiaNhap = 0;
            int GiaBan = 0;
            int SL = 0;
            if (int.TryParse(tbGianhap.Text, out GiaNhap)
                && int.TryParse(tbGiaban.Text, out GiaBan) && int.TryParse(tbSL.Text, out SL))
            {
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    hang_hoa hh = db.hang_hoa.FirstOrDefault(a => a.ten.Equals(cbbTenHang.Text));
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    chitiet_hanghoa selectedSP = dsChiTietHH[selectedRowIndex];
                    selectedSP.mau_sac = tbMau.Text;
                    selectedSP.size = tbSize.Text;
                    selectedSP.gia_nhap = GiaNhap;
                    selectedSP.gia_ban = GiaBan;
                    selectedSP.soluong = SL;
                    selectedSP.ma_hang_hoa = hh.ma_hang_hoa;
                    if (ptbHinh != null && ptbHinh.Image != null)
                    {
                        selectedSP.hinh = imagePath;
                    }
                    if (DBHandler.updateChiTietHangHoa(selectedSP))
                    {
                        MessageBox.Show("Đã cập nhật sản phẩm");
                        this.UpdateDGV();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Cập nhật thất bại",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Chưa nhập đúng thông tin",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Chức năng tìm kiếm theo mã
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
                    List<chitiet_hanghoa> listsv = db.chitiet_hanghoa.Where(x => x.ma_hang_hoa.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listsv.ToList().ForEach(row =>
                    {
                        dataGridView1.Rows.Add(
                        row.id,
                        row.ma_hang_hoa,
                        row.size,
                        row.mau_sac,
                        row.gia_nhap,
                        row.gia_ban,
                        row.hinh,
                        row.soluong
                    );
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }

        //btn hóa đơn
        //private void btnhoadon_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyHoaDon form = new QuanLyHoaDon(tbusername.Text);
        //    form.ShowDialog();
        //    this.Close();
        //}

        ////btn thoát
        //private void btnthoat_Click(object sender, EventArgs e)
        //{
        //    //Nút thoát ra ngoài form Đăng nhập
        //    this.Hide();
        //    Login form = new Login();
        //    form.ShowDialog();
        //    this.Close();
        //}

        //btn hàng hóa
        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHangHoa quanLyHangHoa = new QuanLyHangHoa();
            quanLyHangHoa.ShowDialog();
            this.Close();
        }

        //btn kho hàng
        private void btnkhohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHangHoa khhh = new ChiTietHangHoa();
            khhh.ShowDialog();
            this.Close();
        }

        ////btn nhân viên
        //private void btnnhanvien_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyNhanVien qlnv = new QuanLyNhanVien(tbusername.Text);
        //    qlnv.ShowDialog();
        //    this.Close();
        //}

        ////btn nhân viên
        //private void btnkhachhang_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    QuanLyKhachHang qlkh = new QuanLyKhachHang(tbusername.Text);
        //    qlkh.ShowDialog();
        //    this.Close();
        //}

        ////btn thống kê
        //private void btnthongke_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ThongKe tk = new ThongKe(tbusername.Text);
        //    tk.ShowDialog();
        //    this.Close();
        //}

        ////btn thông tin nhân viên
        //private void btnthongtinnv_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ThongTinNhanVien tk = new ThongTinNhanVien(tbusername.Text);
        //    tk.ShowDialog();
        //    this.Close();
        //}

        //private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    ChiTietHoaDon tk = new ChiTietHoaDon(tbusername.Text);
        //    tk.ShowDialog();
        //    this.Close();
        //}

        private void ptbHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "e:\\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                ptbHinh.Image = Image.FromFile(@"" + imagePath);
            }
        }
    }
}
