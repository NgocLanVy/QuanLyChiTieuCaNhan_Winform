namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    partial class frmTietKiem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemTietKiem = new System.Windows.Forms.Button();
            this.dgvTietKiem = new System.Windows.Forms.DataGridView();
            this.txtTongTietKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTietKiem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTietKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTietKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.dtpTime);
            this.pnlContent.Controls.Add(this.btnNam);
            this.pnlContent.Controls.Add(this.btnThang);
            this.pnlContent.Controls.Add(this.btnXoa);
            this.pnlContent.Controls.Add(this.btnThemTietKiem);
            this.pnlContent.Controls.Add(this.dgvTietKiem);
            this.pnlContent.Controls.Add(this.txtTongTietKiem);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.chartTietKiem);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1113, 840);
            this.pnlContent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(672, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chọn thời gian:";
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(678, 219);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(272, 30);
            this.dtpTime.TabIndex = 9;
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNam.FlatAppearance.BorderSize = 0;
            this.btnNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNam.Location = new System.Drawing.Point(816, 279);
            this.btnNam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(135, 50);
            this.btnNam.TabIndex = 7;
            this.btnNam.Text = "Năm";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThang.FlatAppearance.BorderSize = 0;
            this.btnThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThang.Location = new System.Drawing.Point(677, 279);
            this.btnThang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(135, 50);
            this.btnThang.TabIndex = 6;
            this.btnThang.Text = "Tháng";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Black;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(758, 556);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(193, 49);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemTietKiem
            // 
            this.btnThemTietKiem.BackColor = System.Drawing.Color.Black;
            this.btnThemTietKiem.FlatAppearance.BorderSize = 0;
            this.btnThemTietKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTietKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTietKiem.ForeColor = System.Drawing.Color.White;
            this.btnThemTietKiem.Location = new System.Drawing.Point(561, 556);
            this.btnThemTietKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThemTietKiem.Name = "btnThemTietKiem";
            this.btnThemTietKiem.Size = new System.Drawing.Size(193, 49);
            this.btnThemTietKiem.TabIndex = 4;
            this.btnThemTietKiem.Text = "Thêm Tiết Kiệm";
            this.btnThemTietKiem.UseVisualStyleBackColor = false;
            this.btnThemTietKiem.Click += new System.EventHandler(this.btnThemTietKiem_Click);
            // 
            // dgvTietKiem
            // 
            this.dgvTietKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTietKiem.Location = new System.Drawing.Point(40, 357);
            this.dgvTietKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTietKiem.Name = "dgvTietKiem";
            this.dgvTietKiem.RowHeadersWidth = 82;
            this.dgvTietKiem.RowTemplate.Height = 33;
            this.dgvTietKiem.Size = new System.Drawing.Size(909, 193);
            this.dgvTietKiem.TabIndex = 3;
            // 
            // txtTongTietKiem
            // 
            this.txtTongTietKiem.Location = new System.Drawing.Point(677, 109);
            this.txtTongTietKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTongTietKiem.Multiline = true;
            this.txtTongTietKiem.Name = "txtTongTietKiem";
            this.txtTongTietKiem.Size = new System.Drawing.Size(273, 41);
            this.txtTongTietKiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng Số Tiền Tiết Kiệm";
            // 
            // chartTietKiem
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTietKiem.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTietKiem.Legends.Add(legend2);
            this.chartTietKiem.Location = new System.Drawing.Point(40, 32);
            this.chartTietKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chartTietKiem.Name = "chartTietKiem";
            this.chartTietKiem.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTietKiem.Series.Add(series2);
            this.chartTietKiem.Size = new System.Drawing.Size(613, 319);
            this.chartTietKiem.TabIndex = 0;
            this.chartTietKiem.Text = "chart1";
            // 
            // frmTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 840);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTietKiem";
            this.Text = "frmTietKiem";
            this.Load += new System.EventHandler(this.frmTietKiem_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTietKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTietKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemTietKiem;
        private System.Windows.Forms.DataGridView dgvTietKiem;
        private System.Windows.Forms.TextBox txtTongTietKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTietKiem;
    }
}