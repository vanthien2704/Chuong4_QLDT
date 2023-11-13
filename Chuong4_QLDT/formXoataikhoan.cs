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
    public partial class formXoataikhoan : Form
    {
        public formXoataikhoan()
        {
            InitializeComponent();
        }

        private void formXoataikhoan_Load(object sender, EventArgs e)
        {
            LoadDL_ID();
        }
        private void LoadDL_ID()
        {
            string sql = @"select ID_USER from TAIKHOAN";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbTenTK.DataSource = dt;
            cbTenTK.DisplayMember = "ID_USER";
            cbTenTK.ValueMember = "ID_USER";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            string sqlDelete = "delete TAIKHOAN WHERE ID_USER = @id";
            SqlCommand cmd = new SqlCommand(sqlDelete, Program.MyCon);
            cmd.Parameters.AddWithValue("@id", cbTenTK.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Dispose();
            Program.MyCon.Close();
            LoadDL_ID();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
