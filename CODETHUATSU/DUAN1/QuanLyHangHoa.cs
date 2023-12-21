using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace DUAN1
{
    public partial class QuanLyHangHoa : Form
    {
        List<hang_hoa> dsHang;
        String imagePath = "";
        bool focus, focusTenHH, focusNSX, focusGia, focusHSD, foucusGiaNhap;
        bool isText, isTextTenHH, isTextNSX, isTextGia, isTextHSD, isTextGiaNhap;

        public QuanLyHangHoa(String username)
        {
            InitializeComponent();
            tbusername.Text = username;
        }
        private void QuanLyHangHoa_Load(object sender, EventArgs e)
        {
            SelectHang();
            upDateDataGridView1();
        }
        private void SelectHang()
        {
            using(DAXuongEntities db = new DAXuongEntities())
            {
                cbbTenHH.Items.Clear();
                db.hang_hoa.ToList().ForEach(item => cbbTenHH.Items.Add(item.ten));
                cbbNsx.Items.Clear();
                db.hang_hoa.ToList().ForEach(item => cbbNsx.Items.Add(item.noisx));
            }
        }
        private void upDateDataGridView1()
        {
            Reset();
            dsHang = DBHandler.getListHang_hoa();
            dataGridView1.Rows.Clear();
            dsHang.ForEach(row => dataGridView1.Rows.Add(
                row.ma_hang_hoa,
                row.ten,
                row.mota,
                row.noisx
            ));
            dataGridView1.Update();
        }
        private void Reset()
        {
            tbmahanghoa.Text = "";
            tbtenhanghoa.Text = "";
            tbmota.Text = "";
            tbnsx.Text = "";
            cbbTenHH.Text = "";
            cbbNsx.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            tbmahanghoa.Enabled = true;
            tbtenhanghoa.Enabled = true;
            tbmota.Enabled = true;
            tbnsx.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            upDateDataGridView1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnluu.Enabled = false;
                var cell = (sender as DataGridView).CurrentCell;
                var row = dataGridView1.Rows[cell.RowIndex];

                tbmahanghoa.Text = row.Cells[0].Value?.ToString();
                tbtenhanghoa.Text = row.Cells[1].Value?.ToString();
                tbmota.Text = row.Cells[2].Value?.ToString();
                tbnsx.Text = row.Cells[3].Value?.ToString();

                tbmahanghoa.Enabled = false;
                tbtenhanghoa.Enabled = true;
                tbmota.Enabled = true;
                tbnsx.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lỗi","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbmahanghoa.Text) || string.IsNullOrEmpty(tbtenhanghoa.Text))
            {
                MessageBox.Show("Không bỏ trống mã, tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hang_hoa hangHoaAdd = new hang_hoa();
            hangHoaAdd.ma_hang_hoa = tbmahanghoa.Text;
            hangHoaAdd.ten = tbtenhanghoa.Text;
            hangHoaAdd.mota = tbmota.Text;
            hangHoaAdd.noisx = tbnsx.Text;

            if (DBHandler.addHangHoa(hangHoaAdd))
            {
                MessageBox.Show("Đã thêm hàng hóa");
                this.upDateDataGridView1();
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
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbmahanghoa.Text))
            {
                MessageBox.Show("Vui lòng chọn hàng hóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbtenhanghoa.Text))
            {
                MessageBox.Show("Không bỏ trống tên hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            hang_hoa selectedHH = dsHang[selectedRowIndex];
            selectedHH.ten = tbtenhanghoa.Text;
            selectedHH.mota = tbmota.Text;
            selectedHH.noisx = tbnsx.Text;
            if (DBHandler.updateHangHoa(selectedHH))
            {
                MessageBox.Show("Đã cập nhật");
                this.upDateDataGridView1();
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
        private void btnhuy_Click(object sender, EventArgs e)
        {
            Reset();
            upDateDataGridView1();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Xóa hàng hóa đã chọn ?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmResult == DialogResult.Yes)
            {
                if (tbmahanghoa.Text != null || tbmahanghoa.Text != "")
                {
                    if (DBHandler.deleteHangHoa(tbmahanghoa.Text))
                    {
                        MessageBox.Show("Đã xóa hàng hóa");
                        this.upDateDataGridView1();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Xóa thất bại",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }
        //private void btnTaoQR_Click(object sender, EventArgs e)
        //{
        //    btnsua.Enabled = false;
        //    btnLuuQR.Enabled = true;
        //    var options = new QrCodeEncodingOptions
        //    {
        //        DisableECI = true,
        //        CharacterSet = "UTF-8",
        //        Width = 333,
        //        Height = 333,
        //    };
        //    BarcodeWriter barcodeWriter = new BarcodeWriter();
        //    barcodeWriter.Format = BarcodeFormat.QR_CODE;
        //    barcodeWriter.Options = options;
        //    if (!string.IsNullOrEmpty(tbmahanghoa.Text))
        //    {
        //        Bitmap result = barcodeWriter.Write(tbmahanghoa.Text);
        //        hinhanh.Image = result;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng thêm mã hàng để tạo","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //    }
        //}

        //private void btnLuuQR_Click(object sender, EventArgs e)
        //{
        //    if (hinhanh.Image != null)
        //    {
        //        Bitmap myBitmap = (Bitmap)hinhanh.Image;
        //        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        //        saveFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
        //        saveFileDialog1.FilterIndex = 2;
        //        saveFileDialog1.RestoreDirectory = true;
        //        saveFileDialog1.FileName = hinhanh.Text + ".jpg";
        //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            myBitmap.Save(saveFileDialog1.FileName);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không có ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void pictureBox2_Paint(object sender, PaintEventArgs e)
        //{
        //    //MaHH
        //    if (focus)
        //    {
        //        if (tbmahanghoa.Text.Trim() == "" || tbmahanghoa.Text.Trim() == null)
        //        {
        //            Pen pen = new Pen(Color.Red);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(tbmahanghoa.Location.X - LoX - 2, tbmahanghoa.Location.Y - LoY - 2, tbmahanghoa.Width + 1, tbmahanghoa.Height + 1));
        //        }
        //        else if (isText)
        //        {
        //            Pen pen = new Pen(Color.LawnGreen);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(tbmahanghoa.Location.X - LoX - 2, tbmahanghoa.Location.Y - LoY - 2, tbmahanghoa.Width + 1, tbmahanghoa.Height + 1));
        //        }
        //    }
        //    else
        //    {
        //        tbmahanghoa.BorderStyle = BorderStyle.FixedSingle;
        //    }
        //    //TenHH
        //    if (focusTenHH)
        //    {
        //        if (tbtenhanghoa.Text.Trim() == "" || tbtenhanghoa.Text.Trim() == null)
        //        {
        //            Pen pen = new Pen(Color.Red);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(tbtenhanghoa.Location.X - LoX - 2, tbtenhanghoa.Location.Y - LoY - 2, tbtenhanghoa.Width + 1, tbtenhanghoa.Height + 1));
        //        }
        //        else if (isTextTenHH)
        //        {
        //            Pen pen = new Pen(Color.LawnGreen);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(tbtenhanghoa.Location.X - LoX - 2, tbtenhanghoa.Location.Y - LoY - 2, tbtenhanghoa.Width + 1, tbtenhanghoa.Height + 1));
        //        }
        //    }
        //    else
        //    {
        //        tbtenhanghoa.BorderStyle = BorderStyle.FixedSingle;
        //    }
        //    //NgaySX
        //    if (focusNSX)
        //    {
        //        if (dtpngaysanxuat.Value > DateTime.Now)
        //        {
        //            Pen pen = new Pen(Color.Red);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(dtpngaysanxuat.Location.X - LoX - 2, dtpngaysanxuat.Location.Y - LoY - 2, dtpngaysanxuat.Width + 1, dtpngaysanxuat.Height + 1));
        //        }
        //        else if (isTextNSX)
        //        {
        //            Pen pen = new Pen(Color.LawnGreen);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(dtpngaysanxuat.Location.X - LoX - 2, dtpngaysanxuat.Location.Y - LoY - 2, dtpngaysanxuat.Width + 1, dtpngaysanxuat.Height + 1));
        //        }
        //    }
        //    //HSD
        //    if (focusHSD)
        //    {
        //        if (dtphansudung.Value < dtpngaysanxuat.Value)
        //        {
        //            Pen pen = new Pen(Color.Red);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(dtphansudung.Location.X - LoX - 2, dtphansudung.Location.Y - LoY - 2, dtphansudung.Width + 1, dtphansudung.Height + 1));
        //        }
        //        else if (isTextHSD)
        //        {
        //            Pen pen = new Pen(Color.LawnGreen);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(dtphansudung.Location.X - LoX - 2, dtphansudung.Location.Y - LoY - 2, dtphansudung.Width + 1, dtphansudung.Height + 1));
        //        }
        //    }
        //    //Gia
        //    if (focusGia)
        //    {
        //        float Gia;
        //        var isNumber = float.TryParse(tbgia.Text, out Gia);
        //        if (isNumber == false || Gia < 0)
        //        {
        //            Pen pen = new Pen(Color.Red);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(tbgia.Location.X - LoX - 2, tbgia.Location.Y - LoY - 2, tbgia.Width + 1, tbgia.Height + 1));
        //        }
        //        else if (isTextGia)
        //        {
        //            Pen pen = new Pen(Color.LawnGreen);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(tbgia.Location.X - LoX - 2, tbgia.Location.Y - LoY - 2, tbgia.Width + 1, tbgia.Height + 1));
        //        }
        //    }
        //    else
        //    {
        //        tbgia.BorderStyle = BorderStyle.FixedSingle;
        //    }
        //    //GiaNhap
        //    if (foucusGiaNhap)
        //    {
        //        float Gia;
        //        var isNumber = float.TryParse(tbgianhap.Text, out Gia);
        //        if (isNumber == false || Gia < 0)
        //        {
        //            Pen pen = new Pen(Color.Red);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(tbgianhap.Location.X - LoX - 2, tbgianhap.Location.Y - LoY - 2, tbgianhap.Width + 1, tbgianhap.Height + 1));
        //        }
        //        else if (isTextGiaNhap)
        //        {
        //            Pen pen = new Pen(Color.LawnGreen);
        //            int LoX = pictureBox2.Location.X;
        //            int LoY = pictureBox2.Location.Y;
        //            e.Graphics.DrawRectangle(pen, new Rectangle(tbgianhap.Location.X - LoX - 2, tbgianhap.Location.Y - LoY - 2, tbgianhap.Width + 1, tbgianhap.Height + 1));
        //        }
        //    }
        //    else
        //    {
        //        tbgianhap.BorderStyle = BorderStyle.FixedSingle;
        //    }
        //}

        //MaHH
        private void tbmahanghoa_Enter(object sender, EventArgs e)
        {
            focus = true;
            this.Refresh();
        }
        private void tbmahanghoa_Leave(object sender, EventArgs e)
        {
            if (tbmahanghoa.Text.Trim() == "" || tbmahanghoa.Text.Trim() == null)
            {
                focus = true;
                this.Refresh();
            }
            else
            {
                focus = false;
                this.Refresh();
            }
        }
        private void tbmahanghoa_TextChanged(object sender, EventArgs e)
        {
            isText = true;
            this.Refresh();
        }
        //TenHH
        private void tbtenhanghoa_Enter(object sender, EventArgs e)
        {
            focusTenHH = true;
            this.Refresh();
        }
        private void tbtenhanghoa_Leave(object sender, EventArgs e)
        {
            if (tbtenhanghoa.Text.Trim() == "" || tbtenhanghoa.Text.Trim() == null)
            {
                focusTenHH = true;
                this.Refresh();
            }
            else
            {
                focusTenHH = false;
                this.Refresh();
            }
        }

        private void cbbTenHH_SelectedValueChanged(object sender, EventArgs e)
        {
            using(DAXuongEntities db = new DAXuongEntities())
            {
                var HH = db.hang_hoa.ToList().Where(a => a.ten.Equals(cbbTenHH.Text));
                dataGridView1.Rows.Clear();
                foreach (var item in HH)
                {
                    dataGridView1.Rows.Add(
                        item.ma_hang_hoa,
                        item.ten,
                        item.mota,
                        item.noisx
                        );
                }
            }  
        }

        private void cbbNsx_SelectedValueChanged(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                var HH = db.hang_hoa.ToList().Where(a => a.noisx.Equals(cbbNsx.Text));
                dataGridView1.Rows.Clear();
                foreach (var item in HH)
                {
                    dataGridView1.Rows.Add(
                        item.ma_hang_hoa,
                        item.ten,
                        item.mota,
                        item.noisx
                        );
                }
            }
        }

        private void tbtenhanghoa_TextChanged(object sender, EventArgs e)
        {
            isTextTenHH = true;
            this.Refresh();
        }
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
            ChiTietHangHoa khhh = new ChiTietHangHoa(tbusername.Text);
            khhh.ShowDialog();
            this.Close();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon qlhd = new QuanLyHoaDon(tbusername.Text);
            qlhd.ShowDialog();
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
            this.Hide();
            ThongTinNhanVien thong = new ThongTinNhanVien(tbusername.Text);
            thong.ShowDialog();
            this.Close();
        }
        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHoaDon thong = new ChiTietHoaDon(tbusername.Text);
            thong.ShowDialog();
            this.Close();
        }
    }
}
