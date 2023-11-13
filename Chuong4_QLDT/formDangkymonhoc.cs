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
    public partial class formDangkymonhoc : Form
    {
        SqlConnection MyCon = new SqlConnection(@"Data Source=VanThien;Initial Catalog=QLDAOTAO;Persist Security Info=True;User ID=sa;Password=Thien2704");

        public formDangkymonhoc()
        {
            InitializeComponent();
        }

        private void formDangkymonhoc_Load(object sender, EventArgs e)
        {
            LoadDL_MaSV();
            LoadDL_MaMH();
        }
        private void LoadDL_MaSV()
        {
            string sql = "select masv from sinhvien";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbMaSV.DataSource = dt;
            cbMaSV.DisplayMember = "masv";
            cbMaSV.ValueMember = "masv";
        }
        private void LoadDL_MaMH()
        {
            string sql = "select mamh from monhoc";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbMaMH.DataSource = dt;
            cbMaMH.DisplayMember = "mamh";
            cbMaMH.ValueMember = "mamh";
            LayTenMH();
        }
        private void LayTenMH()
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT TENMH FROM MONHOC WHERE MAMH = @mamh", Program.MyCon);
            cmd.Parameters.AddWithValue("@mamh", cbMaMH.SelectedValue.ToString());
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtTenMH.Text = rd.GetString(0);
            }
            Program.MyCon.Close();
        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayTenMH();
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql = @"select DANGKY.MAMH, TENMH, SOTC from DANGKY INNER JOIN MONHOC on DANGKY.MAMH = MONHOC.MAMH";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvDSMH.DataSource = dt;
            dgvDSMH.Columns[0].HeaderText = "Mã môn học";
            dgvDSMH.Columns[1].HeaderText = "Tên môn học";
            dgvDSMH.Columns[2].HeaderText = "Số tín chỉ";
            dgvDSMH.AllowUserToAddRows = false;
            dgvDSMH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            string sql = "select count(*) from DANGKY where masv = '" + cbMaSV.Text + "' and mamh = '" + cbMaMH.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Program.MyCon);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Đã đăng ký muôn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sqlinsert = @"insert into DANGKY (MASV, MAMH, NGAYDK)
                        values (@masv, @mamh, @ngaydk)";
                SqlCommand cmd1 = new SqlCommand(sqlinsert, Program.MyCon);
                cmd1.Parameters.AddWithValue("@masv", cbMaSV.Text);
                cmd1.Parameters.AddWithValue("@mamh", cbMaMH.Text);
                cmd1.Parameters.AddWithValue("@ngaydk",  dtpNgayDK.Value);
                cmd1.ExecuteNonQuery();
                Load_DataGridView();
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
