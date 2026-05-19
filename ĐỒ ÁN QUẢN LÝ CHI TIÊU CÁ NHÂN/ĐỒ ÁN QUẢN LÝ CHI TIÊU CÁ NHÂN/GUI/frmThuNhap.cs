using ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmThuNhap : Form
    {
        Database db = new Database();
        int maThuNhapChon = -1;
        public frmThuNhap()
        {
            InitializeComponent();
            btn7ngay.Click += btn7ngay_Click;
            btnThang.Click += btnThang_Click;
            btnNam.Click += btnNam_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
            btnDanhsach.Click += btnDanhsach_Click;
            dgvDanhSachThuNhap.CellClick += dgvDanhSachThuNhap_CellClick;
        }

        private void frmThuNhap_Load(object sender, EventArgs e)
        {
            CauHinhDgv();
            LoadComboBoxData();
            LoadDanhSach7Ngay();
            LoadChart7Ngay();
        }
        void CauHinhDgv()
        {
            dgvDanhSachThuNhap.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachThuNhap.RowTemplate.Height = 33;
            dgvDanhSachThuNhap.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachThuNhap.ReadOnly = true;
            dgvDanhSachThuNhap.AllowUserToAddRows = false;
            dgvDanhSachThuNhap.RowHeadersVisible = false;
            dgvDanhSachThuNhap.BackgroundColor = Color.White;
            dgvDanhSachThuNhap.BorderStyle = BorderStyle.None;
        }

        void LoadComboBoxData()
        {
            DataTable dtLoai = db.Excute(
                $"SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc WHERE Username = '{Session.Username}'");
            cboLoai.DataSource = dtLoai;
            cboLoai.DisplayMember = "TenDanhMuc";
            cboLoai.ValueMember = "MaDanhMuc";

            DataTable dtNguon = db.Excute(
                $"SELECT MaVi, TenVi FROM ViTien WHERE Username = '{Session.Username}'");
            cboNguon.DataSource = dtNguon;
            cboNguon.DisplayMember = "TenVi";
            cboNguon.ValueMember = "MaVi";
        }

        void LoadDanhSach7Ngay()
        {
            string sql = $@"SELECT MaThuNhap, TenThuNhap, SoTien, Ngay
                            FROM ThuNhap
                            WHERE Username = '{Session.Username}'
                            AND Ngay >= DATEADD(day, -7, GETDATE())
                            ORDER BY Ngay DESC";

            DataTable dt = db.Excute(sql);
            dgvDanhSachThuNhap.DataSource = dt;

            if (dgvDanhSachThuNhap.Columns["MaThuNhap"] != null)
                dgvDanhSachThuNhap.Columns["MaThuNhap"].Visible = false;
            if (dgvDanhSachThuNhap.Columns["SoTien"] != null)
                dgvDanhSachThuNhap.Columns["SoTien"].DefaultCellStyle.Format = "N0";

            btnThuNhap.Text = "Thu nhập trong 7 ngày gần đây";
        }

        void LoadChart7Ngay()
        {
            string sql = $@"SELECT Ngay, SUM(SoTien) as TongTien
                            FROM ThuNhap
                            WHERE Username = '{Session.Username}'
                            AND Ngay >= DATEADD(day, -7, GETDATE())
                            GROUP BY Ngay
                            ORDER BY Ngay ASC";

            DataTable dt = db.Excute(sql);
            VeBieuDo(dt, "Ngay", "TongTien", "Thu nhập 7 ngày", "dd/MM");
        }

        void VeBieuDo(DataTable dt, string colX, string colY,
            string tenSeries, string formatNgay = null)
        {
            chartThuNhap.Series.Clear();
            Series series = new Series(tenSeries)
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SeaGreen
            };

            foreach (DataRow row in dt.Rows)
            {
                string nhanX = formatNgay != null
                    ? Convert.ToDateTime(row[colX]).ToString(formatNgay)
                    : row[colX].ToString();
                series.Points.AddXY(nhanX, row[colY]);
            }

            chartThuNhap.Series.Add(series);
            chartThuNhap.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
        }

        private void dgvDanhSachThuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0) return;

            maThuNhapChon = Convert.ToInt32(
                dgvDanhSachThuNhap.Rows[i].Cells["MaThuNhap"].Value);

            string sql = $"SELECT * FROM ThuNhap WHERE MaThuNhap = {maThuNhapChon}";
            DataTable dt = db.Excute(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                txtTien.Text = Convert.ToDecimal(r["SoTien"]).ToString("N0");
                dtpThuNhap.Value = Convert.ToDateTime(r["Ngay"]);

                if (r["MaDanhMuc"] != DBNull.Value)
                    cboLoai.SelectedValue = r["MaDanhMuc"];
                if (r["MaVi"] != DBNull.Value)
                    cboNguon.SelectedValue = r["MaVi"];
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maThuNhapChon == -1)
            {
                MessageBox.Show("Vui lòng chọn thu nhập cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa khoản thu nhập này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                db.ExcuteNonQuery(
                    $"DELETE FROM ThuNhap WHERE MaThuNhap = {maThuNhapChon}");

                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadDanhSach7Ngay();
                LoadChart7Ngay();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maThuNhapChon == -1)
            {
                MessageBox.Show("Vui lòng chọn thu nhập cần sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal soTien;
            string soTienStr = txtTien.Text.Replace(",", "").Trim();
            if (!decimal.TryParse(soTienStr, out soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = $@"UPDATE ThuNhap SET
                            SoTien = {soTien},
                            Ngay = '{dtpThuNhap.Value:yyyy-MM-dd}',
                            TenThuNhap = N'{cboLoai.Text}',
                            MaDanhMuc = {cboLoai.SelectedValue},
                            MaVi = {cboNguon.SelectedValue}
                            WHERE MaThuNhap = {maThuNhapChon}";

            db.ExcuteNonQuery(sql);

            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
            LoadDanhSach7Ngay();
            LoadChart7Ngay();
        }

        private void btn7ngay_Click(object sender, EventArgs e)
        {
            LoadDanhSach7Ngay();
            LoadChart7Ngay();
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;

            string sqlDs = $@"SELECT MaThuNhap, TenThuNhap, SoTien, Ngay
                              FROM ThuNhap
                              WHERE Username = '{Session.Username}'
                              AND MONTH(Ngay) = {thang}
                              AND YEAR(Ngay) = {nam}
                              ORDER BY Ngay DESC";
            DataTable dtDs = db.Excute(sqlDs);
            dgvDanhSachThuNhap.DataSource = dtDs;
            if (dgvDanhSachThuNhap.Columns["MaThuNhap"] != null)
                dgvDanhSachThuNhap.Columns["MaThuNhap"].Visible = false;

            string sqlChart = $@"SELECT DAY(Ngay) as Ngay, SUM(SoTien) as TongTien
                                 FROM ThuNhap
                                 WHERE Username = '{Session.Username}'
                                 AND MONTH(Ngay) = {thang}
                                 AND YEAR(Ngay) = {nam}
                                 GROUP BY DAY(Ngay)
                                 ORDER BY DAY(Ngay) ASC";
            DataTable dtChart = db.Excute(sqlChart);
            VeBieuDo(dtChart, "Ngay", "TongTien", $"Tháng {thang}/{nam}");

            btnThuNhap.Text = $"Thu nhập tháng {thang}/{nam}";

        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            int nam = DateTime.Now.Year;

            string sqlDs = $@"SELECT MaThuNhap, TenThuNhap, SoTien, Ngay
                              FROM ThuNhap
                              WHERE Username = '{Session.Username}'
                              AND YEAR(Ngay) = {nam}
                              ORDER BY Ngay DESC";
            DataTable dtDs = db.Excute(sqlDs);
            dgvDanhSachThuNhap.DataSource = dtDs;
            if (dgvDanhSachThuNhap.Columns["MaThuNhap"] != null)
                dgvDanhSachThuNhap.Columns["MaThuNhap"].Visible = false;

            string sqlChart = $@"SELECT FORMAT(Ngay,'MM/yyyy') as ThangNam,
                                        SUM(SoTien) as TongTien
                                 FROM ThuNhap
                                 WHERE Username = '{Session.Username}'
                                 AND YEAR(Ngay) = {nam}
                                 GROUP BY FORMAT(Ngay,'MM/yyyy'), MONTH(Ngay)
                                 ORDER BY MONTH(Ngay) ASC";
            DataTable dtChart = db.Excute(sqlChart);
            VeBieuDo(dtChart, "ThangNam", "TongTien", $"Năm {nam}");

            btnThuNhap.Text = $"Thu nhập năm {nam}";
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            frmReportThuNhap f = new frmReportThuNhap();
            f.ShowDialog();
        }
        void ResetForm()
        {
            maThuNhapChon = -1;
            txtTien.Text = "vui lòng chọn thu nhập";
            dgvDanhSachThuNhap.ClearSelection();
        }
    }
}
