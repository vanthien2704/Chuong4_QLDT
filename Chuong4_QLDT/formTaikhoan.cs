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
    public partial class formTaikhoan : Form
    {
        public formTaikhoan()
        {
            InitializeComponent();
        }

        private void formTaikhoan_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql = @"select ID_USER, TENTK, QUYEN from TAIKHOAN";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvDSTK.DataSource = dt;
            dgvDSTK.DataSource = dt;
            dgvDSTK.Columns[0].HeaderText = "ID USER";
            dgvDSTK.Columns[1].HeaderText = "Tên tài khoản";
            dgvDSTK.Columns[2].HeaderText = "Quyền";
            dgvDSTK.AllowUserToAddRows = false;
            dgvDSTK.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDSTK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            formThemtaikhoan formThemtaikhoan = new formThemtaikhoan();
            //formThemtaikhoan.MdiParent = this;
            formThemtaikhoan.Show();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            formXoataikhoan formXoataikhoan = new formXoataikhoan();
            //formXoataikhoan.MdiParent = this;
            formXoataikhoan.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
