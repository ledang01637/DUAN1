using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace DUAN1
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            //tbusername.Text = username;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            //using (DAXuongEntities db = new DAXuongEntities())
            //{
            //    Constant.ChangeDatabase(db);
            //    var CTHD = db.chi_tiet_hoa_don.GroupBy(a => a.ma_chitiet_hanghoa).ToList();
            //    foreach (var key in CTHD)
            //    {
            //        foreach (var item in key)
            //        {
            //            var HD = db.chitiet_hanghoa.FirstOrDefault(a => a.id == item.ma_chitiet_hanghoa);

            //            HD.soluong -= item.so_luong;
            //            db.SaveChanges();
            //        }
            //    }
            //}
            try
            {
                DateTime fromDate = dtptungay.Value.Date;
                DateTime toDate = dtpdenngay.Value.Date;

                if (dtptungay.Value.Year <= 1990 || dtpdenngay.Value.Year > DateTime.Today.Year)
                {
                    MessageBox.Show("Năm không nhỏ hơn 1990 và lớn hơn năm hiện tại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (DAXuongEntities db = new DAXuongEntities())
                    {
                        Constant.ChangeDatabase(db);
                        List<hoa_don> listhd = db.hoa_don
                            .Where(x => x.ngay_lap >= fromDate && x.ngay_lap < toDate)
                            .ToList();
                        dataGridView1.Rows.Clear();
                        foreach (var hd in listhd)
                        {
                            int tongtien = 0;
                            int soluong = 0;
                            foreach(var cthd in hd.chi_tiet_hoa_don)
                            {
                                tongtien += (int)cthd.dongia;
                                soluong += (int)cthd.so_luong;
                            }
                            dataGridView1.Rows.Add(
                                hd.ma_hd,
                                DateTime.Parse(hd.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                                tongtien,
                                soluong,
                                hd.chi_tiet_hoa_don.Count(),
                                hd.tongtien.Value.ToString("#,0##")
                            );
                        }

                        //dataGridView1.Rows.Clear();

                        //var hoaDonList = (from hd in db.hoa_don
                        //                  join cthd in db.chi_tiet_hoa_don on hd.ma_hd equals cthd.ma_hd

                        //                  select new
                        //                  {
                        //                      HoaDon = hd,
                        //                      ChiTietHoaDon = cthd,
                        //                  }).GroupBy(a => a.HoaDon.ma_hd);

                        //foreach (var item in hoaDonList)
                        //{
                        //    //var countHD = db.hoa_don.Where(x => x.ma_hd.Equals(item.ChiTietHoaDon.ma_hd)).FirstOrDefault();
                              
                        //    dataGridView1.Rows.Add(
                        //        item.ma_hd,
                        //        DateTime.Parse(item.HoaDon.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                        //        item.ChiTietHoaDon.dongia,
                        //        item.ChiTietHoaDon.so_luong,
                        //        item.HoaDon.chi_tiet_hoa_don.Count(),
                        //        item.HoaDon.chi_tiet_hoa_don.Sum(a => a.dongia).Value.ToString("#,##0")
                        //    );
                        //}
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không để trống");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
           try
            {
                DateTime fromDate = dtptungay.Value.Date;
                DateTime toDate = dtpdenngay.Value.Date;

                if (dtptungay.Value.Year <= 1990 || dtpdenngay.Value.Year > DateTime.Today.Year)
                {
                    MessageBox.Show("Năm không nhỏ hơn 1990 và lớn hơn năm hiện tại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (DAXuongEntities db = new DAXuongEntities())
                    {
                        Constant.ChangeDatabase(db);
                        List<hoa_don> listhd = db.hoa_don
                            .Where(x => x.ngay_lap >= fromDate && x.ngay_lap < toDate)
                            .ToList();

                        dataGridView1.Rows.Clear();

                        var hoaDonList = (from hd in db.hoa_don
                                          join cthd in db.chi_tiet_hoa_don on hd.ma_hd equals cthd.ma_hd

                                          select new
                                          {
                                              HoaDon = hd,
                                              ChiTietHoaDon = cthd,
                                          }).Where(cthd => cthd.HoaDon.ma_hd.Equals(cthd.ChiTietHoaDon.ma_hd)).ToList();

                        foreach (var item in hoaDonList)
                        {
                            //var countHD = db.hoa_don.Where(x => x.ma_hd.Equals(item.ChiTietHoaDon.ma_hd)).FirstOrDefault();

                            dataGridView1.Rows.Add(
                                item.HoaDon.ma_hd,
                                DateTime.Parse(item.HoaDon.ngay_lap.ToString(), CultureInfo.CurrentCulture).ToString("dd/MM/yyyy"),
                                item.ChiTietHoaDon.dongia,
                                item.ChiTietHoaDon.so_luong,
                                item.HoaDon.chi_tiet_hoa_don.Count(),
                                item.HoaDon.chi_tiet_hoa_don.Sum(a => a.dongia).Value.ToString("#,##0")
                            ); ;
                        }
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
