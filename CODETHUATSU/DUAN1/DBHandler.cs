using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1
{
    class DBHandler
    {
        public static String Login(String username, String password)
        {

            using (DAXuongEntities csharpDB = new DAXuongEntities())
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return null;
                }

                dang_nhap found = csharpDB.dang_nhap
                    .FirstOrDefault(row => row.tai_khoan.Equals(username.Trim()));

                if (found != null && found.mat_khau.Trim().Equals(password))
                {
                    string phanquyen = found.role.Trim();
                    return phanquyen;
                }
                return null;
            }
        }
        public string GetMD5(String chuoi)
        {
            String str_Md5 = "";
            byte[] mang = Encoding.UTF8.GetBytes(chuoi);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            mang = md5.ComputeHash(mang);
            foreach (byte b in mang)
            {
                str_Md5 += b.ToString();
            }
            return str_Md5;
        }
        #region HangHoa
        //HangHoa
        public static List<hang_hoa> getListHang_hoa()
        {
            List<hang_hoa> dsHang = new List<hang_hoa>();
            using (DAXuongEntities HangHoa_ = new DAXuongEntities())
            {
                dsHang = HangHoa_.hang_hoa.ToList();
            }
            return dsHang;
        }
        public static bool addHangHoa(hang_hoa hhAdd)
        {
            using (DAXuongEntities HangHoa_ = new DAXuongEntities())
            {
                try
                {
                    HangHoa_.hang_hoa.Add(hhAdd);
                    HangHoa_.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static bool deleteHangHoa(string MaHH)
        {
            using (DAXuongEntities HangHoa_ = new DAXuongEntities())
            {
                try
                {
                    hang_hoa found = HangHoa_.hang_hoa
                        .FirstOrDefault(sp => sp.ma_hang_hoa.Equals(MaHH));
                    HangHoa_.hang_hoa.Remove(found);
                    HangHoa_.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static bool updateHangHoa(hang_hoa hangHoaUpdate)
        {
            using (DAXuongEntities HangHoa_ = new DAXuongEntities())
            {
                try
                {
                    hang_hoa found = HangHoa_.hang_hoa
                        .FirstOrDefault(sp => sp.ma_hang_hoa.Equals(hangHoaUpdate.ma_hang_hoa));
                    found.ten = hangHoaUpdate.ten;
                    found.mota = hangHoaUpdate.mota;
                    found.noisx = hangHoaUpdate.noisx;
                    HangHoa_.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        #endregion
        #region ChiThietHangHoa
        public static List<chitiet_hanghoa> getListChiTietHangHoa()
        {
            List<chitiet_hanghoa> dsCTHang = new List<chitiet_hanghoa>();
            using (DAXuongEntities CTHangHoa_ = new DAXuongEntities())
            {
                dsCTHang = CTHangHoa_.chitiet_hanghoa.ToList();
            }
            return dsCTHang;
        }
        public static bool addChiTietHangHoa(chitiet_hanghoa CThhAdd)
        {
            using (DAXuongEntities CTHangHoa_ = new DAXuongEntities())
            {
                try
                {
                    CTHangHoa_.chitiet_hanghoa.Add(CThhAdd);
                    CTHangHoa_.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        //public static bool deleteChiTietHangHoa(string MaHH)
        //{
        //    using (DAXuongEntities HangHoa_ = new DAXuongEntities())
        //    {
        //        try
        //        {
        //            hang_hoa found = HangHoa_.hang_hoa
        //                .FirstOrDefault(sp => sp.ma_hang_hoa.Equals(MaHH));
        //            HangHoa_.hang_hoa.Remove(found);
        //            HangHoa_.SaveChanges();
        //            return true;
        //        }
        //        catch
        //        {
        //            return false;
        //        }
        //    }
        //}
        public static bool updateChiTietHangHoa(chitiet_hanghoa CThangHoaUpdate)
        {
            using (DAXuongEntities CTHangHoa_ = new DAXuongEntities())
            {
                try
                {
                    chitiet_hanghoa found = CTHangHoa_.chitiet_hanghoa
                        .FirstOrDefault(sp => sp.id.Equals(CThangHoaUpdate.id));
                    found.ma_hang_hoa = CThangHoaUpdate.ma_hang_hoa;
                    found.size = CThangHoaUpdate.size;
                    found.mau_sac = CThangHoaUpdate.mau_sac;
                    found.soluong = CThangHoaUpdate.soluong;
                    found.hinh = CThangHoaUpdate.hinh;
                    CTHangHoa_.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        #endregion
        public static hang_hoa timMaTen(string MaTen)
        {
            using (DAXuongEntities dUAN1Entities = new DAXuongEntities())
            {
                hang_hoa hang_Hoa = dUAN1Entities.hang_hoa.FirstOrDefault(a => a.ma_hang_hoa.Equals(MaTen) || a.ten.Equals(MaTen));
                if (hang_Hoa != null)
                {
                    return hang_Hoa;
                }
                return null;
            }
        }

        public static String CheckTK(String username)
        {

            using (DAXuongEntities csharpDB = new DAXuongEntities())
            {
                if (string.IsNullOrWhiteSpace(username))
                {
                    return null;
                }

                dang_nhap found = csharpDB.dang_nhap
                    .FirstOrDefault(row => row.tai_khoan.Equals(username.Trim()));

                if (found != null )
                {
                    string phanquyen = found.role.Trim();
                    return phanquyen;
                }
                return null;
            }
        }
    }

}
