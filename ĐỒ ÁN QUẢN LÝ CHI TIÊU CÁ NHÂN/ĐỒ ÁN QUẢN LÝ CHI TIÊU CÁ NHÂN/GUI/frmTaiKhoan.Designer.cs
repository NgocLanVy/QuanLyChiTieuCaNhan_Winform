namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    partial class frmTaiKhoan
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.lblTongTK = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.txtSoDu = new System.Windows.Forms.TextBox();
            this.txtMaVi = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTenVi = new System.Windows.Forms.Label();
            this.txtTenVi = new System.Windows.Forms.TextBox();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.lblMaVi = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeft.Controls.Add(this.dgvTaiKhoan);
            this.pnlLeft.Controls.Add(this.lblTongTK);
            this.pnlLeft.Location = new System.Drawing.Point(91, 48);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(360, 538);
            this.pnlLeft.TabIndex = 0;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(38, 89);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(283, 382);
            this.dgvTaiKhoan.TabIndex = 1;
            this.dgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dgvTaiKhoan_SelectionChanged);
            // 
            // lblTongTK
            // 
            this.lblTongTK.AutoSize = true;
            this.lblTongTK.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTK.Location = new System.Drawing.Point(69, 38);
            this.lblTongTK.Name = "lblTongTK";
            this.lblTongTK.Size = new System.Drawing.Size(208, 25);
            this.lblTongTK.TabIndex = 0;
            this.lblTongTK.Text = "Số lượng tài khoản là 0";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRight.Controls.Add(this.txtSoDu);
            this.pnlRight.Controls.Add(this.txtMaVi);
            this.pnlRight.Controls.Add(this.btnXoa);
            this.pnlRight.Controls.Add(this.btnSua);
            this.pnlRight.Controls.Add(this.btnThem);
            this.pnlRight.Controls.Add(this.lblTenVi);
            this.pnlRight.Controls.Add(this.txtTenVi);
            this.pnlRight.Controls.Add(this.lblSoDu);
            this.pnlRight.Controls.Add(this.lblMaVi);
            this.pnlRight.Location = new System.Drawing.Point(457, 48);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(465, 538);
            this.pnlRight.TabIndex = 1;
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(143, 220);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(271, 30);
            this.txtSoDu.TabIndex = 8;
            // 
            // txtMaVi
            // 
            this.txtMaVi.Location = new System.Drawing.Point(143, 109);
            this.txtMaVi.Name = "txtMaVi";
            this.txtMaVi.Size = new System.Drawing.Size(271, 30);
            this.txtMaVi.TabIndex = 7;
            this.txtMaVi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Black;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(236, 304);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 45);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Black;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(74, 304);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(144, 45);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa tài khoản";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Black;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(137, 373);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 45);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm tài khoản  ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTenVi
            // 
            this.lblTenVi.AutoSize = true;
            this.lblTenVi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenVi.Location = new System.Drawing.Point(42, 170);
            this.lblTenVi.Name = "lblTenVi";
            this.lblTenVi.Size = new System.Drawing.Size(72, 25);
            this.lblTenVi.TabIndex = 3;
            this.lblTenVi.Text = "Tên ví :";
            // 
            // txtTenVi
            // 
            this.txtTenVi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVi.Location = new System.Drawing.Point(143, 165);
            this.txtTenVi.Name = "txtTenVi";
            this.txtTenVi.Size = new System.Drawing.Size(271, 31);
            this.txtTenVi.TabIndex = 2;
            // 
            // lblSoDu
            // 
            this.lblSoDu.AutoSize = true;
            this.lblSoDu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDu.Location = new System.Drawing.Point(43, 225);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(71, 25);
            this.lblSoDu.TabIndex = 1;
            this.lblSoDu.Text = "Số dư :";
            // 
            // lblMaVi
            // 
            this.lblMaVi.AutoSize = true;
            this.lblMaVi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVi.Location = new System.Drawing.Point(42, 114);
            this.lblMaVi.Name = "lblMaVi";
            this.lblMaVi.Size = new System.Drawing.Size(69, 25);
            this.lblMaVi.TabIndex = 0;
            this.lblMaVi.Text = "Mã ví :";
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1007, 631);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTongTK;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTenVi;
        private System.Windows.Forms.TextBox txtTenVi;
        private System.Windows.Forms.Label lblSoDu;
        private System.Windows.Forms.Label lblMaVi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoDu;
        private System.Windows.Forms.TextBox txtMaVi;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
    }
}