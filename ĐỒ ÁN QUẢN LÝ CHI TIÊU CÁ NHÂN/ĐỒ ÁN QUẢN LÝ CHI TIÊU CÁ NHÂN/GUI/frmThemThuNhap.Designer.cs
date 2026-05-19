namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    partial class frmThemThuNhap
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PNLvI = new System.Windows.Forms.Panel();
            this.dgvViTien = new System.Windows.Forms.DataGridView();
            this.btnChonTaiKhoan = new System.Windows.Forms.Button();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.pnlDanhMuc = new System.Windows.Forms.Panel();
            this.btnQuaTang = new System.Windows.Forms.Button();
            this.btnPhuCap = new System.Windows.Forms.Button();
            this.btnHoaHong = new System.Windows.Forms.Button();
            this.btnLamThem = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.btnDauTu = new System.Windows.Forms.Button();
            this.btnTietKiem = new System.Windows.Forms.Button();
            this.btnViecVat = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.PNLvI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTien)).BeginInit();
            this.pnlDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(882, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(211, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(466, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM THU NHẬP HÔM NAY CỦA BẠN";
            // 
            // PNLvI
            // 
            this.PNLvI.Controls.Add(this.dgvViTien);
            this.PNLvI.Controls.Add(this.btnChonTaiKhoan);
            this.PNLvI.Location = new System.Drawing.Point(89, 107);
            this.PNLvI.Name = "PNLvI";
            this.PNLvI.Size = new System.Drawing.Size(317, 252);
            this.PNLvI.TabIndex = 1;
            // 
            // dgvViTien
            // 
            this.dgvViTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViTien.Location = new System.Drawing.Point(12, 66);
            this.dgvViTien.Name = "dgvViTien";
            this.dgvViTien.RowHeadersVisible = false;
            this.dgvViTien.RowHeadersWidth = 51;
            this.dgvViTien.RowTemplate.Height = 24;
            this.dgvViTien.Size = new System.Drawing.Size(295, 172);
            this.dgvViTien.TabIndex = 3;
            this.dgvViTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViTien_CellClick);
            // 
            // btnChonTaiKhoan
            // 
            this.btnChonTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChonTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnChonTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnChonTaiKhoan.Location = new System.Drawing.Point(12, 15);
            this.btnChonTaiKhoan.Name = "btnChonTaiKhoan";
            this.btnChonTaiKhoan.Size = new System.Drawing.Size(295, 45);
            this.btnChonTaiKhoan.TabIndex = 2;
            this.btnChonTaiKhoan.Text = "Chọn tài khoản";
            this.btnChonTaiKhoan.UseVisualStyleBackColor = false;
            this.btnChonTaiKhoan.Click += new System.EventHandler(this.btnChonTaiKhoan_Click);
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(431, 107);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(167, 23);
            this.lblSoTien.TabIndex = 2;
            this.lblSoTien.Text = "Số Tiền Thu Nhập : ";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(601, 102);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(180, 31);
            this.txtSoTien.TabIndex = 3;
            // 
            // pnlDanhMuc
            // 
            this.pnlDanhMuc.Controls.Add(this.btnQuaTang);
            this.pnlDanhMuc.Controls.Add(this.btnPhuCap);
            this.pnlDanhMuc.Controls.Add(this.btnHoaHong);
            this.pnlDanhMuc.Controls.Add(this.btnLamThem);
            this.pnlDanhMuc.Controls.Add(this.btnThuong);
            this.pnlDanhMuc.Controls.Add(this.btnDauTu);
            this.pnlDanhMuc.Controls.Add(this.btnTietKiem);
            this.pnlDanhMuc.Controls.Add(this.btnViecVat);
            this.pnlDanhMuc.Controls.Add(this.btnLuong);
            this.pnlDanhMuc.Location = new System.Drawing.Point(421, 139);
            this.pnlDanhMuc.Name = "pnlDanhMuc";
            this.pnlDanhMuc.Size = new System.Drawing.Size(360, 220);
            this.pnlDanhMuc.TabIndex = 4;
            // 
            // btnQuaTang
            // 
            this.btnQuaTang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnQuaTang.FlatAppearance.BorderSize = 0;
            this.btnQuaTang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuaTang.ForeColor = System.Drawing.Color.White;
            this.btnQuaTang.Location = new System.Drawing.Point(246, 146);
            this.btnQuaTang.Name = "btnQuaTang";
            this.btnQuaTang.Size = new System.Drawing.Size(100, 60);
            this.btnQuaTang.TabIndex = 8;
            this.btnQuaTang.Text = "Quà tặng";
            this.btnQuaTang.UseVisualStyleBackColor = false;
            this.btnQuaTang.Click += new System.EventHandler(this.btnQuaTang_Click);
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnPhuCap.FlatAppearance.BorderSize = 0;
            this.btnPhuCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhuCap.ForeColor = System.Drawing.Color.White;
            this.btnPhuCap.Location = new System.Drawing.Point(130, 146);
            this.btnPhuCap.Name = "btnPhuCap";
            this.btnPhuCap.Size = new System.Drawing.Size(100, 60);
            this.btnPhuCap.TabIndex = 7;
            this.btnPhuCap.Text = "Phụ cấp";
            this.btnPhuCap.UseVisualStyleBackColor = false;
            this.btnPhuCap.Click += new System.EventHandler(this.btnPhuCap_Click);
            // 
            // btnHoaHong
            // 
            this.btnHoaHong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnHoaHong.FlatAppearance.BorderSize = 0;
            this.btnHoaHong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaHong.ForeColor = System.Drawing.Color.White;
            this.btnHoaHong.Location = new System.Drawing.Point(14, 146);
            this.btnHoaHong.Name = "btnHoaHong";
            this.btnHoaHong.Size = new System.Drawing.Size(100, 60);
            this.btnHoaHong.TabIndex = 6;
            this.btnHoaHong.Text = "Hoa Hồng";
            this.btnHoaHong.UseVisualStyleBackColor = false;
            this.btnHoaHong.Click += new System.EventHandler(this.btnHoaHong_Click);
            // 
            // btnLamThem
            // 
            this.btnLamThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLamThem.FlatAppearance.BorderSize = 0;
            this.btnLamThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamThem.ForeColor = System.Drawing.Color.White;
            this.btnLamThem.Location = new System.Drawing.Point(246, 80);
            this.btnLamThem.Name = "btnLamThem";
            this.btnLamThem.Size = new System.Drawing.Size(100, 60);
            this.btnLamThem.TabIndex = 5;
            this.btnLamThem.Text = "Làm thêm";
            this.btnLamThem.UseVisualStyleBackColor = false;
            this.btnLamThem.Click += new System.EventHandler(this.btnLamThem_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnThuong.FlatAppearance.BorderSize = 0;
            this.btnThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuong.ForeColor = System.Drawing.Color.White;
            this.btnThuong.Location = new System.Drawing.Point(130, 80);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(100, 60);
            this.btnThuong.TabIndex = 4;
            this.btnThuong.Text = "Thưởng";
            this.btnThuong.UseVisualStyleBackColor = false;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // btnDauTu
            // 
            this.btnDauTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDauTu.FlatAppearance.BorderSize = 0;
            this.btnDauTu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDauTu.ForeColor = System.Drawing.Color.White;
            this.btnDauTu.Location = new System.Drawing.Point(14, 80);
            this.btnDauTu.Name = "btnDauTu";
            this.btnDauTu.Size = new System.Drawing.Size(100, 60);
            this.btnDauTu.TabIndex = 3;
            this.btnDauTu.Text = "Đầu tư";
            this.btnDauTu.UseVisualStyleBackColor = false;
            this.btnDauTu.Click += new System.EventHandler(this.btnDauTu_Click);
            // 
            // btnTietKiem
            // 
            this.btnTietKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnTietKiem.FlatAppearance.BorderSize = 0;
            this.btnTietKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTietKiem.ForeColor = System.Drawing.Color.White;
            this.btnTietKiem.Location = new System.Drawing.Point(246, 13);
            this.btnTietKiem.Name = "btnTietKiem";
            this.btnTietKiem.Size = new System.Drawing.Size(100, 60);
            this.btnTietKiem.TabIndex = 2;
            this.btnTietKiem.Text = "Tiết kiệm";
            this.btnTietKiem.UseVisualStyleBackColor = false;
            this.btnTietKiem.Click += new System.EventHandler(this.btnTietKiem_Click);
            // 
            // btnViecVat
            // 
            this.btnViecVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViecVat.FlatAppearance.BorderSize = 0;
            this.btnViecVat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViecVat.ForeColor = System.Drawing.Color.White;
            this.btnViecVat.Location = new System.Drawing.Point(130, 13);
            this.btnViecVat.Name = "btnViecVat";
            this.btnViecVat.Size = new System.Drawing.Size(100, 60);
            this.btnViecVat.TabIndex = 1;
            this.btnViecVat.Text = "Việc vặt";
            this.btnViecVat.UseVisualStyleBackColor = false;
            this.btnViecVat.Click += new System.EventHandler(this.btnViecVat_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLuong.FlatAppearance.BorderSize = 0;
            this.btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuong.ForeColor = System.Drawing.Color.White;
            this.btnLuong.Location = new System.Drawing.Point(14, 13);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(100, 60);
            this.btnLuong.TabIndex = 0;
            this.btnLuong.Text = "Lương";
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.Black;
            this.btnHoanThanh.FlatAppearance.BorderSize = 0;
            this.btnHoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.White;
            this.btnHoanThanh.Location = new System.Drawing.Point(343, 400);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(180, 50);
            this.btnHoanThanh.TabIndex = 5;
            this.btnHoanThanh.Text = "Hoàn Thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // frmThemThuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.pnlDanhMuc);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.PNLvI);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmThemThuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thu nhập";
            this.Load += new System.EventHandler(this.frmThemThuNhap_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.PNLvI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTien)).EndInit();
            this.pnlDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel PNLvI;
        private System.Windows.Forms.Button btnChonTaiKhoan;
        private System.Windows.Forms.DataGridView dgvViTien;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Panel pnlDanhMuc;
        private System.Windows.Forms.Button btnQuaTang;
        private System.Windows.Forms.Button btnPhuCap;
        private System.Windows.Forms.Button btnHoaHong;
        private System.Windows.Forms.Button btnLamThem;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Button btnDauTu;
        private System.Windows.Forms.Button btnTietKiem;
        private System.Windows.Forms.Button btnViecVat;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnHoanThanh;
    }
}