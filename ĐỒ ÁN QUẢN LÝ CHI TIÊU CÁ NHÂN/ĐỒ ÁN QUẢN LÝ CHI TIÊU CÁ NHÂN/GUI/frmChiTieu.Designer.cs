namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    partial class frmChiTieu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartChiTieu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThang = new System.Windows.Forms.Button();
            this.btn7ngay = new System.Windows.Forms.Button();
            this.dgvDanhSachChiTieu = new System.Windows.Forms.DataGridView();
            this.dtpChiTieu = new System.Windows.Forms.DateTimePicker();
            this.cboNguon = new System.Windows.Forms.ComboBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChiTieu = new System.Windows.Forms.Button();
            this.btnDanhsach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNam = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartChiTieu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartChiTieu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartChiTieu.Legends.Add(legend1);
            this.chartChiTieu.Location = new System.Drawing.Point(409, 108);
            this.chartChiTieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartChiTieu.Name = "chartChiTieu";
            this.chartChiTieu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartChiTieu.Series.Add(series1);
            this.chartChiTieu.Size = new System.Drawing.Size(521, 190);
            this.chartChiTieu.TabIndex = 26;
            this.chartChiTieu.Text = "chart1";
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.Color.Silver;
            this.btnThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThang.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThang.Location = new System.Drawing.Point(590, 49);
            this.btnThang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(160, 57);
            this.btnThang.TabIndex = 24;
            this.btnThang.Text = "Tháng";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btn7ngay
            // 
            this.btn7ngay.BackColor = System.Drawing.Color.Silver;
            this.btn7ngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7ngay.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7ngay.Location = new System.Drawing.Point(409, 49);
            this.btn7ngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn7ngay.Name = "btn7ngay";
            this.btn7ngay.Size = new System.Drawing.Size(174, 57);
            this.btn7ngay.TabIndex = 23;
            this.btn7ngay.Text = "Trong 7 ngày";
            this.btn7ngay.UseVisualStyleBackColor = false;
            this.btn7ngay.Click += new System.EventHandler(this.btn7ngay_Click);
            // 
            // dgvDanhSachChiTieu
            // 
            this.dgvDanhSachChiTieu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDanhSachChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChiTieu.Location = new System.Drawing.Point(46, 108);
            this.dgvDanhSachChiTieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachChiTieu.Name = "dgvDanhSachChiTieu";
            this.dgvDanhSachChiTieu.RowHeadersWidth = 82;
            this.dgvDanhSachChiTieu.RowTemplate.Height = 33;
            this.dgvDanhSachChiTieu.Size = new System.Drawing.Size(357, 366);
            this.dgvDanhSachChiTieu.TabIndex = 22;
            this.dgvDanhSachChiTieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachChiTieu_CellClick);
            // 
            // dtpChiTieu
            // 
            this.dtpChiTieu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChiTieu.Location = new System.Drawing.Point(280, 116);
            this.dtpChiTieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpChiTieu.Name = "dtpChiTieu";
            this.dtpChiTieu.Size = new System.Drawing.Size(223, 30);
            this.dtpChiTieu.TabIndex = 22;
            // 
            // cboNguon
            // 
            this.cboNguon.FormattingEnabled = true;
            this.cboNguon.Location = new System.Drawing.Point(280, 54);
            this.cboNguon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNguon.Name = "cboNguon";
            this.cboNguon.Size = new System.Drawing.Size(223, 31);
            this.cboNguon.TabIndex = 25;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(39, 54);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(206, 31);
            this.cboLoai.TabIndex = 24;
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.Location = new System.Drawing.Point(39, 116);
            this.txtTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTien.Multiline = true;
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(203, 33);
            this.txtTien.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày chi tiêu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nguồn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số tiền:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Black;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(42, 185);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(190, 41);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Black;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(283, 185);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(187, 41);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Loại:";
            // 
            // btnChiTieu
            // 
            this.btnChiTieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnChiTieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTieu.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTieu.ForeColor = System.Drawing.Color.Black;
            this.btnChiTieu.Location = new System.Drawing.Point(46, 49);
            this.btnChiTieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChiTieu.Name = "btnChiTieu";
            this.btnChiTieu.Size = new System.Drawing.Size(357, 57);
            this.btnChiTieu.TabIndex = 29;
            this.btnChiTieu.Text = "Chi tiêu trong 7 ngày gần đây";
            this.btnChiTieu.UseVisualStyleBackColor = false;
            // 
            // btnDanhsach
            // 
            this.btnDanhsach.BackColor = System.Drawing.Color.Black;
            this.btnDanhsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhsach.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsach.ForeColor = System.Drawing.Color.White;
            this.btnDanhsach.Location = new System.Drawing.Point(46, 480);
            this.btnDanhsach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDanhsach.Name = "btnDanhsach";
            this.btnDanhsach.Size = new System.Drawing.Size(357, 63);
            this.btnDanhsach.TabIndex = 28;
            this.btnDanhsach.Text = "In danh sách chi tiêu";
            this.btnDanhsach.UseVisualStyleBackColor = false;
            this.btnDanhsach.Click += new System.EventHandler(this.btnDanhsach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dtpChiTieu);
            this.groupBox1.Controls.Add(this.cboNguon);
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(409, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(521, 237);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chỉnh chi tiêu";
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.Silver;
            this.btnNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNam.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Location = new System.Drawing.Point(756, 49);
            this.btnNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(174, 57);
            this.btnNam.TabIndex = 25;
            this.btnNam.Text = "Năm";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnChiTieu);
            this.pnlContent.Controls.Add(this.btnDanhsach);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.chartChiTieu);
            this.pnlContent.Controls.Add(this.btnThang);
            this.pnlContent.Controls.Add(this.btn7ngay);
            this.pnlContent.Controls.Add(this.btnNam);
            this.pnlContent.Controls.Add(this.dgvDanhSachChiTieu);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(989, 584);
            this.pnlContent.TabIndex = 3;
            // 
            // frmChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 584);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChiTieu";
            this.Text = "frmChiTieu";
            this.Load += new System.EventHandler(this.frmChiTieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartChiTieu;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btn7ngay;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTieu;
        private System.Windows.Forms.DateTimePicker dtpChiTieu;
        private System.Windows.Forms.ComboBox cboNguon;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChiTieu;
        private System.Windows.Forms.Button btnDanhsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Panel pnlContent;
    }
}