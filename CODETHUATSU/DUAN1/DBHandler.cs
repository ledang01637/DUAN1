﻿using System;
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
        //public static bool updateCTKH(khohang_hanghoa updateKHHH)
        //{
        //    //using (DUAN1Entities KHHH = new DUAN1Entities())
        //    //{
        //    //    try
        //    //    {
        //    //        khohang_hanghoa found = KHHH.khohang_hanghoa
        //    //            .FirstOrDefault(sp => sp.makho_hangchitiet.Equals(updateKHHH.makho_hangchitiet));
        //    //        found.so_luong = updateKHHH.so_luong;
        //    //        KHHH.SaveChanges();
        //    //        return true;
        //    //    }
        //    //    catch
        //    //    {
        //    //        return false;
        //    //    }
        //    //}
        //}
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
