using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DUAN1
{
    public static class Constant
    {
        public static Color greyColor = ColorTranslator.FromHtml("#E6E1DD");
        public static Color cyanColor = ColorTranslator.FromHtml("#E2F3FD");
        public static Color yelloColor = ColorTranslator.FromHtml("#FFE1A0");
        public static Color redColor = ColorTranslator.FromHtml("#E07D54");
        public static Color darkGreyColor = ColorTranslator.FromHtml("#899481");
        public static Color blueColor = ColorTranslator.FromHtml("#304F6D");
        public static string connFilePath = "D:\\connectionString.txt";

        public static void ChangeDatabase(this DbContext source)
        {
            String connString = "";
            try
            {
                using (var fileStream = File.OpenRead(connFilePath))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        connString = line;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Không tìm thấy cấu hình cơ sở dữ liệu",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            try
            {
                source.Database.Connection.ConnectionString = connString;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Kết nối cơ sở dữ liệu thất bại",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
