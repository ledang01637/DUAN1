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
    public partial class ThongKe : Form
    {
        public ThongKe(String username)
        {
            InitializeComponent();
            tbusername.Text = username;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            dtpngaylap.Format = DateTimePickerFormat.Short;
            dtpngaylap.CustomFormat = "dd/MM/yyyy";

            dtptungay.Format = DateTimePickerFormat.Short;
            dtptungay.CustomFormat = "dd/MM/yyyy";

            dtpdenngay.Format = DateTimePickerFormat.Short;
            dtpdenngay.CustomFormat = "dd/MM/yyyy";

            using (DUAN1Entities db = new DUAN1Entities())
            {
                cbbmahanghoa.Items.Clear();
                db.hang_hoa.ToList().ForEach(row => cbbmahanghoa.Items.Add(row.ma_hang_hoa));

                dataGridView1.Rows.Clear();

                var hoaDonList = db.hoa_don.ToList();

                foreach (var hoaDon in hoaDonList)
                {
                    var khoHang = db.khohang_hanghoa.FirstOrDefault(kh => kh.makho_hangchitiet == hoaDon.makho_hangchitiet);

                    dataGridView1.Rows.Add(
                        hoaDon.ma_hd,
                        DateTime.Parse(hoaDon.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                        hoaDon.thanh_tien,
                        hoaDon.so_luong,
                        khoHang != null ? khoHang.so_luong - hoaDon.so_luong : 0
                    );
                }
            }
        }

        
        //hiển thị
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];

            string MaKH = rowData.Cells[0].Value.ToString();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                hoa_don hd = db.hoa_don.FirstOrDefault(x => x.makho_hangchitiet == MaKH);
                khohang_hanghoa khhh = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet == MaKH);

                if (hd != null && khhh != null)
                {
                    cbbmahanghoa.Text = hd.makho_hangchitiet;
                    dtpngaylap.Value = hd.ngay_lap.Value;
                    tbgia.Text = hd.thanh_tien.ToString();
                    tbsoluongdaban.Text = hd.so_luong.ToString();
                    tbsltrongkho.Text = (khhh.so_luong - hd.so_luong).ToString();
                }
            }


        }

        //tìm kiếm theo ngày và mã
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbtimkiem.Text.Equals(""))
                {
                    tbtimkiem.Text = "";
                }
                else
                {
                    DateTime fromDate = dtptungay.Value.Date;
                    DateTime toDate = dtpdenngay.Value.Date.AddDays(1); // Bổ sung 1 ngày để bao gồm cả ngày kết thúc

                    using (DUAN1Entities db = new DUAN1Entities())
                    {
                        List<hoa_don> listhd = db.hoa_don
                            .Where(x => x.makho_hangchitiet.Equals(tbtimkiem.Text) && x.ngay_lap >= fromDate && x.ngay_lap < toDate)
                            .ToList();

                        List<khohang_hanghoa> listkhhh = db.khohang_hanghoa
                            .Where(x => x.makho_hangchitiet.Equals(tbtimkiem.Text))
                            .ToList();

                        dataGridView1.Rows.Clear();

                        listhd.ForEach(hd =>
                        {
                            khohang_hanghoa khhh = listkhhh.FirstOrDefault(x => x.makho_hangchitiet == hd.makho_hangchitiet);
                            if (khhh != null)
                            {
                                dataGridView1.Rows.Add(
                                    hd.makho_hangchitiet,
                                    hd.ngay_lap,
                                    hd.thanh_tien,
                                    hd.so_luong,
                                    khhh.so_luong);
                            }
                        });
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            ThongKe_Load(null, EventArgs.Empty);
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
            ThongTinNhanVien ttnv = new ThongTinNhanVien(tbusername.Text);
            ttnv.ShowDialog();
            this.Close();
        }



    }
}
