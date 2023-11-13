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
    public partial class formNhapdiemsinhvien : Form
    {
        public formNhapdiemsinhvien()
        {
            InitializeComponent();
        }

        private void formNhapdiemsinhvien_Load(object sender, EventArgs e)
        {
            LoadDL_MaSV();
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
            Load_DataGridView();
        }
        private void LayTT()
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            string sql = @"select masv, HOTEN
                            from sinhvien where masv = @makhoa";
            SqlCommand cmd = new SqlCommand(sql, Program.MyCon);
            cmd.Parameters.AddWithValue("@MAKHOA", cbMaSV.SelectedValue.ToString());
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtTenSV.Text = rd.GetString(1);
            }
            Program.MyCon.Close();
        }
        private void Load_DataGridView()
        {
            string sql = @"select DANGKY.MAMH, TENMH, NGAYDK, DIEM from DANGKY INNER JOIN MONHOC on DANGKY.MAMH = MONHOC.MAMH
                            WHERE MASV = '" + cbMaSV.SelectedValue.ToString() + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Program.MyCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvBangdiem.DataSource = dt;
            dgvBangdiem.Columns[0].HeaderText = "Mã môn học";
            dgvBangdiem.Columns[1].HeaderText = "Tên môn học";
            dgvBangdiem.Columns[2].HeaderText = "Ngày đăng ký";
            dgvBangdiem.Columns[3].HeaderText = "Điểm thi";
            dgvBangdiem.AllowUserToAddRows = false;
            dgvBangdiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayTT();
            Load_DataGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy chỉ số hàng đang được chọn trong DataGridView
            int dong = dgvBangdiem.CurrentRow.Index;
            //
            string mamh = dgvBangdiem.Rows[dong].Cells[0].Value.ToString();
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            string sqlupdate = @"update DANGKY set DIEM = @diem, MASV = @masv WHERE MASV = @masv and MAMH = @mamh ";
            SqlCommand cmd = new SqlCommand(sqlupdate, Program.MyCon);
            cmd.Parameters.AddWithValue("@diem", txtDiem.Text);
            cmd.Parameters.AddWithValue("@masv", cbMaSV.Text);
            cmd.Parameters.AddWithValue("@mamh", mamh);
            cmd.ExecuteNonQuery();
            Load_DataGridView();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Dispose();
            Program.MyCon.Close();
        }
    }
}
