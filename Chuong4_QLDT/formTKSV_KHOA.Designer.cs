
namespace Chuong4_QLDT
{
    partial class formTKSV_KHOA
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbTTK = new System.Windows.Forms.GroupBox();
            this.cbMakhoa = new System.Windows.Forms.ComboBox();
            this.txtTenkhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongSoSV = new System.Windows.Forms.TextBox();
            this.grbTTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ SINH VIÊN THEO KHOA";
            // 
            // grbTTK
            // 
            this.grbTTK.Controls.Add(this.cbMakhoa);
            this.grbTTK.Controls.Add(this.txtTenkhoa);
            this.grbTTK.Controls.Add(this.label3);
            this.grbTTK.Controls.Add(this.label2);
            this.grbTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTK.Location = new System.Drawing.Point(41, 56);
            this.grbTTK.Margin = new System.Windows.Forms.Padding(4);
            this.grbTTK.Name = "grbTTK";
            this.grbTTK.Padding = new System.Windows.Forms.Padding(4);
            this.grbTTK.Size = new System.Drawing.Size(889, 87);
            this.grbTTK.TabIndex = 1;
            this.grbTTK.TabStop = false;
            this.grbTTK.Text = "THÔNG TIN KHOA";
            // 
            // cbMakhoa
            // 
            this.cbMakhoa.FormattingEnabled = true;
            this.cbMakhoa.Location = new System.Drawing.Point(218, 35);
            this.cbMakhoa.Name = "cbMakhoa";
            this.cbMakhoa.Size = new System.Drawing.Size(121, 30);
            this.cbMakhoa.TabIndex = 4;
            this.cbMakhoa.SelectedIndexChanged += new System.EventHandler(this.cbMakhoa_SelectedIndexChanged);
            // 
            // txtTenkhoa
            // 
            this.txtTenkhoa.Location = new System.Drawing.Point(557, 35);
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.Size = new System.Drawing.Size(296, 28);
            this.txtTenkhoa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn Mã Khoa";
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Location = new System.Drawing.Point(41, 150);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.RowHeadersWidth = 51;
            this.dgvSinhvien.RowTemplate.Height = 24;
            this.dgvSinhvien.Size = new System.Drawing.Size(889, 243);
            this.dgvSinhvien.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "TỔNG SỐ SINH VIÊN";
            // 
            // txtTongSoSV
            // 
            this.txtTongSoSV.Location = new System.Drawing.Point(507, 402);
            this.txtTongSoSV.Name = "txtTongSoSV";
            this.txtTongSoSV.Size = new System.Drawing.Size(387, 28);
            this.txtTongSoSV.TabIndex = 4;
            // 
            // formTKSV_KHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.txtTongSoSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSinhvien);
            this.Controls.Add(this.grbTTK);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTKSV_KHOA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTKSV_KHOA";
            this.Load += new System.EventHandler(this.formTKSV_KHOA_Load);
            this.grbTTK.ResumeLayout(false);
            this.grbTTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.ComboBox cbMakhoa;
        private System.Windows.Forms.TextBox txtTenkhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongSoSV;
    }
}