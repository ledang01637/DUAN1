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
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dtpngaylap.Format = DateTimePickerFormat.Short;
            dtpngaylap.CustomFormat = "dd/MM/yyyy";

            using (DUAN1Entities db = new DUAN1Entities())
            {

                //mã khách hàng
                cbbmakhachhang.Items.Clear();
                db.khach_hang.ToList().ForEach(row => cbbmakhachhang.Items.Add(row.ma_kh));
                //mã nhân viên
                cbbmanv.Items.Clear();
                db.nhan_vien.ToList().ForEach(row => cbbmanv.Items.Add(row.ma_nv));
                //mã hàng hóa
                cbbmakhct.Items.Clear();
                db.khohang_hanghoa.ToList().ForEach(row => cbbmakhct.Items.Add(row.makho_hangchitiet));

                dataGridView1.Rows.Clear();
                
                db.hoa_don.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.ma_kh,
                    hd.ma_nv,
                    hd.makho_hangchitiet,
                    DateTime.Parse(hd.ngay_lap.ToString(),CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.so_luong,
                    hd.thanh_tien,
                    hd.trang_thai
                    );
                }
                );

                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                btnhuy.Enabled = false;
                btnluu.Enabled = false;

                tbmahoadon.ReadOnly = true;
                cbbmakhachhang.Enabled = false;
                cbbmanv.Enabled = false;
                cbbmakhct.Enabled = false;
                tbthanhtien.ReadOnly = true;
                tbsoluong.ReadOnly = true;
                tbtrangthai.ReadOnly = true;
                dtpngaylap.Enabled = false;

            }
        }

        // Cập nhật  DGV
        private void UpdateDGV()
        {
            dataGridView1.Rows.Clear();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                dataGridView1.Rows.Clear();

                db.hoa_don.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.ma_kh,
                    hd.ma_nv,
                    hd.makho_hangchitiet,
                    DateTime.Parse(hd.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.so_luong,
                    hd.thanh_tien,
                    hd.trang_thai
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

            String MaHD = rowData.Cells[0].Value.ToString();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                hoa_don hd = db.hoa_don.Where(x => x.ma_hd == MaHD).FirstOrDefault();
                tbmahoadon.Text = hd.ma_hd;
                cbbmakhachhang.Text = hd.ma_kh;
                cbbmanv.Text = hd.ma_nv;
                cbbmakhct.Text = hd.makho_hangchitiet;
                dtpngaylap.Text = hd.ngay_lap.ToString();
                tbsoluong.Text = hd.so_luong.ToString();
                tbthanhtien.Text = hd.thanh_tien.ToString();
                tbtrangthai.Text = hd.trang_thai;
            }

            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = true;
            cbbmanv.Enabled = true;
            cbbmakhct.Enabled = true;
            tbthanhtien.ReadOnly = false;
            tbsoluong.ReadOnly = false;
            tbtrangthai.ReadOnly = false;
            dtpngaylap.Enabled = true;


        }
        
        //chức năng thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            tbmahoadon.ReadOnly = false;
            cbbmakhachhang.Enabled = true;
            cbbmanv.Enabled = true;
            cbbmakhct.Enabled = true;
            tbsoluong.ReadOnly = false;
            tbtrangthai.ReadOnly = false;
            dtpngaylap.Enabled = true;
            UpdateDGV();
        }

        //chức năng lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                String maHH = cbbmakhct.Text;
                int soLuong = int.Parse(tbsoluong.Text);

                using (DUAN1Entities db = new DUAN1Entities())
                {
                    hoa_don addhd = new hoa_don();
                    khohang_hanghoa khhh = new khohang_hanghoa();

                    khohang_hanghoa khohang_Hanghoa = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet == maHH);
                    hang_hoa hangHoa = db.hang_hoa.FirstOrDefault(x => x.ma_hang_hoa.Equals(khohang_Hanghoa.ma_hang_hoa));

                        addhd.ma_hd = tbmahoadon.Text;
                        addhd.ma_kh = cbbmakhachhang.Text;
                        addhd.ma_nv = cbbmanv.Text;
                        addhd.makho_hangchitiet = maHH;
                        addhd.ngay_lap = dtpngaylap.Value;
                        addhd.so_luong = soLuong;
                        addhd.thanh_tien = hangHoa.gia_ban * soLuong;
                        addhd.trang_thai = tbtrangthai.Text;

                        db.hoa_don.Add(addhd);
                        db.SaveChanges();

                        MessageBox.Show("Thêm thành công");
                        UpdateDGV();
                    

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không được để trống hoặc sai thông tin");
            }

        }

        //chức năng xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (DUAN1Entities db = new DUAN1Entities())
                {
                    hoa_don delete = db.hoa_don.Where(x => x.ma_hd == tbmahoadon.Text).FirstOrDefault();

                    db.hoa_don.Remove(delete);
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

        // Chức năng hủy reload lại form
        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbmahoadon.Text = "";
            cbbmakhct.Text = "";
            cbbmakhachhang.Text = "";
            cbbmanv.Text = "";
            tbsoluong.Text = "";
            tbthanhtien.Text = "";
            dtpngaylap.Text = "";
            tbtrangthai.Text = "";

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = false;
            cbbmanv.Enabled = false;
            cbbmakhct.Enabled = false;
            tbsoluong.ReadOnly = true;
            tbtrangthai.ReadOnly = true;
            dtpngaylap.Enabled = false;
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
                    List<hoa_don> listhd = db.hoa_don.Where(x => x.ma_hd.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listhd.ToList().ForEach(hd =>
                    {
                        dataGridView1.Rows.Add(
                        hd.ma_hd,
                        hd.ma_kh,
                        hd.ma_nv,
                        hd.makho_hangchitiet,
                        hd.ngay_lap,
                        hd.so_luong,
                        hd.thanh_tien,
                        hd.trang_thai);
                    }
                    );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }
        
        //chức năng sủa
        private void btnsua_Click(object sender, EventArgs e)
        {
            using (DUAN1Entities db = new DUAN1Entities())
            {
                string maHH = cbbmakhct.Text;
                int soLuong = int.Parse(tbsoluong.Text);

                khohang_hanghoa khohang_Hanghoa = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet == maHH);
                hang_hoa hangHoa = db.hang_hoa.FirstOrDefault(x => x.ma_hang_hoa.Equals(khohang_Hanghoa.ma_hang_hoa));

                if (khohang_Hanghoa != null)
                {
                    hoa_don edit = db.hoa_don.FirstOrDefault(hd => hd.ma_hd == tbmahoadon.Text);
                    if (edit != null)
                    {
                        edit.ma_kh = cbbmakhachhang.Text;
                        edit.ma_nv = cbbmanv.Text;
                        edit.makho_hangchitiet = cbbmakhct.Text;
                        edit.ngay_lap = dtpngaylap.Value;
                        edit.so_luong = soLuong;
                        edit.thanh_tien = hangHoa.gia_ban * soLuong;
                        edit.trang_thai = tbtrangthai.Text;
                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hàng hóa");
                }

                UpdateDGV();
            }
        }

        //chức năng chuyển sang listview
        private void btnchuyen_Click(object sender, EventArgs e)
        {

        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHangHangHoa form = new KhoHangHangHoa();
            form.ShowDialog();
            this.Close();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe form = new ThongKe();
            form.ShowDialog();
            this.Close();
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {

        }
    }
}
