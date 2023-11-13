
namespace Chuong4_QLDT
{
    partial class formNhapsvtheokhoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbKhoa = new System.Windows.Forms.GroupBox();
            this.cbMakhoa = new System.Windows.Forms.ComboBox();
            this.txtTenkhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbSV = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.grbKhoa.SuspendLayout();
            this.grbSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKhoa
            // 
            this.grbKhoa.Controls.Add(this.cbMakhoa);
            this.grbKhoa.Controls.Add(this.txtTenkhoa);
            this.grbKhoa.Controls.Add(this.label3);
            this.grbKhoa.Controls.Add(this.label2);
            this.grbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhoa.Location = new System.Drawing.Point(13, 47);
            this.grbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.grbKhoa.Name = "grbKhoa";
            this.grbKhoa.Padding = new System.Windows.Forms.Padding(4);
            this.grbKhoa.Size = new System.Drawing.Size(328, 161);
            this.grbKhoa.TabIndex = 2;
            this.grbKhoa.TabStop = false;
            // 
            // cbMakhoa
            // 
            this.cbMakhoa.FormattingEnabled = true;
            this.cbMakhoa.Location = new System.Drawing.Point(157, 17);
            this.cbMakhoa.Name = "cbMakhoa";
            this.cbMakhoa.Size = new System.Drawing.Size(112, 30);
            this.cbMakhoa.TabIndex = 4;
            this.cbMakhoa.SelectedIndexChanged += new System.EventHandler(this.cbMakhoa_SelectedIndexChanged);
            // 
            // txtTenkhoa
            // 
            this.txtTenkhoa.Enabled = false;
            this.txtTenkhoa.Location = new System.Drawing.Point(157, 50);
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.Size = new System.Drawing.Size(160, 28);
            this.txtTenkhoa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn Mã Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "NHẬP SINH VIÊN THEO KHOA";
            // 
            // grbSV
            // 
            this.grbSV.Controls.Add(this.btnXoa);
            this.grbSV.Controls.Add(this.btnLuu);
            this.grbSV.Controls.Add(this.btnSua);
            this.grbSV.Controls.Add(this.btnThem);
            this.grbSV.Controls.Add(this.txtQuequan);
            this.grbSV.Controls.Add(this.label8);
            this.grbSV.Controls.Add(this.txtMaSV);
            this.grbSV.Controls.Add(this.dtpNgaysinh);
            this.grbSV.Controls.Add(this.txtPhai);
            this.grbSV.Controls.Add(this.label5);
            this.grbSV.Controls.Add(this.label4);
            this.grbSV.Controls.Add(this.txtTenSV);
            this.grbSV.Controls.Add(this.label6);
            this.grbSV.Controls.Add(this.label7);
            this.grbSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSV.Location = new System.Drawing.Point(349, 47);
            this.grbSV.Margin = new System.Windows.Forms.Padding(4);
            this.grbSV.Name = "grbSV";
            this.grbSV.Padding = new System.Windows.Forms.Padding(4);
            this.grbSV.Size = new System.Drawing.Size(620, 161);
            this.grbSV.TabIndex = 4;
            this.grbSV.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(390, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 36);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(265, 118);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 36);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(139, 118);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 36);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 118);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 36);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(139, 81);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(120, 28);
            this.txtQuequan.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quê quán";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(139, 16);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(120, 28);
            this.txtMaSV.TabIndex = 10;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(413, 48);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 28);
            this.dtpNgaysinh.TabIndex = 9;
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(139, 48);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(120, 28);
            this.txtPhai.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phái";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(413, 16);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(200, 28);
            this.txtTenSV.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên sinh viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã sinh viên ";
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Location = new System.Drawing.Point(13, 215);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.RowHeadersWidth = 51;
            this.dgvSinhvien.RowTemplate.Height = 24;
            this.dgvSinhvien.Size = new System.Drawing.Size(957, 226);
            this.dgvSinhvien.TabIndex = 5;
            this.dgvSinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhvien_CellClick);
            // 
            // formNhapsvtheokhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.dgvSinhvien);
            this.Controls.Add(this.grbSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbKhoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formNhapsvtheokhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formNhapsvtheokhoa";
            this.Load += new System.EventHandler(this.formNhapsvtheokhoa_Load);
            this.grbKhoa.ResumeLayout(false);
            this.grbKhoa.PerformLayout();
            this.grbSV.ResumeLayout(false);
            this.grbSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhoa;
        private System.Windows.Forms.ComboBox cbMakhoa;
        private System.Windows.Forms.TextBox txtTenkhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbSV;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
    }
}