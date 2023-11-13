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

namespace Chuong4_QLDT
{
    public partial class formThemtaikhoan : Form
    {
        public formThemtaikhoan()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            string sql = "select count(*) from taikhoan where id_user = '" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Program.MyCon);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Đã có tài khoản này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string password = MD5Helper.CalculateMD5Hash(txtMatkhau.Text);
                string sqlinsert = @"insert into taikhoan (ID_USER, TENTK, MATKHAU, QUYEN)
                        values (@id, @tentk, @matkhau, @quyen)";
                SqlCommand cmd1 = new SqlCommand(sqlinsert, Program.MyCon);
                cmd1.Parameters.AddWithValue("@id", txtID.Text);
                cmd1.Parameters.AddWithValue("@tentk", txtTenTK.Text);
                cmd1.Parameters.AddWithValue("@matkhau", password);
                cmd1.Parameters.AddWithValue("@quyen", txtQuyen.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd1.Dispose();
            }
            Program.MyCon.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
