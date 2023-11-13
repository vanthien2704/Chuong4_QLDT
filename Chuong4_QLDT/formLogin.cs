using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Chuong4_QLDT
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string enteredPassword = MD5Helper.CalculateMD5Hash(txtMatkhau.Text);
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT TENTK, MATKHAU, QUYEN FROM TAIKHOAN WHERE TENTK = @tentk AND MATKHAU = @matkhau", Program.MyCon);
            cmd.Parameters.AddWithValue("@tentk", txtTenDN.Text);
            cmd.Parameters.AddWithValue("@matkhau", enteredPassword);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Program.quyen = rd.GetInt32(2);
                Program.MyCon.Close();
                formMain formMain = new formMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Program.MyCon.Close();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
