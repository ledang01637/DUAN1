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

namespace DUAN1
{
    public partial class QuanLyHangHoa : Form
    {
        List<hang_hoa> dsHang;
        String imagePath = "";
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
                DateTime.Parse(row.ngay_sx.ToString(), CultureInfo.InvariantCulture).ToShortDateString(),
                DateTime.Parse(row.hsd.ToString(), CultureInfo.InvariantCulture).ToShortDateString(),
                row.gia
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
                var row =  dataGridView1.Rows[cell.RowIndex];

                tbmahanghoa.Text = row.Cells[0].Value?.ToString();
                tbtenhanghoa.Text = row.Cells[1].Value?.ToString();
                dtpngaysanxuat.Value = DateTime.Parse(row.Cells[2].Value?.ToString());
                dtphansudung.Value = DateTime.Parse(row.Cells[3].Value?.ToString());
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
                if (hinhanh == null && hinhanh.Image == null)
                {
                    MessageBox.Show("Vui lòng thêm hình");
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
    }
}
