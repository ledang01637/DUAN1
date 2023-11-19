using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1
{
    class DBHandler
    {
        public static String Login(String username, String password)
        {

            using (DUAN1Entities csharpDB = new DUAN1Entities())
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
    }
}
