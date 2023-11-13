using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_QLDT
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void DangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin formLogin = new formLogin();
            formLogin.Show();
            this.Close();
        }

        private void DanhSachTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTaikhoan formTaikhoan = new formTaikhoan();
            formTaikhoan.MdiParent = this;
            formTaikhoan.Show();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimKiemSVTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTKSV_KHOA formTKSV_KHOA = new formTKSV_KHOA();
            formTKSV_KHOA.MdiParent = this;
            formTKSV_KHOA.Show();
        }

        private void NhapSVTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNhapsvtheokhoa formNhapsvtheokhoa = new formNhapsvtheokhoa();
            formNhapsvtheokhoa.MdiParent = this;
            formNhapsvtheokhoa.Show();
        }

        private void XemBangDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formXembangdiem formXembangdiem = new formXembangdiem();
            formXembangdiem.MdiParent = this;
            formXembangdiem.Show();
        }

        private void DangKyMHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDangkymonhoc formDangkymonhoc = new formDangkymonhoc();
            formDangkymonhoc.MdiParent = this;
            formDangkymonhoc.Show();
        }

        private void NhapDiemSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNhapdiemsinhvien formNhapdiemsinhvien = new formNhapdiemsinhvien();
            formNhapdiemsinhvien.MdiParent = this;
            formNhapdiemsinhvien.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            switch (Program.quyen)
            {
                case 3:
                    // Thực hiện hành động cho quyền Admin
                    break;
                case 2:
                    // Thực hiện hành động cho quyền Quản Lý
                    DSTK_ToolStripMenuItem.Visible = false;
                    break;
                case 1:
                    // Thực hiện hành động cho quyền Giáo viên
                    QuanLySV_ToolStripMenuItem.Visible = false;
                    DangKyMH_ToolStripMenuItem.Visible = false;
                    DSTK_ToolStripMenuItem.Visible = false;
                    break;
                case 0:
                    // Thực hiện hành động cho quyền SinhVien
                    QuanLySV_ToolStripMenuItem.Visible = false;
                    BaoCao_ToolStripMenuItem.Visible = false;
                    QuanLyMHToolStripMenuItem.Visible = false;
                    NhapDiemSV_ToolStripMenuItem.Visible = false;
                    DSTK_ToolStripMenuItem.Visible = false;
                    break;
            }
        }
    }
}
