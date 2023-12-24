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
        public QuanLyHoaDon()
        {
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

                //mã khách hàng
                cbbmakhachhang.Items.Clear();
                db.khach_hang.ToList().ForEach(row => cbbmakhachhang.Items.Add(row.ten_kh));
                //mã nhân viên
                cbbmanv.Items.Clear();
                db.nhan_vien.ToList().ForEach(row => cbbmanv.Items.Add(row.ten_nv));

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
                tbtongtien.ReadOnly = true;
            }
        }

        // Cập nhật  DGV
        private void UpdateDGV()
        {
            dataGridView1.Rows.Clear();
            using (DAXuongEntities db = new DAXuongEntities())
            {
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

            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];
            String MaHD = rowData.Cells[0].Value.ToString();
            using (DAXuongEntities db = new DAXuongEntities())
            {
                hoa_don hd = db.hoa_don.Where(x => x.ma_hd == MaHD).FirstOrDefault();

                tbmahoadon.Text = hd.ma_hd;
                cbbmakhachhang.Text = hd.khach_hang.ten_kh;
                cbbmanv.Text = hd.nhan_vien.ten_nv;
                dtpngaylap.Text = hd.ngay_lap.ToString();
                tbtrangthai.Text = hd.trang_thai;
                tbtongtien.Text = hd.tongtien.ToString();

            }

            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = true;
            cbbmanv.Enabled = true;
            tbtrangthai.ReadOnly = false;
            dtpngaylap.Enabled = true;
            tbtongtien.ReadOnly = false;

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
            tbtongtien.ReadOnly = false;

            UpdateDGV();
        }

        //chức năng lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {

                hoa_don addhd = new hoa_don();
                using (DAXuongEntities db = new DAXuongEntities())
                {

                    var kh = db.khach_hang.FirstOrDefault(a => a.ten_kh.Equals(cbbmakhachhang.Text));
                    var nv = db.nhan_vien.FirstOrDefault(a => a.ten_nv.Equals(cbbmanv.Text));

                    addhd.ma_hd = tbmahoadon.Text;
                    addhd.ma_kh = kh.ma_kh;
                    addhd.ma_nv = nv.ma_nv;
                    addhd.ngay_lap = dtpngaylap.Value;
                    addhd.trang_thai = tbtrangthai.Text;
                    addhd.tongtien = float.Parse(tbtongtien.Text);

                    db.hoa_don.Add(addhd);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công");
                    UpdateDGV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không được để trống");
            }
}

        //chức năng xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (DAXuongEntities db = new DAXuongEntities())
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
            cbbmakhachhang.Text = "";
            cbbmanv.Text = "";
            dtpngaylap.Text = "";
            tbtrangthai.Text = "";
            tbtongtien.Text = "";

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;

            tbmahoadon.ReadOnly = true;
            cbbmakhachhang.Enabled = false;
            cbbmanv.Enabled = false;
            tbtrangthai.ReadOnly = true;
            dtpngaylap.Enabled = false;
            tbtongtien.ReadOnly = true;
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
                    List<hoa_don> listhd = db.hoa_don.Where(x => x.ma_hd.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listhd.ToList().ForEach(hd =>
                    {
                        dataGridView1.Rows.Add(
                        hd.ma_hd,
                        hd.ma_kh,
                        hd.ma_nv,
                        hd.ngay_lap,
                        hd.trang_thai,
                        hd.tongtien);
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
            string maHD = tbmahoadon.Text;
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                hoa_don edit = db.hoa_don.FirstOrDefault(x => x.ma_hd == maHD);

                var kh = db.khach_hang.FirstOrDefault(a => a.ten_kh.Equals(cbbmakhachhang.Text));
                var nv = db.nhan_vien.FirstOrDefault(a => a.ten_nv.Equals(cbbmanv.Text));

                if (edit != null)
                {
                    edit.ma_hd = tbmahoadon.Text;
                    edit.ma_kh = kh.ma_kh;
                    edit.ma_nv = nv.ma_nv;
                    edit.ngay_lap = dtpngaylap.Value;
                    edit.trang_thai = tbtrangthai.Text;
                    if (int.Parse(tbtongtien.Text) <= 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    edit.tongtien = int.Parse(tbtongtien.Text);

                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn");
                }

                UpdateDGV();
            }




        }





    }
}
