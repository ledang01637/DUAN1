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
        //bool focus, focusTenHH, focusNSX, focusGia, focusHSD, foucusGiaNhap;
        //bool isText, isTextTenHH, isTextNSX, isTextGia, isTextHSD, isTextGiaNhap;

        public QuanLyHangHoa()
        {
            InitializeComponent();
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
        private void cbbTenHH_SelectedValueChanged(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
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
        //#region
        //private void tbmahanghoa_Enter(object sender, EventArgs e)
        //{
        //    focus = true;
        //    this.Refresh();
        //}
        //private void tbmahanghoa_Leave(object sender, EventArgs e)
        //{
        //    if (tbmahanghoa.Text.Trim() == "" || tbmahanghoa.Text.Trim() == null)
        //    {
        //        focus = true;
        //        this.Refresh();
        //    }
        //    else
        //    {
        //        focus = false;
        //        this.Refresh();
        //    }
        //}
        //private void tbmahanghoa_TextChanged(object sender, EventArgs e)
        //{
        //    isText = true;
        //    this.Refresh();
        //}
        ////TenHH
        //private void tbtenhanghoa_Enter(object sender, EventArgs e)
        //{
        //    focusTenHH = true;
        //    this.Refresh();
        //}
        //private void tbtenhanghoa_Leave(object sender, EventArgs e)
        //{
        //    if (tbtenhanghoa.Text.Trim() == "" || tbtenhanghoa.Text.Trim() == null)
        //    {
        //        focusTenHH = true;
        //        this.Refresh();
        //    }
        //    else
        //    {
        //        focusTenHH = false;
        //        this.Refresh();
        //    }
        //}
        //private void tbtenhanghoa_TextChanged(object sender, EventArgs e)
        //{
        //    isTextTenHH = true;
        //    this.Refresh();
        //}
        //#endregion
    }
}
