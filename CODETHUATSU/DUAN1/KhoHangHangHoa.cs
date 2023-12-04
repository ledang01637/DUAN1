using System;
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
    public partial class KhoHangHangHoa : Form
    {
        public KhoHangHangHoa()
        {
            InitializeComponent();
        }

        private void QuanLyKhoHang_Load(object sender, EventArgs e)
        {
            dtpngaynhapkho.Format = DateTimePickerFormat.Short;
            dtpngayxuatkho.Format = DateTimePickerFormat.Short;
            dtpngaynhapkho.Value = DateTime.Today;
            dtpngayxuatkho.Value = DateTime.Today;

            using (DUAN1Entities db = new DUAN1Entities())
            {
                cbbdiachi.Items.Clear();
                db.kho_hang.ToList().ForEach(row => cbbdiachi.Items.Add(row.dia_chi));

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                db.khohang_hanghoa.ToList().ForEach(khhh =>
                {
                    dataGridView1.Rows.Add(
                    khhh.kho_hang.ma_kho_hang,
                    khhh.ma_hang_hoa,
                    DateTime.Parse(khhh.ngay_nhap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    DateTime.Parse(khhh.ngay_xuat.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    khhh.so_luong
                    );
                }
                );
                db.kho_hang.ToList().ForEach(kh =>
                {
                    dataGridView2.Rows.Add(
                    kh.ma_kho_hang,
                    kh.dia_chi
                    );
                }
                );

                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                btnhuy.Enabled = false;
                btnluu.Enabled = false;

                tbmakhohang.ReadOnly = true;
                tbmahanghoa.ReadOnly = true;
                dtpngaynhapkho.Enabled = false;
                dtpngayxuatkho.Enabled = false;
                tbsoluong.ReadOnly = true;
                cbbdiachi.Enabled = false;
                tbmakh.ReadOnly = true;


            }
        }

        // Cập nhật  DGV
        private void UpdateDGV()
        {
            dataGridView1.Rows.Clear();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                cbbdiachi.Items.Clear();
                db.kho_hang.ToList().ForEach(row => cbbdiachi.Items.Add(row.dia_chi));

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                db.khohang_hanghoa.ToList().ForEach(khhh =>
                {
                    dataGridView1.Rows.Add(
                    khhh.kho_hang.ma_kho_hang,
                    khhh.ma_hang_hoa,
                    DateTime.Parse(khhh.ngay_nhap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    DateTime.Parse(khhh.ngay_xuat.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    khhh.so_luong,
                    khhh.kho_hang.dia_chi
                    );
                }
                );
                db.kho_hang.ToList().ForEach(kh =>
                {
                    dataGridView2.Rows.Add(
                    kh.ma_kho_hang,
                    kh.dia_chi
                    );
                }
                );
            }


        }

        // DataGridView lấy thông tin khi click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];

            String MaSP = rowData.Cells[0].Value.ToString();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                khohang_hanghoa sv = db.khohang_hanghoa.Where(x => x.ma_kho_hang == MaSP).FirstOrDefault();
                tbmakhohang.Text = sv.ma_kho_hang;
                tbmahanghoa.Text = sv.ma_hang_hoa;
                dtpngaynhapkho.Text = sv.ngay_nhap.ToString();
                dtpngayxuatkho.Text = sv.ngay_xuat.ToString();
                tbsoluong.Text = sv.so_luong.ToString();
            }

            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmakhohang.ReadOnly = true;
            tbmahanghoa.ReadOnly = false;
            dtpngaynhapkho.Enabled = true;
            dtpngayxuatkho.Enabled = true;
            tbsoluong.ReadOnly = false;
            cbbdiachi.Enabled = true;
            tbmakh.ReadOnly = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView2.SelectedCells[0].RowIndex;
            var rowData = dataGridView2.Rows[row];

            String MaKH = rowData.Cells[0].Value.ToString();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                kho_hang sv = db.kho_hang.Where(x => x.ma_kho_hang == MaKH).FirstOrDefault();
                tbmakh.Text = sv.ma_kho_hang;
                cbbdiachi.Text = sv.dia_chi;
            }

            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmakhohang.ReadOnly = true;
            cbbdiachi.Enabled = true;
        }

        // Chức năng thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            tbmakhohang.ReadOnly = false;
            tbmahanghoa.ReadOnly = false;
            dtpngaynhapkho.Enabled = true;
            dtpngayxuatkho.Enabled = true;
            tbsoluong.ReadOnly = false;
            cbbdiachi.Enabled = true;
            tbmakh.ReadOnly = false;
            UpdateDGV();
        }

        // Chức năng luu
        private void btnluu_Click(object sender, EventArgs e)
        {
            // khi check 2 cái
            if (cbkhohanghanghoa.Checked && cbkhohang.Checked)
            {
                MessageBox.Show("Chỉ được chọn 1 chế độ ");
                cbkhohang.Checked = false;
                cbkhohanghanghoa.Checked = false;
            }
            // khi check kho hang hang hoa
            else if (cbkhohanghanghoa.Checked)
            {
                try
                {
                    kho_hang addkh = new kho_hang();


                    khohang_hanghoa addkhhh = new khohang_hanghoa();
                    addkhhh.ma_kho_hang = addkh.ma_kho_hang = tbmakhohang.Text;
                    addkhhh.ma_hang_hoa = tbmahanghoa.Text;
                    addkhhh.ngay_nhap = dtpngaynhapkho.Value;
                    addkhhh.ngay_xuat = dtpngayxuatkho.Value;
                    addkhhh.so_luong = int.Parse(tbsoluong.Text);


                    using (DUAN1Entities db = new DUAN1Entities())
                    {
                        addkhhh.ma_kho_hang = addkh.ma_kho_hang = tbmakhohang.Text;
                        addkhhh.ma_hang_hoa = tbmahanghoa.Text;
                        addkhhh.ngay_nhap = dtpngaynhapkho.Value;
                        addkhhh.ngay_xuat = dtpngayxuatkho.Value;
                        addkhhh.so_luong = int.Parse(tbsoluong.Text);
                        db.khohang_hanghoa.Add(addkhhh);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm thành công ");
                    UpdateDGV();
                }
                catch (Exception)
                {

                    MessageBox.Show("Không được để trống");
                }
                UpdateDGV();
            }
            // khi check kho hang
            else if (cbkhohang.Checked)
            {
                try
                {
                    kho_hang addsp = new kho_hang();
                    addsp.ma_kho_hang = tbmakh.Text;
                    addsp.dia_chi = cbbdiachi.Text;


                    using (DUAN1Entities db = new DUAN1Entities())
                    {
                        //kho_hang quocgiaduocchon = db.kho_hang.Where(x => x.dia_chi == cbbdiachi.SelectedItem.ToString()).FirstOrDefault();
                        //addsp.ma_kho_hang = quocgiaduocchon.dia_chi;
                        addsp.ma_kho_hang = tbmakh.Text;
                        addsp.dia_chi = cbbdiachi.Text;
                        db.kho_hang.Add(addsp);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm thành công ");
                }
                catch (Exception)
                {

                    MessageBox.Show("Không được để trống");
                }
                UpdateDGV();
            }
            // khi không check
            else
            {
                MessageBox.Show("Không được để trống, Hãy chọn chế độ ");
            }
        }

        //Chức năng xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            // khi check 2 cái
            if (cbkhohanghanghoa.Checked && cbkhohang.Checked)
            {
                MessageBox.Show("Chỉ được chọn 1 chế độ ");
                cbkhohang.Checked = false;
                cbkhohanghanghoa.Checked = false;
            }
            // khi check kho hang hang hoa
            else if (cbkhohanghanghoa.Checked)
            {
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    khohang_hanghoa delete = db.khohang_hanghoa.Where(x => x.ma_kho_hang == tbmakhohang.Text).FirstOrDefault();

                    db.khohang_hanghoa.Remove(delete);
                    db.SaveChanges();
                }
                MessageBox.Show("Xóa thành công ");
                UpdateDGV();
            }
            // khi check kho hang
            else if (cbkhohang.Checked)
            {
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    kho_hang delete = db.kho_hang.FirstOrDefault(x => x.ma_kho_hang == tbmakh.Text);

                    if (delete != null)
                    {
                        db.kho_hang.Remove(delete);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                        UpdateDGV();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kho hàng cần xóa");
                    }
                }
            }
            // khi không check
            else
            {
                MessageBox.Show("Không được để trống, Hãy chọn chế độ ");
            }
        }

        // Chức năng hủy reload lại form
        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbmakhohang.Text = "";
            tbmahanghoa.Text = "";
            dtpngaynhapkho.Text = "";
            dtpngayxuatkho.Text = "";
            tbsoluong.Text = "";

            tbmakh.Text = "";
            cbbdiachi.Text = "";

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;

            tbmakhohang.ReadOnly = true;
            tbmahanghoa.ReadOnly = true;
            dtpngaynhapkho.Enabled = false;
            dtpngayxuatkho.Enabled = false;
            tbsoluong.ReadOnly = true;
            cbbdiachi.Enabled = false;
            tbmakh.ReadOnly = true;
        }

        // Chức năng sửa
        private void btnsua_Click(object sender, EventArgs e)
        {
            // khi check 2 cái
            if (cbkhohanghanghoa.Checked && cbkhohang.Checked)
            {
                MessageBox.Show("Chỉ được chọn 1 chế độ ");
                cbkhohang.Checked = false;
                cbkhohanghanghoa.Checked = false;
            }
            // khi check kho hang hang hoa
            else if (cbkhohanghanghoa.Checked)
            {
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    string maKhoHang = tbmakhohang.Text;
                    khohang_hanghoa edit = db.khohang_hanghoa.FirstOrDefault(x => x.ma_kho_hang == maKhoHang);
                    if (edit != null)
                    {
                        edit.ma_kho_hang = tbmakhohang.Text;
                        edit.ma_hang_hoa = tbmahanghoa.Text;
                        edit.ngay_nhap = dtpngaynhapkho.Value;
                        edit.ngay_xuat = dtpngayxuatkho.Value;
                        edit.so_luong = int.Parse(tbsoluong.Text);
                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng");
                    }
                    UpdateDGV();
                }
            }
            // khi check kho hang
            else if (cbkhohang.Checked)
            {
                MessageBox.Show("b");

                using (DUAN1Entities db = new DUAN1Entities())
                {
                    string maKH = tbmakh.Text;
                    kho_hang edit = db.kho_hang.FirstOrDefault(x => x.ma_kho_hang == maKH);
                    if (edit != null)
                    {
                        edit.ma_kho_hang = tbmakh.Text;
                        edit.dia_chi = cbbdiachi.Text;

                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng");
                    }
                    UpdateDGV();
                }



            }
            // khi không check
            else
            {
                MessageBox.Show("Không được để trống, Hãy chọn chế độ ");
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



                using (DUAN1Entities db = new DUAN1Entities())
                {
                    List<khohang_hanghoa> listsv = db.khohang_hanghoa.Where(x => x.ma_kho_hang.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listsv.ToList().ForEach(sv =>
                    {
                        dataGridView1.Rows.Add(
                        sv.ma_kho_hang,
                        sv.ma_hang_hoa,
                        sv.ngay_nhap,
                        sv.ngay_xuat,
                        sv.so_luong);
                    }
                    );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }

        //btn hóa đơn
        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon form = new QuanLyHoaDon();
            form.ShowDialog();
            this.Close();
        }

        //btn thoát
        private void btnthoat_Click(object sender, EventArgs e)
        {
            //Nút thoát ra ngoài form Đăng nhập
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            this.Close();
        }

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
            KhoHangHangHoa khhh = new KhoHangHangHoa();
            khhh.ShowDialog();
            this.Close();
        }

        //btn nhân viên
        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.ShowDialog();
            this.Close();
        }

        //btn nhân viên
        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            qlkh.ShowDialog();
            this.Close();
        }

        //btn thống kê
        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
            this.Close();
        }

        //btn thông tin nhân viên
        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinNhanVien tk = new ThongTinNhanVien();
            tk.ShowDialog();
            this.Close();
        }
    }
}
