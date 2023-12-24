using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1
{
    public partial class ChiTietHoaDon : Form
    {
        public static int MaCTHH = 0;
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                //mã háo đơn
                cbbmahoadon.Items.Clear();
                db.hoa_don.ToList().ForEach(row => cbbmahoadon.Items.Add(row.ma_hd));
                //mã chi tiết kho hàng hàng hóa
                cbbmahanghoachitiet.Items.Clear();
                db.chitiet_hanghoa.ToList().ForEach(row => cbbmahanghoachitiet.Items.Add(row.hang_hoa.ten));
                cbbIDSP.Items.Clear();
                db.chitiet_hanghoa.ToList().ForEach(row => cbbIDSP.Items.Add(row.id));

                dataGridView1.Rows.Clear();
                var cthh = db.chitiet_hanghoa.ToList();
                foreach (var item in cthh)
                {
                    var cthd = db.chi_tiet_hoa_don.Where(a => a.ma_chitiet_hanghoa == item.id);
                    cthd.ToList().ForEach(row =>
                    {
                        dataGridView1.Rows.Add(
                        row.macthd,
                        row.ma_hd,
                        row.chitiet_hanghoa.hang_hoa.ten,
                        row.so_luong,
                        row.dongia,
                        row.chitiet_hanghoa.size,
                        row.chitiet_hanghoa.mau_sac
                        );
                    }
                    );
                }
                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                btnhuy.Enabled = true;
                btnluu.Enabled = false;

                tbmachitiethoadon.ReadOnly = true;
                cbbmahoadon.Enabled = false;
                cbbmahanghoachitiet.Enabled = false;
                tbdongia.ReadOnly = true;
                tbsoluong.ReadOnly = true;
            }
        }
        private void UpdateDGV()
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                //mã háo đơn
                cbbmahoadon.Items.Clear();
                db.hoa_don.ToList().ForEach(row => cbbmahoadon.Items.Add(row.ma_hd));
                //mã chi tiết kho hàng hàng hóa
                cbbmahanghoachitiet.Items.Clear();
                db.chitiet_hanghoa.ToList().ForEach(row => cbbmahanghoachitiet.Items.Add(row.hang_hoa.ten));
                cbbIDSP.Items.Clear();
                db.chitiet_hanghoa.ToList().ForEach(row => cbbIDSP.Items.Add(row.id));

                dataGridView1.Rows.Clear();
                var cthh = db.chitiet_hanghoa.ToList();
                foreach (var item in cthh)
                {
                    var cthd = db.chi_tiet_hoa_don.Where(a => a.ma_chitiet_hanghoa == item.id);
                    cthd.ToList().ForEach(row =>
                    {
                        dataGridView1.Rows.Add(
                        row.macthd,
                        row.ma_hd,
                        row.chitiet_hanghoa.hang_hoa.ten,
                        row.so_luong,
                        row.dongia,
                        row.chitiet_hanghoa.size,
                        row.chitiet_hanghoa.mau_sac
                        );
                    }
                    );
                }
            }
        }
        //private void ThongKe()
        //{
        //    using (DAXuongEntities db = new DAXuongEntities())
        //    {
        //        var cthh = db.chitiet_hanghoa.Where(x => x.hang_hoa.ten.Equals(cbbmahanghoachitiet.Text)).ToList();
        //        foreach(var item in cthh)
        //        {
        //            if (cthh != null)
        //            {
        //                item.soluong -= int.Parse(tbsoluong.Text);
        //                db.SaveChanges();
        //            }
        //        }  
        //    }
        //}
        //btn thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;

            tbmachitiethoadon.ReadOnly = true;
            cbbmahoadon.Enabled = true;
            cbbmahanghoachitiet.Enabled = true;
            tbdongia.ReadOnly = true;
            tbsoluong.ReadOnly = false;
        }
        //btn lưu
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    Constant.ChangeDatabase(db);
                    chi_tiet_hoa_don cthd = new chi_tiet_hoa_don();

                    chitiet_hanghoa cthh = db.chitiet_hanghoa.FirstOrDefault(x => x.hang_hoa.ten.Equals(cbbmahanghoachitiet.Text));

                    cthd.ma_hd = cbbmahoadon.Text;

                    cthd.ma_chitiet_hanghoa = cthh.id;

                    if (int.Parse(tbsoluong.Text) > 0)
                    {
                        if ((cthd.so_luong - int.Parse(tbsoluong.Text)) < 0)
                        {
                            MessageBox.Show("Số lượng phải bé hơn hoặc bằng số lượng trong kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            cthd.so_luong = int.Parse(tbsoluong.Text);
                            cthd.dongia = cthh.gia_ban * cthd.so_luong;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    db.chi_tiet_hoa_don.Add(cthd);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    //ThongKe();
                    UpdateDGV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không được để trống");
            }
        }
        //btn xóa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maCTHD = int.Parse(tbmachitiethoadon.Text);
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    Constant.ChangeDatabase(db);
                    chi_tiet_hoa_don delete = db.chi_tiet_hoa_don.Where(x => x.macthd == maCTHD).FirstOrDefault();

                    db.chi_tiet_hoa_don.Remove(delete);
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
        //btn sửa
        private void btnsua_Click(object sender, EventArgs e)
        {
            int maCTHD = int.Parse(tbmachitiethoadon.Text);
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                chi_tiet_hoa_don edit = db.chi_tiet_hoa_don.FirstOrDefault(x => x.macthd == maCTHD);

                chitiet_hanghoa cthh = db.chitiet_hanghoa.FirstOrDefault(x => x.hang_hoa.ten.Equals(cbbmahanghoachitiet.Text));

                if (edit != null)
                {
                    edit.macthd = int.Parse(tbmachitiethoadon.Text);
                    edit.ma_hd = cbbmahoadon.Text;
                    edit.ma_chitiet_hanghoa = cthh.id;
                    if (int.Parse(tbsoluong.Text) <= 0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    edit.so_luong = int.Parse(tbsoluong.Text);
                    edit.dongia = edit.so_luong * cthh.gia_ban;
                    db.SaveChanges();
                    //ThongKe();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn");
                }

                UpdateDGV();
            }
        }
        // xem hiển thị
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];
            int MaCTHD = int.Parse(rowData.Cells[0].Value.ToString());
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                chi_tiet_hoa_don cthd = db.chi_tiet_hoa_don.Where(x => x.macthd == MaCTHD).FirstOrDefault();

                if (cthd != null)
                {
                    tbmachitiethoadon.Text = cthd.macthd.ToString();
                    cbbmahoadon.Text = cthd.ma_hd;
                    cbbmahanghoachitiet.Text = cthd.chitiet_hanghoa.hang_hoa.ten;
                    tbsoluong.Text = cthd.so_luong.ToString();
                    tbdongia.Text = cthd.dongia.ToString();
                }

                btnxoa.Enabled = true;
                btnsua.Enabled = true;
                btnhuy.Enabled = true;
                btnluu.Enabled = false;

                tbmachitiethoadon.ReadOnly = false;
                cbbmahoadon.Enabled = true;
                cbbmahanghoachitiet.Enabled = true;
                tbdongia.ReadOnly = false;
                tbsoluong.ReadOnly = false;
            }
        }
        //btn hủy
        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;

            tbmachitiethoadon.ReadOnly = true;
            cbbmahoadon.Enabled = false;
            cbbmahanghoachitiet.Enabled = false;
            tbdongia.ReadOnly = true;
            tbsoluong.ReadOnly = true;

            tbmachitiethoadon.Text = " ";
            cbbmahoadon.Text = " ";
            cbbmahanghoachitiet.Text = " ";
            tbsoluong.Text = " ";
            tbdongia.Text = " ";
            tbtimkiem.Text = "";
            UpdateDGV();

        }
        //btn tìm kiếm
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
                    Constant.ChangeDatabase(db);
                    List<chi_tiet_hoa_don> listhd = db.chi_tiet_hoa_don.Where(x => x.ma_hd.Equals(tbtimkiem.Text)).ToList();
                    dataGridView1.Rows.Clear();
                    listhd.ToList().ForEach(cthd =>
                    {
                        dataGridView1.Rows.Add(
                        cthd.macthd,
                        cthd.ma_hd,
                        cthd.chitiet_hanghoa.hang_hoa.ten,
                        cthd.so_luong,
                        cthd.dongia,
                        cthd.chitiet_hanghoa.size,
                        cthd.chitiet_hanghoa.mau_sac
                        );
                    }
                    );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }
        //
        private void QuetMaQR_Click(object sender, EventArgs e)
        {
            QuetQR quetQR = new QuetQR();
            quetQR.FormClosing += new FormClosingEventHandler(ChiTietHoaDon_FormClosing);
            quetQR.ShowDialog();
        }
        private void ChiTietHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MaCTHH > 0)
            {
                using (DAXuongEntities db = new DAXuongEntities())
                {
                    Constant.ChangeDatabase(db);
                    chitiet_hanghoa cthh = db.chitiet_hanghoa.FirstOrDefault(a => a.id == MaCTHH);
                    chi_tiet_hoa_don cthd = new chi_tiet_hoa_don();
                    cthd.ma_hd = "HD001";
                    cthd.ma_chitiet_hanghoa = cthh.id;
                    cthd.so_luong = 1;
                    cthd.dongia = cthh.gia_ban * cthd.so_luong;
                    db.chi_tiet_hoa_don.Add(cthd);
                    db.SaveChanges();
                    UpdateDGV();
                    //ThongKe(); 
                }
            }
        }
        private readonly PrintDocument docToPrint = new PrintDocument();
        readonly int x = 0;
        readonly int y = 0;
        readonly int height = 30;
        readonly int width = 220;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string a = tbmachitiethoadon.Text;
            if (string.IsNullOrEmpty(tbmachitiethoadon.Text))
            {
                MessageBox.Show("Lỗi không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrintDialog PrintDialog1 = new PrintDialog();
                docToPrint.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", width, height + 200);
                PrintDialog1.AllowSomePages = true;
                PrintDialog1.ShowHelp = true;
                PrintDialog1.Document = docToPrint;

                DialogResult result = PrintDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    docToPrint.PrintPage += new PrintPageEventHandler(document_PrintPage);
                    docToPrint.Print();
                }
            }
        }
        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (DAXuongEntities entities = new DAXuongEntities())
            {
                Constant.ChangeDatabase(entities);
                string title = "HÓA ĐƠN BÁN HÀNG";
                StringFormat stringFormat = new StringFormat(StringFormatFlags.NoClip);
                Rectangle rectangle = new Rectangle(x + 1, y, width, height);
                stringFormat.LineAlignment = StringAlignment.Center;
                stringFormat.Alignment = StringAlignment.Center;
                Font printFont = new Font("Arial", 11, FontStyle.Bold);
                e.Graphics.DrawString(title, printFont, Brushes.Black, rectangle, stringFormat);

                string head = "ShopQuanAoCodeThuatSu\nĐịa chỉ: Cần Thơ\n\n\n";
                StringFormat stringFormat2 = new StringFormat(StringFormatFlags.NoClip);
                Rectangle rectangle2 = new Rectangle(x + 1, y + height, width, height + 30);
                stringFormat2.LineAlignment = StringAlignment.Center;
                stringFormat2.Alignment = StringAlignment.Center;
                Font printFont2 = new Font("Arial", 10, FontStyle.Regular);
                e.Graphics.DrawString(head, printFont2, Brushes.Black, rectangle2, stringFormat2);


                var cthd = entities.chi_tiet_hoa_don.ToList().Where(a => a.ma_hd.Equals(cbbmahoadon.Text));
                double TongTien = 0;
                //Demo
                //Ten
                string Ten = "\n\nTên";
                string TenHang = "";
                StringFormat stringFormat3 = new StringFormat(StringFormatFlags.NoClip);
                Rectangle rectangle3 = new Rectangle(x + 1, y + height, width, height + 30);
                stringFormat3.LineAlignment = StringAlignment.Near;
                stringFormat3.Alignment = StringAlignment.Near;
                Font printFont3 = new Font("Arial", 10, FontStyle.Regular);
                Pen pen = new Pen(Color.Red);
                e.Graphics.DrawString(Ten, printFont3, Brushes.Black, rectangle3, stringFormat3);
                int cao = 50;
                foreach (var item in cthd)
                {
                    StringFormat stringFormatBody = new StringFormat(StringFormatFlags.NoClip);
                    Rectangle rectangleBody = new Rectangle(x + 1, y + cao + 30, width, height);
                    stringFormatBody.LineAlignment = StringAlignment.Near;
                    stringFormatBody.Alignment = StringAlignment.Near;
                    Font printFontBody = new Font("Arial", 9, FontStyle.Regular);
                    TenHang = item.chitiet_hanghoa.hang_hoa.ten;
                    e.Graphics.DrawString(TenHang, printFontBody, Brushes.Black, rectangleBody, stringFormatBody);
                    cao += 20;
                }

                //GiaSL
                string GiaSL = "\n\nGiá   SL";
                int SL = 0;
                double Gia = 0;
                StringFormat stringFormat4 = new StringFormat(StringFormatFlags.NoClip);
                Rectangle rectangle4 = new Rectangle(x + 1, y + height - 5, width, height + 30);
                stringFormat4.LineAlignment = StringAlignment.Center;
                stringFormat4.Alignment = StringAlignment.Center;
                Font printFont4 = new Font("Arial", 10, FontStyle.Regular);
                e.Graphics.DrawString(GiaSL, printFont4, Brushes.Black, rectangle4, stringFormat4);
                int cao1 = 50;
                foreach (var item in cthd)
                {
                    StringFormat stringFormatBody = new StringFormat(StringFormatFlags.NoClip);
                    Rectangle rectangleBody = new Rectangle(x + 1, y + cao1 + 20, width, height);
                    stringFormatBody.LineAlignment = StringAlignment.Center;
                    stringFormatBody.Alignment = StringAlignment.Center;
                    Font printFontBody = new Font("Arial", 9, FontStyle.Regular);
                    Gia = (double)item.chitiet_hanghoa.gia_ban / 1000;
                    SL = (int)item.so_luong;
                    e.Graphics.DrawString(Gia.ToString("#,##0") + "  " + SL, printFontBody, Brushes.Black, rectangleBody, stringFormatBody);
                    cao1 += 20;
                }


                //TT
                string TT = "\n\nThành tiền";
                double ThanhTien = 0;
                StringFormat stringFormat5 = new StringFormat(StringFormatFlags.NoClip);
                Rectangle rectangle5 = new Rectangle(x + 1, y + height - 10, width, height + 30);
                stringFormat5.LineAlignment = StringAlignment.Far;
                stringFormat5.Alignment = StringAlignment.Far;
                Font printFont5 = new Font("Arial", 10, FontStyle.Regular);
                e.Graphics.DrawString(TT, printFont5, Brushes.Black, rectangle5, stringFormat5);
                int cao2 = 50;
                foreach (var item in cthd)
                {
                    StringFormat stringFormatBody = new StringFormat(StringFormatFlags.NoClip);
                    Rectangle rectangleBody = new Rectangle(x + 1, y + cao2 + 10, width, height);
                    stringFormatBody.LineAlignment = StringAlignment.Far;
                    stringFormatBody.Alignment = StringAlignment.Far;
                    Font printFontBody = new Font("Arial", 9, FontStyle.Regular);
                    ThanhTien = (double)item.dongia / 1000;
                    TongTien += ThanhTien;
                    e.Graphics.DrawString(ThanhTien.ToString("#,##0"), printFontBody, Brushes.Black, rectangleBody, stringFormatBody);
                    cao2 += 20;
                }
                #region Demo
                //Demo
                //string TenHang = "";
                //double Gia = 0;
                //int SL = 0;
                //int cao = 50;
                //double TongTien = 0;
                //double ThanhTien = 0;
                //var cthd = entities.chi_tiet_hoa_don.ToList().Where(a => a.ma_hd.Equals(cbbmahoadon.Text));
                //foreach (var item in cthd)
                //{
                //    StringFormat stringFormatBody = new StringFormat(StringFormatFlags.NoClip);
                //    Rectangle rectangleBody = new Rectangle(x + 1, y + cao + 30, width, height);
                //    stringFormatBody.LineAlignment = StringAlignment.Center;
                //    stringFormatBody.Alignment = StringAlignment.Center;
                //    Font printFontBody = new Font("Arial", 9, FontStyle.Regular);
                //    TenHang = item.chitiet_hanghoa.hang_hoa.ten;
                //    Gia = (double)item.chitiet_hanghoa.gia_ban / 1000;
                //    SL = (int)item.so_luong;
                //    ThanhTien = (double)item.dongia / 1000;
                //    TongTien += ThanhTien;
                //    e.Graphics.DrawString(TenHang + "  " + Gia.ToString("#,##0") + "  " + SL + "  " + ThanhTien.ToString("#,##0"), printFontBody, Brushes.Black, rectangleBody, stringFormatBody);
                //    cao += 20;
                //}
                #endregion
                StringFormat stringFormatFooter = new StringFormat(StringFormatFlags.NoClip);
                Rectangle rectangleFooter = new Rectangle(x + 1, y + cao + 30, width, height);
                stringFormatFooter.LineAlignment = StringAlignment.Center;
                stringFormatFooter.Alignment = StringAlignment.Center;
                Font printFontFooter = new Font("Arial", 10, FontStyle.Regular);
                e.Graphics.DrawString("----------\nTổng tiền: " + TongTien.ToString("#,##0"), printFontFooter, Brushes.Black, rectangleFooter, stringFormatFooter);
            }
        }

        private void cbbIDSP_TextChanged(object sender, EventArgs e)
        {
            using (DAXuongEntities db = new DAXuongEntities())
            {
                Constant.ChangeDatabase(db);
                int ID = int.Parse(cbbIDSP.Text);
                chitiet_hanghoa cthh = db.chitiet_hanghoa.FirstOrDefault(a => a.id == ID);
                cbbmahanghoachitiet.Text = cthh.hang_hoa.ten;
            }
        }
    }
}
