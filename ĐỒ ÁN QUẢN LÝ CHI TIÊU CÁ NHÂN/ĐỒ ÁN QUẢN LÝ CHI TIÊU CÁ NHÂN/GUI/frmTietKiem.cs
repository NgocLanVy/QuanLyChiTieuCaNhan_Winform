using ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.DTO;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmTietKiem : Form
    {
        Database db = new Database();

        public frmTietKiem()
        {
            InitializeComponent();
        }

        private void frmTietKiem_Load(object sender, EventArgs e)
        {
            CauHinhDgv();
            LoadDuLieuTietKiem(DateTime.Now.Month, DateTime.Now.Year);
        }

        void CauHinhDgv()
        {
            dgvTietKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTietKiem.RowTemplate.Height = 35;
            dgvTietKiem.BorderStyle = BorderStyle.None;
            dgvTietKiem.BackgroundColor = System.Drawing.Color.White;
            dgvTietKiem.ReadOnly = true;
            dgvTietKiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTietKiem.RowHeadersVisible = false;
            dgvTietKiem.AllowUserToAddRows = false;
        }

        private void LoadDuLieuTietKiem(int thang, int nam)
        {
            try
            {
                dgvTietKiem.DataSource = null;
                dgvTietKiem.Columns.Clear();

                // Dùng alias không dấu, không cách
                string sql = $@"SELECT 
                        TenMucTieu    AS TenMucTieu,
                        SoTienHienCo AS SoTienHienCo,
                        SoTienMucTieu AS SoTienMucTieu,
                        NgayHanChot  AS NgayHanChot
                        FROM TietKiem
                        WHERE Username = '{Session.Username}'
                        AND MONTH(NgayBatDau) = {thang}
                        AND YEAR(NgayBatDau) = {nam}";

                DataTable dt = db.Excute(sql);
                dgvTietKiem.DataSource = dt;

                // Đặt header sau khi có data
                if (dgvTietKiem.Columns.Count >= 4)
                {
                    dgvTietKiem.Columns["TenMucTieu"].HeaderText = "Tên mục tiêu";
                    dgvTietKiem.Columns["SoTienHienCo"].HeaderText = "Số tiền hiện có";
                    dgvTietKiem.Columns["SoTienMucTieu"].HeaderText = "Mục tiêu";
                    dgvTietKiem.Columns["NgayHanChot"].HeaderText = "Ngày hạn chót";
                    dgvTietKiem.Columns["SoTienHienCo"].DefaultCellStyle.Format = "N0";
                    dgvTietKiem.Columns["SoTienMucTieu"].DefaultCellStyle.Format = "N0";
                }

                dgvTietKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                decimal tongTien = 0;
                foreach (DataRow row in dt.Rows)
                    tongTien += Convert.ToDecimal(row["SoTienHienCo"]);

                txtTongTietKiem.Text = tongTien.ToString("N0") + " VNĐ";
                VeBieuDoTietKiem(dt, thang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDuLieuTheoNam(int nam)
        {
            try
            {
                dgvTietKiem.DataSource = null;
                dgvTietKiem.Columns.Clear();

                string sql = $@"SELECT 
                        TenMucTieu    AS TenMucTieu,
                        SoTienHienCo AS SoTienHienCo,
                        SoTienMucTieu AS SoTienMucTieu,
                        NgayHanChot  AS NgayHanChot
                        FROM TietKiem
                        WHERE Username = '{Session.Username}'
                        AND YEAR(NgayBatDau) = {nam}";

                DataTable dt = db.Excute(sql);
                dgvTietKiem.DataSource = dt;

                if (dgvTietKiem.Columns.Count >= 4)
                {
                    dgvTietKiem.Columns["TenMucTieu"].HeaderText = "Tên mục tiêu";
                    dgvTietKiem.Columns["SoTienHienCo"].HeaderText = "Số tiền hiện có";
                    dgvTietKiem.Columns["SoTienMucTieu"].HeaderText = "Mục tiêu";
                    dgvTietKiem.Columns["NgayHanChot"].HeaderText = "Ngày hạn chót";
                    dgvTietKiem.Columns["SoTienHienCo"].DefaultCellStyle.Format = "N0";
                    dgvTietKiem.Columns["SoTienMucTieu"].DefaultCellStyle.Format = "N0";
                }

                dgvTietKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                decimal tongTien = 0;
                foreach (DataRow row in dt.Rows)
                    tongTien += Convert.ToDecimal(row["SoTienHienCo"]);

                txtTongTietKiem.Text = tongTien.ToString("N0") + " VNĐ";
                VeBieuDoTietKiem(dt, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void VeBieuDoTietKiem(DataTable dt, int thang)
        {
            chartTietKiem.Series.Clear();
            chartTietKiem.Titles.Clear();

            string tieuDe = thang > 0
                ? "Phân bổ tiết kiệm tháng " + thang
                : "Phân bổ tiết kiệm cả năm";
            chartTietKiem.Titles.Add(tieuDe);

            Series series = new Series
            {
                Name = "TietKiem",
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };
            chartTietKiem.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                double soTien = Convert.ToDouble(row["SoTienHienCo"]);
                if (soTien > 0)
                    series.Points.AddXY(row["TenMucTieu"].ToString(), soTien);
            }

            if (chartTietKiem.Legends.Count > 0)
                chartTietKiem.Legends[0].Enabled = true;
        }

        private void btnThemTietKiem_Click(object sender, EventArgs e)
        {
            frmThemTietKiem frm = new frmThemTietKiem();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadDuLieuTietKiem(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTietKiem.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa mục tiết kiệm này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string tenMucTieu = dgvTietKiem.CurrentRow
                        .Cells["Tên mục tiêu"].Value.ToString();

                    string sql = $@"DELETE FROM TietKiem 
                                    WHERE TenMucTieu = N'{tenMucTieu}' 
                                    AND Username = '{Session.Username}'";
                    db.ExcuteNonQuery(sql);

                    MessageBox.Show("Xóa thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDuLieuTietKiem(dtpTime.Value.Month, dtpTime.Value.Year);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            LoadDuLieuTietKiem(dtpTime.Value.Month, dtpTime.Value.Year);
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            LoadDuLieuTheoNam(dtpTime.Value.Year);
        }
    }
}