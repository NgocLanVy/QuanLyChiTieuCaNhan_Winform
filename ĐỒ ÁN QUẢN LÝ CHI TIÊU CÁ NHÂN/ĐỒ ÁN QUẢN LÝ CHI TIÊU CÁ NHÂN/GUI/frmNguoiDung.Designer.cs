namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    partial class frmNguoiDung
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblThuChi = new System.Windows.Forms.Label();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblCapNhatTT = new System.Windows.Forms.Label();
            this.lblVi = new System.Windows.Forms.Label();
            this.lblTTND = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTaiKhoan = new System.Windows.Forms.Panel();
            this.dgvViTien = new System.Windows.Forms.DataGridView();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTongChi = new System.Windows.Forms.Label();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTien)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlContent.Controls.Add(this.lblThuChi);
            this.pnlContent.Controls.Add(this.btnXoaTK);
            this.pnlContent.Controls.Add(this.btnDangXuat);
            this.pnlContent.Controls.Add(this.btnDoiMK);
            this.pnlContent.Controls.Add(this.btnLuu);
            this.pnlContent.Controls.Add(this.lblCapNhatTT);
            this.pnlContent.Controls.Add(this.lblVi);
            this.pnlContent.Controls.Add(this.lblTTND);
            this.pnlContent.Controls.Add(this.pnlUpdate);
            this.pnlContent.Controls.Add(this.pnlTaiKhoan);
            this.pnlContent.Controls.Add(this.pnlLeft);
            this.pnlContent.Controls.Add(this.pnlBottom);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1007, 631);
            this.pnlContent.TabIndex = 17;
            // 
            // lblThuChi
            // 
            this.lblThuChi.AutoSize = true;
            this.lblThuChi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuChi.Location = new System.Drawing.Point(636, 240);
            this.lblThuChi.Name = "lblThuChi";
            this.lblThuChi.Size = new System.Drawing.Size(98, 25);
            this.lblThuChi.TabIndex = 13;
            this.lblThuChi.Text = "THU - CHI";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.Color.Black;
            this.btnXoaTK.FlatAppearance.BorderSize = 0;
            this.btnXoaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTK.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.White;
            this.btnXoaTK.Location = new System.Drawing.Point(779, 429);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(200, 45);
            this.btnXoaTK.TabIndex = 12;
            this.btnXoaTK.Text = "Xóa tài khoản";
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Black;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(525, 429);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(200, 45);
            this.btnDangXuat.TabIndex = 11;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.Black;
            this.btnDoiMK.FlatAppearance.BorderSize = 0;
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.Location = new System.Drawing.Point(276, 429);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(200, 45);
            this.btnDoiMK.TabIndex = 10;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Black;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(29, 429);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(200, 45);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu thông tin";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblCapNhatTT
            // 
            this.lblCapNhatTT.AutoSize = true;
            this.lblCapNhatTT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapNhatTT.Location = new System.Drawing.Point(636, 20);
            this.lblCapNhatTT.Name = "lblCapNhatTT";
            this.lblCapNhatTT.Size = new System.Drawing.Size(211, 25);
            this.lblCapNhatTT.TabIndex = 3;
            this.lblCapNhatTT.Text = "CẬP NHẬT THÔNG TIN";
            // 
            // lblVi
            // 
            this.lblVi.AutoSize = true;
            this.lblVi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVi.Location = new System.Drawing.Point(380, 20);
            this.lblVi.Name = "lblVi";
            this.lblVi.Size = new System.Drawing.Size(232, 25);
            this.lblVi.TabIndex = 0;
            this.lblVi.Text = "HIỆN CÓ CÁC TÀI KHOẢN";
            // 
            // lblTTND
            // 
            this.lblTTND.AutoSize = true;
            this.lblTTND.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTND.Location = new System.Drawing.Point(24, 20);
            this.lblTTND.Name = "lblTTND";
            this.lblTTND.Size = new System.Drawing.Size(238, 25);
            this.lblTTND.TabIndex = 2;
            this.lblTTND.Text = "THÔNG TIN NGƯỜI DÙNG";
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUpdate.Controls.Add(this.txtEmail);
            this.pnlUpdate.Controls.Add(this.lblE);
            this.pnlUpdate.Controls.Add(this.txtHoTen);
            this.pnlUpdate.Controls.Add(this.label1);
            this.pnlUpdate.Location = new System.Drawing.Point(641, 48);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(338, 170);
            this.pnlUpdate.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(31, 94);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(68, 25);
            this.lblE.TabIndex = 6;
            this.lblE.Text = "Email :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(150, 48);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(150, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên : ";
            // 
            // pnlTaiKhoan
            // 
            this.pnlTaiKhoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTaiKhoan.Controls.Add(this.dgvViTien);
            this.pnlTaiKhoan.Location = new System.Drawing.Point(385, 48);
            this.pnlTaiKhoan.Name = "pnlTaiKhoan";
            this.pnlTaiKhoan.Size = new System.Drawing.Size(250, 354);
            this.pnlTaiKhoan.TabIndex = 1;
            // 
            // dgvViTien
            // 
            this.dgvViTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViTien.BackgroundColor = System.Drawing.Color.White;
            this.dgvViTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViTien.Location = new System.Drawing.Point(12, 12);
            this.dgvViTien.Name = "dgvViTien";
            this.dgvViTien.RowHeadersVisible = false;
            this.dgvViTien.RowHeadersWidth = 51;
            this.dgvViTien.RowTemplate.Height = 24;
            this.dgvViTien.Size = new System.Drawing.Size(226, 327);
            this.dgvViTien.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeft.Controls.Add(this.btnCapNhat);
            this.pnlLeft.Controls.Add(this.lblRole);
            this.pnlLeft.Controls.Add(this.lblEmail);
            this.pnlLeft.Controls.Add(this.lblUsername);
            this.pnlLeft.Controls.Add(this.lblHoTen);
            this.pnlLeft.Controls.Add(this.picAvt);
            this.pnlLeft.Location = new System.Drawing.Point(29, 48);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(350, 354);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Black;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(65, 294);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(200, 45);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(11, 258);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(78, 25);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Vai trò :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 223);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 25);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(9, 181);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 25);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username :";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(9, 145);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(80, 25);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên :";
            // 
            // picAvt
            // 
            this.picAvt.Image = global::ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.Properties.Resources.avt;
            this.picAvt.Location = new System.Drawing.Point(101, 12);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(120, 120);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvt.TabIndex = 0;
            this.picAvt.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Controls.Add(this.lblTongChi);
            this.pnlBottom.Controls.Add(this.lblTongThu);
            this.pnlBottom.Location = new System.Drawing.Point(641, 268);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(338, 134);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblTongChi
            // 
            this.lblTongChi.AutoSize = true;
            this.lblTongChi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChi.Location = new System.Drawing.Point(31, 62);
            this.lblTongChi.Name = "lblTongChi";
            this.lblTongChi.Size = new System.Drawing.Size(87, 25);
            this.lblTongChi.TabIndex = 1;
            this.lblTongChi.Text = "Chi tiêu :";
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThu.Location = new System.Drawing.Point(31, 21);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(108, 25);
            this.lblTongThu.TabIndex = 0;
            this.lblTongThu.Text = "Thu nhập : ";
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1007, 631);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người dùng";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.pnlTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTien)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel pnlTaiKhoan;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.Label lblTTND;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblVi;
        private System.Windows.Forms.DataGridView dgvViTien;
        private System.Windows.Forms.Label lblCapNhatTT;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblThuChi;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblTongChi;
    }
}