using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;//
using System.Text;//

namespace Chuong4_QLDT
{
    static class Program
    {
        public static SqlConnection MyCon = new SqlConnection(@"Data Source=VanThien;Initial Catalog=QLDIEM;Persist Security Info=True;User ID=sa;Password=Thien2704");
        public static int quyen;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formLogin());
        }
    }
    public class MD5Helper
    {
        public static string CalculateMD5Hash(string input)
        {
            // Chuyển đổi chuỗi vào mảng byte
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Tạo một đối tượng MD5\


            using (MD5 md5 = MD5.Create())
            {
                // Mã hóa mảng byte thành một mảng byte MD5
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi mảng byte MD5 thành chuỗi hex
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
