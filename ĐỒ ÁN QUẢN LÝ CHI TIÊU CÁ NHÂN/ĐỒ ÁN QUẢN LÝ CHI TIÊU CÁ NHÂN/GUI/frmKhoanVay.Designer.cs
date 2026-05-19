namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    partial class frmKhoanVay
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvKhoanVayQuaHan = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXoahet = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvKhoanVay = new System.Windows.Forms.DataGridView();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSodu = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.btnThemKhoanVay = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtKhoanVay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVayQuaHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThanhToan
            // 
            this.dgvThanhToan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhToan.Location = new System.Drawing.Point(509, 355);
            this.dgvThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.RowHeadersWidth = 82;
            this.dgvThanhToan.RowTemplate.Height = 33;
            this.dgvThanhToan.Size = new System.Drawing.Size(430, 184);
            this.dgvThanhToan.TabIndex = 4;
            this.dgvThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(419, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Các khoản vay chưa thanh toán";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvKhoanVayQuaHan
            // 
            this.dgvKhoanVayQuaHan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhoanVayQuaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanVayQuaHan.Location = new System.Drawing.Point(33, 350);
            this.dgvKhoanVayQuaHan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhoanVayQuaHan.Name = "dgvKhoanVayQuaHan";
            this.dgvKhoanVayQuaHan.RowHeadersWidth = 82;
            this.dgvKhoanVayQuaHan.RowTemplate.Height = 33;
            this.dgvKhoanVayQuaHan.Size = new System.Drawing.Size(419, 236);
            this.dgvKhoanVayQuaHan.TabIndex = 2;
            this.dgvKhoanVayQuaHan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoanVayQuaHan_CellClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(33, 313);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(419, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Khoản vay quá hạn";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnXoahet
            // 
            this.btnXoahet.BackColor = System.Drawing.Color.Black;
            this.btnXoahet.FlatAppearance.BorderSize = 0;
            this.btnXoahet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoahet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoahet.ForeColor = System.Drawing.Color.White;
            this.btnXoahet.Location = new System.Drawing.Point(509, 543);
            this.btnXoahet.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoahet.Name = "btnXoahet";
            this.btnXoahet.Size = new System.Drawing.Size(430, 43);
            this.btnXoahet.TabIndex = 11;
            this.btnXoahet.Text = "Xóa hết các khoản vay đã thanh toán";
            this.btnXoahet.UseVisualStyleBackColor = false;
            this.btnXoahet.Click += new System.EventHandler(this.btnXoahet_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(509, 313);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(430, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "Các khoản vay đã thanh toán";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dgvKhoanVay
            // 
            this.dgvKhoanVay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhoanVay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhoanVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanVay.ColumnHeadersVisible = false;
            this.dgvKhoanVay.Location = new System.Drawing.Point(33, 67);
            this.dgvKhoanVay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhoanVay.Name = "dgvKhoanVay";
            this.dgvKhoanVay.RowHeadersWidth = 82;
            this.dgvKhoanVay.RowTemplate.Height = 33;
            this.dgvKhoanVay.Size = new System.Drawing.Size(419, 241);
            this.dgvKhoanVay.TabIndex = 1;
            this.dgvKhoanVay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoanVay_CellClick);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.btnXoahet);
            this.pnlContent.Controls.Add(this.button4);
            this.pnlContent.Controls.Add(this.button3);
            this.pnlContent.Controls.Add(this.dgvThanhToan);
            this.pnlContent.Controls.Add(this.button1);
            this.pnlContent.Controls.Add(this.dgvKhoanVayQuaHan);
            this.pnlContent.Controls.Add(this.dgvKhoanVay);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1113, 840);
            this.pnlContent.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtSodu);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.txtThoiHan);
            this.panel1.Controls.Add(this.btnThemKhoanVay);
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.txtKhoanVay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(509, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 279);
            this.panel1.TabIndex = 12;
            // 
            // txtSodu
            // 
            this.txtSodu.Location = new System.Drawing.Point(177, 69);
            this.txtSodu.Margin = new System.Windows.Forms.Padding(2);
            this.txtSodu.Multiline = true;
            this.txtSodu.Name = "txtSodu";
            this.txtSodu.Size = new System.Drawing.Size(227, 31);
            this.txtSodu.TabIndex = 17;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Black;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(222, 215);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(151, 35);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.Location = new System.Drawing.Point(177, 116);
            this.txtThoiHan.Margin = new System.Windows.Forms.Padding(2);
            this.txtThoiHan.Multiline = true;
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(227, 31);
            this.txtThoiHan.TabIndex = 18;
            // 
            // btnThemKhoanVay
            // 
            this.btnThemKhoanVay.BackColor = System.Drawing.Color.Black;
            this.btnThemKhoanVay.FlatAppearance.BorderSize = 0;
            this.btnThemKhoanVay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoanVay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoanVay.ForeColor = System.Drawing.Color.White;
            this.btnThemKhoanVay.Location = new System.Drawing.Point(67, 215);
            this.btnThemKhoanVay.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKhoanVay.Name = "btnThemKhoanVay";
            this.btnThemKhoanVay.Size = new System.Drawing.Size(151, 35);
            this.btnThemKhoanVay.TabIndex = 5;
            this.btnThemKhoanVay.Text = "Thêm khoản vay";
            this.btnThemKhoanVay.UseVisualStyleBackColor = false;
            this.btnThemKhoanVay.Click += new System.EventHandler(this.btnThemKhoanVay_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(177, 163);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrangThai.Multiline = true;
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(227, 31);
            this.txtTrangThai.TabIndex = 15;
            // 
            // txtKhoanVay
            // 
            this.txtKhoanVay.Location = new System.Drawing.Point(177, 22);
            this.txtKhoanVay.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhoanVay.Multiline = true;
            this.txtKhoanVay.Name = "txtKhoanVay";
            this.txtKhoanVay.Size = new System.Drawing.Size(227, 31);
            this.txtKhoanVay.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Trạng thái :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên khoản vay :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thời hạn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số dư thẻ :";
            // 
            // frmKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 840);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKhoanVay";
            this.Text = "frmKhoanVay";
            this.Load += new System.EventHandler(this.frmKhoanVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVayQuaHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvKhoanVayQuaHan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnXoahet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvKhoanVay;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSodu;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtThoiHan;
        private System.Windows.Forms.Button btnThemKhoanVay;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtKhoanVay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}