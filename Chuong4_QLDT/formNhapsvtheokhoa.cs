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
    public partial class formNhapsvtheokhoa : Form
    {
        public formNhapsvtheokhoa()
        {
            InitializeComponent();
        }

        private void formNhapsvtheokhoa_Load(object sender, EventArgs e)
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
        private void cbMakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DataGridView();
            LayTenKhoa();
        }
        private void Load_DataGridView()
        {
            string sql = @"select MASV, HOTEN, NGAYSINH, (CASE WHEN GIOITINH = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI, QUEQUAN
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
            dgvSinhvien.Columns[4].HeaderText = "Quê quán";
            dgvSinhvien.AllowUserToAddRows = false;
            dgvSinhvien.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSinhvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtPhai.Clear();
            txtQuequan.Clear();
            dtpNgaysinh.ResetText();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            string sql = "select count(*) from sinhvien where masv = '" + txtMaSV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Program.MyCon);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Đã có sinh viên này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sqlinsert = @"insert into sinhvien (MASV, HOTEN, NGAYSINH, GIOITINH, QUEQUAN, MAKHOA)
                        values (@masv, @hoten, @ngaysinh, @gioitinh, @quequan, @makhoa )";
                SqlCommand cmd1 = new SqlCommand(sqlinsert, Program.MyCon);
                cmd1.Parameters.AddWithValue("@masv", txtMaSV.Text);
                cmd1.Parameters.AddWithValue("@hoten", txtTenSV.Text);
                cmd1.Parameters.AddWithValue("@ngaysinh", dtpNgaysinh.Value);
                cmd1.Parameters.AddWithValue("@gioitinh", txtPhai.Text.ToLower() == "nam" ? 1 : 0);//txtPhai.Text.ToLower() đưa giá trị về chữ thường
                cmd1.Parameters.AddWithValue("@quequan", txtQuequan.Text);
                cmd1.Parameters.AddWithValue("@makhoa", cbMakhoa.Text);
                cmd1.ExecuteNonQuery();
                Load_DataGridView();
                MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd1.Dispose();
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
            Program.MyCon.Close();
        }

        private void dgvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtMaSV.Text = dgvSinhvien.Rows[dong].Cells[0].Value.ToString();
                txtTenSV.Text = dgvSinhvien.Rows[dong].Cells[1].Value.ToString();
                //dtpNgaysinh.Text = dgvSinhvien.Rows[dong].Cells[2].Value.ToString();
                dtpNgaysinh.Value = (DateTime)dgvSinhvien.CurrentRow.Cells[2].Value;
                txtPhai.Text = dgvSinhvien.Rows[dong].Cells[3].Value.ToString();
                txtQuequan.Text = dgvSinhvien.Rows[dong].Cells[4].Value.ToString();
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy chỉ số hàng đang được chọn trong DataGridView
            int dong = dgvSinhvien.CurrentRow.Index;
            //
            string masv = dgvSinhvien.Rows[dong].Cells[0].Value.ToString();
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            string sqlupdate = @"update SINHVIEN set 
                                MASV = @masv, HOTEN = @hoten, NGAYSINH = @ngaysinh, GIOITINH = @gioitinh, QUEQUAN = @quequan, MAKHOA = @makhoa
                                WHERE MASV = '" + masv + "'";
            SqlCommand cmd = new SqlCommand(sqlupdate, Program.MyCon);
            cmd.Parameters.AddWithValue("@masv", txtMaSV.Text);
            cmd.Parameters.AddWithValue("@hoten", txtTenSV.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaysinh.Value);
            cmd.Parameters.AddWithValue("@gioitinh", txtPhai.Text.ToLower() == "nam" ? 1 : 0); //txtPhai.Text.ToLower() đưa giá trị về chữ thường
            cmd.Parameters.AddWithValue("@quequan", txtQuequan.Text);
            cmd.Parameters.AddWithValue("@makhoa", cbMakhoa.Text);
            cmd.ExecuteNonQuery();
            Load_DataGridView();
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Dispose();
            Program.MyCon.Close();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhvien.SelectedRows.Count > 0)
            {
                Xoa();
            }
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void Xoa()
        {
            if (Program.MyCon.State == ConnectionState.Open) Program.MyCon.Close();
            Program.MyCon.Open();
            foreach (DataGridViewRow selectedRow in dgvSinhvien.SelectedRows)
            {
                string masv = selectedRow.Cells["MASV"].Value.ToString();
                string sqlDelete = "delete SINHVIEN WHERE MASV = @masv";
                SqlCommand cmd = new SqlCommand(sqlDelete, Program.MyCon);
                cmd.Parameters.AddWithValue("@masv", masv);
                cmd.ExecuteNonQuery();
                cmd.Dispose(); 
            }
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_DataGridView();
            Program.MyCon.Close();
        }
    }
}
