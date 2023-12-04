﻿using System;
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
        public ThongKe()
        {
            InitializeComponent();
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
                        hoaDon.makho_hangchitiet,
                        DateTime.Parse(hoaDon.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                        hoaDon.thanh_tien,
                        hoaDon.so_luong,
                        khoHang != null ? khoHang.so_luong - hoaDon.so_luong : 0
                    );
                }
            }
        }

        //update
        private void UpdateDGV()
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
                        hoaDon.makho_hangchitiet,
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

            string MaHH = rowData.Cells[0].Value.ToString();
            using (DUAN1Entities db = new DUAN1Entities())
            {
                hoa_don hd = db.hoa_don.FirstOrDefault(x => x.makho_hangchitiet == MaHH);
                khohang_hanghoa khhh = db.khohang_hanghoa.FirstOrDefault(x => x.makho_hangchitiet == MaHH);
                
                cbbmahanghoa.Text = hd.makho_hangchitiet;
                dtpngaylap.Text = hd.ngay_lap.ToString();
                tbgia.Text = hd.thanh_tien.ToString();
                tbsoluongdaban.Text = hd.so_luong.ToString();
                tbsltrongkho.Text = (khhh.so_luong - hd.so_luong).ToString();
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




    }
}
