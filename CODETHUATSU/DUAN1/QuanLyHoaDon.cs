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
using System.Drawing.Printing;

namespace DUAN1
{
    public partial class QuanLyHoaDon : Form
    {
        string role = "";
        public QuanLyHoaDon(string username)
        {
            role = username;
            InitializeComponent();
            //tbusername.Text = username;
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dtpngaylap.Format = DateTimePickerFormat.Short;
            dtpngaylap.CustomFormat = "dd/MM/yyyy";
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                //mã khách hàng
                cbbmakhachhang.Items.Clear();
                db.khach_hang.ToList().ForEach(row => cbbmakhachhang.Items.Add(row.ten_kh));
                //mã nhân viên
                cbbmanv.Items.Clear();
                db.nhan_vien.ToList().ForEach(row => cbbmanv.Items.Add(row.ten_nv));
                //trang thai
                cbbTrangThai.Items.Clear();
                db.hoa_don.ToList().ForEach(row => cbbTrangThai.Items.Add(row.trang_thai));

                dataGridView1.Rows.Clear();

                db.hoa_don.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.khach_hang.ten_kh,
                    hd.nhan_vien.ten_nv,
                    DateTime.Parse(hd.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.trang_thai,
                    hd.tongtien

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
                dtpngaylap.Enabled = false;
            }
            if (role.Equals("nhanvien"))
            {
                btnxoa.Enabled = false;
            }
            else
            {
                btnxoa.Enabled = true;
            }
        }

        // Cập nhật  DGV
        private void UpdateDGV()
        {
            dataGridView1.Rows.Clear();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                //trang thai
                cbbTrangThai.Items.Clear();
                db.hoa_don.ToList().ForEach(row => cbbTrangThai.Items.Add(row.trang_thai));
                dataGridView1.Rows.Clear();
                db.hoa_don.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.khach_hang.ten_kh,
                    hd.nhan_vien.ten_nv,
                    DateTime.Parse(hd.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.trang_thai,
                    hd.tongtien
                    );
                }
                );
            }


        }

        // DataGridView lấy thông tin khi click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (role.Equals("nhanvien"))
            {
                btnxoa.Enabled = false;
            }
            else
            {
                btnxoa.Enabled = true;
            }
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];
            String MaHD = rowData.Cells[0].Value.ToString();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                hoa_don hd = db.hoa_don.Where(x => x.ma_hd == MaHD).FirstOrDefault();

                tbmahoadon.Text = hd.ma_hd;
                cbbmakhachhang.Text = hd.khach_hang.ten_kh;
                cbbmanv.Text = hd.nhan_vien.ten_nv;
                dtpngaylap.Text = hd.ngay_lap.ToString();
                tbtrangthai.Text = hd.trang_thai;

            }
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = true;
            cbbmanv.Enabled = true;
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
            tbtrangthai.ReadOnly = false;
            dtpngaylap.Enabled = true;

            UpdateDGV();
        }

        //chức năng lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {

                using (DAXuongEntities db = new DAXuongEntities())
                {
                    Constant.ChangeDatabase(db);
                    hoa_don addhd = new hoa_don();
                    if (string.IsNullOrEmpty(tbmahoadon.Text) || string.IsNullOrEmpty(cbbmanv.Text) || string.IsNullOrEmpty(cbbmakhachhang.Text))
                    {
                        MessageBox.Show("Không bỏ trống mã, tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DateTime now = DateTime.Now;
                    if (dtpngaylap.Value > now)
                    {
                        MessageBox.Show("Ngày lập không được lớn hơn hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var kh = db.khach_hang.FirstOrDefault(a => a.ten_kh.Equals(cbbmakhachhang.Text));
                    var nv = db.nhan_vien.FirstOrDefault(a => a.ten_nv.Equals(cbbmanv.Text));

                    addhd.ma_hd = tbmahoadon.Text;
                    addhd.ma_kh = kh.ma_kh;
                    addhd.ma_nv = nv.ma_nv;
                    addhd.ngay_lap = dtpngaylap.Value;
                    addhd.trang_thai = tbtrangthai.Text;

                    db.hoa_don.Add(addhd);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công");
                    UpdateDGV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //chức năng xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    Constant.ChangeDatabase(db);
                    var confirmResult = MessageBox.Show(
                    "Xóa hàng hóa đã chọn ?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    hoa_don delete = db.hoa_don.Where(x => x.ma_hd == tbmahoadon.Text).FirstOrDefault();
                    string choxoa = LocDau("chờ xóa").Trim().ToLower();
                    string trangthai = LocDau(delete.trang_thai).Trim().ToLower();
                    if (confirmResult == DialogResult.Yes && trangthai.Equals(choxoa))
                    {
                        db.hoa_don.Remove(delete);
                        MessageBox.Show("Xóa thành công");
                        db.SaveChanges();
                    }
                    else
                    {
                        hoa_don selectedHH = delete;
                        selectedHH.trang_thai = "Đã thanh toán";
                        if (DBHandler.updateHoaDon(selectedHH))
                        {
                            MessageBox.Show("Đã cập nhật");
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
                UpdateDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy sản phẩm cần xóa ");
            }
        }
        private static readonly string[] VietNamChar = new string[]
       {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
       };
        public static string LocDau(string str)
        {//Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
        // Chức năng hủy reload lại form
        private void btnhuy_Click(object sender, EventArgs e)
        {
            tbmahoadon.Text = "";
            cbbmakhachhang.Text = "";
            cbbmanv.Text = "";
            dtpngaylap.Text = "";
            tbtrangthai.Text = "";

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = false;
            cbbmanv.Enabled = false;
            tbtrangthai.ReadOnly = true;
            dtpngaylap.Enabled = false;
        }
        
        //chức năng sủa
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    Constant.ChangeDatabase(db);
                    string maHD = tbmahoadon.Text;

                    hoa_don hd = db.hoa_don.FirstOrDefault(x => x.ma_hd == maHD);
                    if (hd != null)
                    {
                        hoa_don edit = db.hoa_don.FirstOrDefault(x => x.ma_hd == tbmahoadon.Text);
                        if (edit != null)
                        {
                            if (string.IsNullOrEmpty(tbmahoadon.Text) || string.IsNullOrEmpty(cbbmanv.Text) || string.IsNullOrEmpty(cbbmakhachhang.Text))
                            {
                                MessageBox.Show("Không bỏ trống mã, tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            DateTime now = DateTime.Now;
                            if (dtpngaylap.Value > now)
                            {
                                MessageBox.Show("Ngày lập không được lớn hơn hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            edit.ma_hd = tbmahoadon.Text;
                            edit.ma_kh = cbbmakhachhang.Text;
                            edit.ma_nv = cbbmanv.Text;
                            edit.ngay_lap = dtpngaylap.Value;
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
            catch(Exception)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cbbTrangThai_TextChanged(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                //trang thai
                cbbTrangThai.Items.Clear();
                db.hoa_don.ToList().ForEach(row => cbbTrangThai.Items.Add(row.trang_thai));

                var hoaDon = db.hoa_don.Where(a => a.trang_thai.Equals(cbbTrangThai.Text));
                dataGridView1.Rows.Clear();
                hoaDon.ToList().ForEach(hd =>
                {
                    dataGridView1.Rows.Add(
                    hd.ma_hd,
                    hd.khach_hang.ten_kh,
                    hd.nhan_vien.ten_nv,
                    DateTime.Parse(hd.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                    hd.trang_thai
                    );
                }
                );
            }
        }
    }
}
