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
    public partial class formXembangdiem : Form
    {
        public formXembangdiem()
        {
            InitializeComponent();
        }

        private void formXembangdiem_Load(object sender, EventArgs e)
        {
            LoadDL_MaSV();
            Load_DataGridView();
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
            LayTT();
        }
        private void Load_DataGridView()
        {
            string sql = @"select DANGKY.MAMH,TENMH, SOTC, NGAYDK, DIEM 
                            FROM MONHOC INNER JOIN DANGKY ON MONHOC.MAMH = DANGKY.MAMH";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSinhvien.DataSource = dt;
            dgvSinhvien.Columns[0].HeaderText = "Mã môn học";
            dgvSinhvien.Columns[1].HeaderText = "Tên môn học";
            dgvSinhvien.Columns[2].HeaderText = "Số tín chỉ";
            dgvSinhvien.Columns[3].HeaderText = "Ngày đăng ký";
            dgvSinhvien.Columns[4].HeaderText = "Điểm";
            dgvSinhvien.AllowUserToAddRows = false;
            dgvSinhvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayTT();
            Load_DataGridView2();
        }
        private void Load_DataGridView2()
        {
            string sql = @"select DANGKY.MAMH,TENMH, SOTC, NGAYDK, DIEM 
                            FROM MONHOC INNER JOIN DANGKY ON MONHOC.MAMH = DANGKY.MAMH
                             where DANGKY.MASV = '" + cbMaSV.SelectedValue.ToString() + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvSinhvien.DataSource = dt;
        }
        private void LayTT()
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            string sql = @"select masv, HOTEN, (CASE WHEN GIOITINH = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI, ngaysinh
                            from sinhvien where masv = @makhoa";
            SqlCommand cmd = new SqlCommand(sql, Program.MyCon);
            cmd.Parameters.AddWithValue("@MAKHOA", cbMaSV.SelectedValue.ToString());
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtTenSV.Text = rd.GetString(1);
                txtPhai.Text = rd.GetString(2);
                dtpNgaysinh.Value = rd.GetDateTime(3);
            }
            Program.MyCon.Close();
        }
    }
}
