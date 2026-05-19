namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    partial class frmThemKhoanVay
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
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayHan = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienVay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThemKhoanVay = new System.Windows.Forms.TextBox();
            this.btnChonTaiKhoan = new System.Windows.Forms.Button();
            this.dgvTaiKhoanVay = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanVay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(708, 86);
            this.pnlTop.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(209, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM KHOẢN VAY MỚI";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Black;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(292, 356);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(172, 44);
            this.btnThemMoi.TabIndex = 16;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpNgayHan);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(292, 205);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 132);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày hạn";
            // 
            // dtpNgayHan
            // 
            this.dtpNgayHan.Location = new System.Drawing.Point(27, 62);
            this.dtpNgayHan.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayHan.Name = "dtpNgayHan";
            this.dtpNgayHan.Size = new System.Drawing.Size(321, 27);
            this.dtpNgayHan.TabIndex = 0;
            // 
            // txtSoTienVay
            // 
            this.txtSoTienVay.Location = new System.Drawing.Point(492, 165);
            this.txtSoTienVay.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTienVay.Multiline = true;
            this.txtSoTienVay.Name = "txtSoTienVay";
            this.txtSoTienVay.Size = new System.Drawing.Size(169, 36);
            this.txtSoTienVay.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(493, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số tiền vay";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(292, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thêm khoản vay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtThemKhoanVay
            // 
            this.txtThemKhoanVay.Location = new System.Drawing.Point(292, 165);
            this.txtThemKhoanVay.Margin = new System.Windows.Forms.Padding(2);
            this.txtThemKhoanVay.Multiline = true;
            this.txtThemKhoanVay.Name = "txtThemKhoanVay";
            this.txtThemKhoanVay.Size = new System.Drawing.Size(172, 36);
            this.txtThemKhoanVay.TabIndex = 12;
            // 
            // btnChonTaiKhoan
            // 
            this.btnChonTaiKhoan.BackColor = System.Drawing.Color.Black;
            this.btnChonTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnChonTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnChonTaiKhoan.Location = new System.Drawing.Point(54, 134);
            this.btnChonTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonTaiKhoan.Name = "btnChonTaiKhoan";
            this.btnChonTaiKhoan.Size = new System.Drawing.Size(208, 44);
            this.btnChonTaiKhoan.TabIndex = 11;
            this.btnChonTaiKhoan.Text = "Chọn tài khoản";
            this.btnChonTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // dgvTaiKhoanVay
            // 
            this.dgvTaiKhoanVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanVay.Location = new System.Drawing.Point(54, 182);
            this.dgvTaiKhoanVay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTaiKhoanVay.Name = "dgvTaiKhoanVay";
            this.dgvTaiKhoanVay.RowHeadersWidth = 82;
            this.dgvTaiKhoanVay.RowTemplate.Height = 33;
            this.dgvTaiKhoanVay.Size = new System.Drawing.Size(208, 218);
            this.dgvTaiKhoanVay.TabIndex = 9;
            this.dgvTaiKhoanVay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoanVay_CellClick);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Black;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(492, 356);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 44);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 447);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSoTienVay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThemKhoanVay);
            this.Controls.Add(this.btnChonTaiKhoan);
            this.Controls.Add(this.dgvTaiKhoanVay);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThemKhoanVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khoản vay";
            this.Load += new System.EventHandler(this.frmThemKhoanVay_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanVay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayHan;
        private System.Windows.Forms.TextBox txtSoTienVay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThemKhoanVay;
        private System.Windows.Forms.Button btnChonTaiKhoan;
        private System.Windows.Forms.DataGridView dgvTaiKhoanVay;
        private System.Windows.Forms.Button btnHuy;
    }
}