﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1
{
    public partial class QuanLyHangHoa : Form
    {
        List<hang_hoa> dsHang;
        String imagePath = "";
        bool focus, focusTenHH, focusNSX, focusGia, focusHSD;
        bool isText, isTextTenHH, isTextNSX, isTextGia, isTextHSD;

        public QuanLyHangHoa()
        {
            InitializeComponent();
        }
        private void QuanLyHangHoa_Load(object sender, EventArgs e)
        {
            upDateDataGridView1();
        }
        private void upDateDataGridView1()
        {
            Reset();
            dsHang = DBHanler.getListHang_hoa();
            dataGridView1.Rows.Clear();
            dsHang.ForEach(row => dataGridView1.Rows.Add(
                row.ma_hang_hoa,
                row.ten,
                DateTime.Parse(row.ngay_sx.ToString(), CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"),
                DateTime.Parse(row.hsd.ToString(), CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"),
                row.gia,
                row.hinh
            ));
            dataGridView1.Update();
        }
        public void Reset()
        {
            tbmahanghoa.Text = "";
            tbtenhanghoa.Text = "";
            tbgia.Text = "";
            hinhanh.Image = null;
            dtpngaysanxuat.Value = DateTime.Now;
            dtphansudung.Value = DateTime.Now;
            tbtimkiem.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            tbmahanghoa.Enabled = true;
            tbtenhanghoa.Enabled = true;
            tbgia.Enabled = true;
            dtpngaysanxuat.Enabled = true;
            dtphansudung.Enabled = true;
            hinhanh.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            upDateDataGridView1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cell = (sender as DataGridView).CurrentCell;
                var row = dataGridView1.Rows[cell.RowIndex];

                tbmahanghoa.Text = row.Cells[0].Value?.ToString();
                tbtenhanghoa.Text = row.Cells[1].Value?.ToString();
                //dtpngaysanxuat.Value = DateTime.Parse(row.Cells[2].Value?.ToString(), CultureInfo.InvariantCulture);
                //dtphansudung.Value = DateTime.Parse(row.Cells[3].Value?.ToString(), CultureInfo.InvariantCulture);
                tbgia.Text = row.Cells[4].Value?.ToString();

                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                hang_hoa selectedSP = dsHang[selectedRowIndex];
                if (!String.IsNullOrEmpty(selectedSP.hinh))
                {
                    hinhanh.Image = Image.FromFile(@"" + selectedSP.hinh);
                }
                else
                {
                    hinhanh.Image = null;
                }
                tbmahanghoa.Enabled = false;
                tbtenhanghoa.Enabled = true;
                tbgia.Enabled = true;
                dtpngaysanxuat.Enabled = true;
                dtphansudung.Enabled = true;
                hinhanh.Enabled = true;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            
        }

        private void hinhanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                hinhanh.Image = Image.FromFile(@"" + imagePath);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            float gia;
            if (float.TryParse(tbgia.Text, out gia))
            {
                if (hinhanh == null || hinhanh.Image == null)
                {
                    MessageBox.Show("Vui lòng thêm hình","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if(dtpngaysanxuat.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày sản xuất phải phải <= ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtphansudung.Value < dtpngaysanxuat.Value)
                {
                    MessageBox.Show("HSD phải > NSX", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (gia < 0)
                {
                    MessageBox.Show("Giá phải > 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(tbmahanghoa.Text.Trim() == "" || tbmahanghoa.Text.Trim() == null || tbtenhanghoa.Text.Trim() == "" || tbtenhanghoa.Text.Trim() == null)
                {
                    MessageBox.Show("Không bỏ trống mã, tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                hang_hoa hangHoaAdd = new hang_hoa();
                hangHoaAdd.ma_hang_hoa = tbmahanghoa.Text;
                hangHoaAdd.ten = tbtenhanghoa.Text;
                hangHoaAdd.gia = gia;
                hangHoaAdd.ngay_sx = dtpngaysanxuat.Value;
                hangHoaAdd.hsd = dtphansudung.Value;
                hangHoaAdd.hinh = imagePath;

                if (DBHanler.addHangHoa(hangHoaAdd))
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            float Gia;
            if (float.TryParse(tbgia.Text, out Gia))
            {
                if (hinhanh == null || hinhanh.Image == null)
                {
                    MessageBox.Show("Vui lòng thêm hình", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtpngaysanxuat.Value > DateTime.Now)
                {
                    MessageBox.Show("Ngày sản xuất phải phải <= ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dtphansudung.Value < dtpngaysanxuat.Value)
                {
                    MessageBox.Show("HSD phải > NSX", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Gia < 0)
                {
                    MessageBox.Show("Giá phải > 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbmahanghoa.Text.Trim() == "" || tbmahanghoa.Text.Trim() == null || tbtenhanghoa.Text.Trim() == "" || tbtenhanghoa.Text.Trim() == null)
                {
                    MessageBox.Show("Không bỏ trống mã, tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                hang_hoa selectedHH = dsHang[selectedRowIndex];
                selectedHH.ten = tbtenhanghoa.Text;
                selectedHH.gia = Gia;
                selectedHH.ngay_sx = dtpngaysanxuat.Value;
                selectedHH.hsd = dtphansudung.Value;
                if (hinhanh != null && hinhanh.Image != null)
                {
                    selectedHH.hinh = imagePath;
                }
                if (DBHanler.updateHangHoa(selectedHH))
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Xóa hàng hóa đã chọn ?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (confirmResult == DialogResult.Yes)
            {
                if (tbmahanghoa.Text != null || tbmahanghoa.Text != "")
                {
                    if (DBHanler.deleteHangHoa(tbmahanghoa.Text))
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            using (DUAN1Entities dUAN1Entities = new DUAN1Entities())
            {
                int Gia;
                DateTime nsxhsd;
                try
                {
                    if (DBHanler.timMaTen(tbtimkiem.Text) != null)
                    {
                        hang_hoa hang = DBHanler.timMaTen(tbtimkiem.Text);
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add(
                            hang.ma_hang_hoa,
                            hang.ten,
                            DateTime.Parse(hang.ngay_sx.ToString(), CultureInfo.InvariantCulture).ToShortDateString(),
                            DateTime.Parse(hang.hsd.ToString(), CultureInfo.InvariantCulture).ToShortDateString(),
                            hang.gia
                        );
                        dataGridView1.Update();
                    }
                    else if (int.TryParse(tbtimkiem.Text, out Gia) && DBHanler.timGia(Gia) != null)
                    {
                        hang_hoa hang = DBHanler.timGia(int.Parse(tbtimkiem.Text));
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add(
                            hang.ma_hang_hoa,
                            hang.ten,
                            DateTime.Parse(hang.ngay_sx.ToString(), CultureInfo.InvariantCulture).ToShortDateString(),
                            DateTime.Parse(hang.hsd.ToString(), CultureInfo.InvariantCulture).ToShortDateString(),
                            hang.gia
                        );
                        dataGridView1.Update();
                    }
                    else if (DateTime.TryParse(tbtimkiem.Text, out nsxhsd) && DBHanler.timNSXHSD(nsxhsd) != null)
                    {
                        Reset();
                        hang_hoa hang = DBHanler.timNSXHSD(DateTime.Parse(tbtimkiem.Text));
                        
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show("Tìm không thấy", "Thông báo", MessageBoxButtons.OK);
                }  
            }  
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            //MaHH
            if (focus)
            {
                if (tbmahanghoa.Text.Trim() == "" || tbmahanghoa.Text.Trim() == null)
                {
                    Pen pen = new Pen(Color.Red);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(tbmahanghoa.Location.X - LoX - 2, tbmahanghoa.Location.Y - LoY - 2, tbmahanghoa.Width + 1, tbmahanghoa.Height + 1));
                }
                else if (isText)
                {
                    Pen pen = new Pen(Color.LawnGreen);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(tbmahanghoa.Location.X - LoX - 2, tbmahanghoa.Location.Y - LoY - 2, tbmahanghoa.Width + 1, tbmahanghoa.Height + 1));
                }
            }
            else
            {
                tbmahanghoa.BorderStyle = BorderStyle.FixedSingle;
            }
            //TenHH
            if (focusTenHH)
            {
                if (tbtenhanghoa.Text.Trim() == "" || tbtenhanghoa.Text.Trim() == null)
                {
                    Pen pen = new Pen(Color.Red);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(tbtenhanghoa.Location.X - LoX - 2, tbtenhanghoa.Location.Y - LoY - 2, tbtenhanghoa.Width + 1, tbtenhanghoa.Height + 1));
                }
                else if (isTextTenHH)
                {
                    Pen pen = new Pen(Color.LawnGreen);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(tbtenhanghoa.Location.X - LoX - 2, tbtenhanghoa.Location.Y - LoY - 2, tbtenhanghoa.Width + 1, tbtenhanghoa.Height + 1));
                }
            }
            else
            {
                tbtenhanghoa.BorderStyle = BorderStyle.FixedSingle;
            }
            //NgaySX
            if (focusNSX)
            {
                if (dtpngaysanxuat.Value > DateTime.Now)
                {
                    Pen pen = new Pen(Color.Red);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(dtpngaysanxuat.Location.X - LoX - 2, dtpngaysanxuat.Location.Y - LoY - 2, dtpngaysanxuat.Width + 1, dtpngaysanxuat.Height + 1));
                }
                else if (isTextNSX)
                {
                    Pen pen = new Pen(Color.LawnGreen);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(dtpngaysanxuat.Location.X - LoX - 2, dtpngaysanxuat.Location.Y - LoY - 2, dtpngaysanxuat.Width + 1, dtpngaysanxuat.Height + 1));
                }
            }
            //HSD
            if (focusHSD)
            {
                if (dtphansudung.Value < dtpngaysanxuat.Value)
                {
                    Pen pen = new Pen(Color.Red);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(dtphansudung.Location.X - LoX - 2, dtphansudung.Location.Y - LoY - 2, dtphansudung.Width + 1, dtphansudung.Height + 1));
                }
                else if (isTextHSD)
                {
                    Pen pen = new Pen(Color.LawnGreen);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(dtphansudung.Location.X - LoX - 2, dtphansudung.Location.Y - LoY - 2, dtphansudung.Width + 1, dtphansudung.Height + 1));
                }
            }
            //Gia
            if (focusGia)
            {
                float Gia;
                var isNumber = float.TryParse(tbgia.Text, out Gia);
                if (isNumber == false || Gia < 0)
                {
                    Pen pen = new Pen(Color.Red);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(tbgia.Location.X - LoX - 2, tbgia.Location.Y - LoY - 2, tbgia.Width + 1, tbgia.Height + 1));
                }
                else if (isTextGia)
                {
                    Pen pen = new Pen(Color.LawnGreen);
                    int LoX = pictureBox2.Location.X;
                    int LoY = pictureBox2.Location.Y;
                    e.Graphics.DrawRectangle(pen, new Rectangle(tbgia.Location.X - LoX - 2, tbgia.Location.Y - LoY - 2, tbgia.Width + 1, tbgia.Height + 1));
                }
            }
            else
            {
                tbgia.BorderStyle = BorderStyle.FixedSingle;
            }
        }

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
        private void tbtenhanghoa_TextChanged(object sender, EventArgs e)
        {
            isTextTenHH = true;
            this.Refresh();
        }
        //NSX
        private void dtpngaysanxuat_Enter(object sender, EventArgs e)
        {
            focusNSX = true;
            this.Refresh();
        }
        private void dtpngaysanxuat_Leave(object sender, EventArgs e)
        {
            if (dtpngaysanxuat.Value > DateTime.Now)
            {
                focusNSX = true;
                this.Refresh();
            }
            else
            {
                focusNSX = false;
                this.Refresh();
            }
        }
        private void dtpngaysanxuat_ValueChanged(object sender, EventArgs e)
        {
            isTextNSX = true;
            this.Refresh();
        }
        //HSD
        private void dtphansudung_Enter(object sender, EventArgs e)
        {
            focusHSD = true;
            this.Refresh();
        }
        private void dtphansudung_Leave(object sender, EventArgs e)
        {
            if (dtphansudung.Value < dtpngaysanxuat.Value)
            {
                focusHSD = true;
                this.Refresh();
            }
            else
            {
                focusHSD = false;
                this.Refresh();
            }
        }
        private void dtphansudung_ValueChanged(object sender, EventArgs e)
        {
            isTextHSD = true;
            this.Refresh();
        }
        //Gia
        private void tbgia_Enter(object sender, EventArgs e)
        {
            focusGia = true;
            this.Refresh();
        }
        private void tbgia_Leave(object sender, EventArgs e)
        {
            float Gia;
            var isNumber = float.TryParse(tbgia.Text, out Gia);
            if (isNumber == false || Gia < 0)
            {
                focusGia = true;
                this.Refresh();
            }
            else
            {
                focusGia = false;
                this.Refresh();
            }
        }
        private void tbgia_TextChanged(object sender, EventArgs e)
        {
            isTextGia = true;
            this.Refresh();
        }
    }
}
