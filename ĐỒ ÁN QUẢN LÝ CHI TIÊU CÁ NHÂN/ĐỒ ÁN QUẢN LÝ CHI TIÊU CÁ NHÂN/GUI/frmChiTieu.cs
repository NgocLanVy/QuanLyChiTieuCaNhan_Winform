using ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmChiTieu : Form
    {
        Database db = new Database();
        int maChiTieuChon = -1;
        public frmChiTieu()
        {
            InitializeComponent();
            btn7ngay.Click += btn7ngay_Click;
            btnThang.Click += btnThang_Click;
            btnNam.Click += btnNam_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
            btnDanhsach.Click += btnDanhsach_Click;
            dgvDanhSachChiTieu.CellClick += dgvDanhSachChiTieu_CellClick;
        }

        private void frmChiTieu_Load(object sender, EventArgs e)
        {
            CauHinhDgv();
            LoadComboBoxData();
            LoadDanhSach7Ngay();
            LoadChart7Ngay();
        }
        void CauHinhDgv()
        {
            dgvDanhSachChiTieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachChiTieu.RowTemplate.Height = 33;
            dgvDanhSachChiTieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachChiTieu.ReadOnly = true;
            dgvDanhSachChiTieu.AllowUserToAddRows = false;
            dgvDanhSachChiTieu.RowHeadersVisible = false;
            dgvDanhSachChiTieu.BackgroundColor = Color.White;
            dgvDanhSachChiTieu.BorderStyle = BorderStyle.None;
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
            string sql = $@"SELECT MaChiTieu, TenChiTieu, SoTien, Ngay
                            FROM ChiTieu
                            WHERE Username = '{Session.Username}'
                            AND Ngay >= DATEADD(day, -7, GETDATE())
                            ORDER BY Ngay DESC";

            DataTable dt = db.Excute(sql);
            dgvDanhSachChiTieu.DataSource = dt;

            if (dgvDanhSachChiTieu.Columns["MaChiTieu"] != null)
                dgvDanhSachChiTieu.Columns["MaChiTieu"].Visible = false;
            if (dgvDanhSachChiTieu.Columns["SoTien"] != null)
                dgvDanhSachChiTieu.Columns["SoTien"].DefaultCellStyle.Format = "N0";

            btnChiTieu.Text = "Chi tiêu trong 7 ngày gần đây";
        }

        void LoadChart7Ngay()
        {
            string sql = $@"SELECT Ngay, SUM(SoTien) as TongTien
                            FROM ChiTieu
                            WHERE Username = '{Session.Username}'
                            AND Ngay >= DATEADD(day, -7, GETDATE())
                            GROUP BY Ngay
                            ORDER BY Ngay ASC";

            DataTable dt = db.Excute(sql);
            VeBieuDo(dt, "Ngay", "TongTien", "Chi tiêu 7 ngày", "dd/MM");
        }

        void VeBieuDo(DataTable dt, string colX, string colY, string tenSeries, string formatNgay = null)
        {
            chartChiTieu.Series.Clear();
            Series series = new Series(tenSeries)
            {
                ChartType = SeriesChartType.Column,
                Color = Color.OrangeRed
            };

            foreach (DataRow row in dt.Rows)
            {
                string nhanX = formatNgay != null
                    ? Convert.ToDateTime(row[colX]).ToString(formatNgay)
                    : row[colX].ToString();
                series.Points.AddXY(nhanX, row[colY]);
            }

            chartChiTieu.Series.Add(series);
        }

        private void dgvDanhSachChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0) return;

            maChiTieuChon = Convert.ToInt32(
                dgvDanhSachChiTieu.Rows[i].Cells["MaChiTieu"].Value);

            string sql = $"SELECT * FROM ChiTieu WHERE MaChiTieu = {maChiTieuChon}";
            DataTable dt = db.Excute(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                txtTien.Text = Convert.ToDecimal(r["SoTien"]).ToString("N0");
                dtpChiTieu.Value = Convert.ToDateTime(r["Ngay"]);

                if (r["MaDanhMuc"] != DBNull.Value)
                    cboLoai.SelectedValue = r["MaDanhMuc"];
                if (r["MaVi"] != DBNull.Value)
                    cboNguon.SelectedValue = r["MaVi"];
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maChiTieuChon == -1)
            {
                MessageBox.Show("Vui lòng chọn chi tiêu cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa chi tiêu này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.ExcuteNonQuery($"DELETE FROM ChiTieu WHERE MaChiTieu = {maChiTieuChon}");
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                maChiTieuChon = -1;
                txtTien.Text = "";
                LoadDanhSach7Ngay();
                LoadChart7Ngay();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maChiTieuChon == -1)
            {
                MessageBox.Show("Vui lòng chọn chi tiêu cần sửa!",
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

            string sql = $@"UPDATE ChiTieu SET
                            SoTien = {soTien},
                            Ngay = '{dtpChiTieu.Value:yyyy-MM-dd}',
                            TenChiTieu = N'{cboLoai.Text}',
                            MaDanhMuc = {cboLoai.SelectedValue},
                            MaVi = {cboNguon.SelectedValue}
                            WHERE MaChiTieu = {maChiTieuChon}";

            db.ExcuteNonQuery(sql);
            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            maChiTieuChon = -1;
            txtTien.Text = "";
            LoadDanhSach7Ngay();
            LoadChart7Ngay();
        }

        private void btn7ngay_Click(object sender, EventArgs e)
        {
            LoadDanhSach7Ngay();
            LoadChart7Ngay();
            btnChiTieu.Text = "Chi tiêu trong 7 ngày gần đây";
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;

            string sqlDanhSach = $@"SELECT MaChiTieu, TenChiTieu, SoTien, Ngay
                                    FROM ChiTieu
                                    WHERE Username = '{Session.Username}'
                                    AND MONTH(Ngay) = {thang}
                                    AND YEAR(Ngay) = {nam}
                                    ORDER BY Ngay DESC";
            DataTable dtDs = db.Excute(sqlDanhSach);
            dgvDanhSachChiTieu.DataSource = dtDs;
            if (dgvDanhSachChiTieu.Columns["MaChiTieu"] != null)
                dgvDanhSachChiTieu.Columns["MaChiTieu"].Visible = false;

            string sqlChart = $@"SELECT DAY(Ngay) as Ngay, SUM(SoTien) as TongTien
                                 FROM ChiTieu
                                 WHERE Username = '{Session.Username}'
                                 AND MONTH(Ngay) = {thang}
                                 AND YEAR(Ngay) = {nam}
                                 GROUP BY DAY(Ngay)
                                 ORDER BY DAY(Ngay) ASC";
            DataTable dtChart = db.Excute(sqlChart);
            VeBieuDo(dtChart, "Ngay", "TongTien", $"Tháng {thang}/{nam}");

            btnChiTieu.Text = $"Chi tiêu tháng {thang}/{nam}";
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            int nam = DateTime.Now.Year;

            string sqlDanhSach = $@"SELECT MaChiTieu, TenChiTieu, SoTien, Ngay
                                    FROM ChiTieu
                                    WHERE Username = '{Session.Username}'
                                    AND YEAR(Ngay) = {nam}
                                    ORDER BY Ngay DESC";
            DataTable dtDs = db.Excute(sqlDanhSach);
            dgvDanhSachChiTieu.DataSource = dtDs;
            if (dgvDanhSachChiTieu.Columns["MaChiTieu"] != null)
                dgvDanhSachChiTieu.Columns["MaChiTieu"].Visible = false;

            string sqlChart = $@"SELECT FORMAT(Ngay,'MM/yyyy') as ThangNam,
                                        SUM(SoTien) as TongTien
                                 FROM ChiTieu
                                 WHERE Username = '{Session.Username}'
                                 AND YEAR(Ngay) = {nam}
                                 GROUP BY FORMAT(Ngay,'MM/yyyy'), MONTH(Ngay)
                                 ORDER BY MONTH(Ngay) ASC";
            DataTable dtChart = db.Excute(sqlChart);
            VeBieuDo(dtChart, "ThangNam", "TongTien", $"Năm {nam}");

            btnChiTieu.Text = $"Chi tiêu năm {nam}";
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            frmReportChiTieu f = new frmReportChiTieu();
            f.ShowDialog();
        }
    }
}
