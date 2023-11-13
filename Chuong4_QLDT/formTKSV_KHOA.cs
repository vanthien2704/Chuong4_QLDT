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
    public partial class formTKSV_KHOA : Form
    {
        public formTKSV_KHOA()
        {
            InitializeComponent();
        }
        private void formTKSV_KHOA_Load(object sender, EventArgs e)
        {
            LoadDL_MaKhoa();
        }
        private void LoadDL_MaKhoa()
        {
            string sql = "select makhoa from khoa";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbMakhoa.DataSource = dt;
            cbMakhoa.DisplayMember = "makhoa";
            cbMakhoa.ValueMember = "makhoa";
            LayTenKhoa();
            Load_DataGridView();
            LoadSoSV();
        }

        private void cbMakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DataGridView();
            LayTenKhoa();
            LoadSoSV();
        }
        private void Load_DataGridView()
        {
            string sql = @"select MASV, HOTEN, NGAYSINH, (CASE WHEN GIOITINH = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI, TENKHOA
                            from SINHVIEN INNER JOIN KHOA on SINHVIEN.MAKHOA = KHOA.MAKHOA
                             where KHOA.MAKHOA = '" + cbMakhoa.SelectedValue.ToString() + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSinhvien.DataSource = dt;
            dgvSinhvien.DataSource = dt;
            dgvSinhvien.Columns[0].HeaderText = "Mã sinh viên";
            dgvSinhvien.Columns[1].HeaderText = "Họ tên sinh viên";
            dgvSinhvien.Columns[2].HeaderText = "Ngày sinh";
            dgvSinhvien.Columns[3].HeaderText = "Giới tính";
            dgvSinhvien.Columns[4].HeaderText = "Tên Khoa";
            dgvSinhvien.AllowUserToAddRows = false;
            dgvSinhvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LayTenKhoa()
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT TENKHOA FROM KHOA WHERE MAKHOA = @MAKHOA", Program.MyCon);
            cmd.Parameters.AddWithValue("@MAKHOA", cbMakhoa.SelectedValue.ToString());
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtTenkhoa.Text = rd.GetString(0);
            }
            Program.MyCon.Close();
        }
        private void LoadSoSV()
        {
            int count = dgvSinhvien.RowCount;
            txtTongSoSV.Text = count.ToString();
        }
    }
}
