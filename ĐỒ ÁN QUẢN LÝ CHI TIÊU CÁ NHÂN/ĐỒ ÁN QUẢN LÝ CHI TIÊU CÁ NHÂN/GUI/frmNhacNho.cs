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
    public partial class frmNhacNho : Form
    {
        Database db = new Database();
        int maChon = -1;

        public frmNhacNho()
        {
            InitializeComponent();
            this.Load += frmNhacNho_Load;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            dgvLichNhacNho.CellClick += dgvLichNhacNho_CellClick;
        }

        private void frmNhacNho_Load(object sender, EventArgs e)
        {
            CauHinhDgv();
            LoadData();
            VeBieuDo();
        }
        void CauHinhDgv()
        {
            dgvLichNhacNho.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichNhacNho.RowTemplate.Height = 33;
            dgvLichNhacNho.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvLichNhacNho.ReadOnly = true;
            dgvLichNhacNho.AllowUserToAddRows = false;
            dgvLichNhacNho.RowHeadersVisible = false;
            dgvLichNhacNho.BackgroundColor = Color.White;
            dgvLichNhacNho.BorderStyle = BorderStyle.None;
        }

        void LoadData()
        {
            string sql = $@"SELECT 
                            MaNhacNho,
                            NoiDung,
                            ThoiGianThongBao,
                            TrangThai
                            FROM NhacNho
                            WHERE Username = '{Session.Username}'
                            ORDER BY ThoiGianThongBao ASC";

            DataTable dt = db.Excute(sql);
            dgvLichNhacNho.DataSource = dt;

            if (dgvLichNhacNho.Columns["MaNhacNho"] != null)
            {
                dgvLichNhacNho.Columns["MaNhacNho"].Visible = false;
                dgvLichNhacNho.Columns["NoiDung"].HeaderText = "Nội dung";
                dgvLichNhacNho.Columns["ThoiGianThongBao"].HeaderText = "Thời gian";
                dgvLichNhacNho.Columns["TrangThai"].HeaderText = "Hoàn thành";
            }

            // Tô màu dòng quá hạn và đã hoàn thành
            foreach (DataGridViewRow row in dgvLichNhacNho.Rows)
            {
                bool hoanThanh = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                DateTime thoiGian = Convert.ToDateTime(
                    row.Cells["ThoiGianThongBao"].Value);

                if (hoanThanh)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (thoiGian < DateTime.Now)
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        void VeBieuDo()
        {
            string sql = $@"SELECT 
                            CAST(ThoiGianThongBao AS DATE) as Ngay,
                            COUNT(*) as SoLuong
                            FROM NhacNho
                            WHERE Username = '{Session.Username}'
                            GROUP BY CAST(ThoiGianThongBao AS DATE)
                            ORDER BY CAST(ThoiGianThongBao AS DATE) ASC";

            DataTable dt = db.Excute(sql);

            chartNhacNho.Series.Clear();
            chartNhacNho.Titles.Clear();
            chartNhacNho.Titles.Add("Lịch nhắc nhở");

            Series series = new Series("Công việc")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(65, 140, 240),
                IsValueShownAsLabel = true
            };

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    Convert.ToDateTime(row["Ngay"]).ToString("dd/MM"),
                    row["SoLuong"]);
            }

            chartNhacNho.Series.Add(series);
            if (chartNhacNho.Legends.Count > 0)
                chartNhacNho.Legends[0].Enabled = false;
        }

        private void dgvLichNhacNho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLichNhacNho.Rows[e.RowIndex];
            maChon = Convert.ToInt32(row.Cells["MaNhacNho"].Value);
            txtNoiDung.Text = row.Cells["NoiDung"].Value.ToString();
            dtpTime.Value = Convert.ToDateTime(row.Cells["ThoiGianThongBao"].Value);
            chkTrangThai.Checked = Convert.ToBoolean(row.Cells["TrangThai"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung nhắc nhở!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int trangThai = chkTrangThai.Checked ? 1 : 0;

            string sql = $@"INSERT INTO NhacNho
                           (NoiDung, ThoiGianThongBao, TrangThai, Username)
                           VALUES
                           (N'{txtNoiDung.Text.Trim()}',
                            '{dtpTime.Value:yyyy-MM-dd HH:mm:ss}',
                            {trangThai},
                            '{Session.Username}')";

            db.ExcuteNonQuery(sql);

            MessageBox.Show("Thêm nhắc nhở thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
            LoadData();
            VeBieuDo();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maChon == -1)
            {
                MessageBox.Show("Vui lòng chọn nhắc nhở cần sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung nhắc nhở!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int trangThai = chkTrangThai.Checked ? 1 : 0;

            string sql = $@"UPDATE NhacNho SET
                            NoiDung = N'{txtNoiDung.Text.Trim()}',
                            ThoiGianThongBao = '{dtpTime.Value:yyyy-MM-dd HH:mm:ss}',
                            TrangThai = {trangThai}
                            WHERE MaNhacNho = {maChon}
                            AND Username = '{Session.Username}'";

            db.ExcuteNonQuery(sql);

            MessageBox.Show("Cập nhật nhắc nhở thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
            LoadData();
            VeBieuDo();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maChon == -1)
            {
                MessageBox.Show("Vui lòng chọn nhắc nhở cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhắc nhở này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $@"DELETE FROM NhacNho
                                WHERE MaNhacNho = {maChon}
                                AND Username = '{Session.Username}'";

                db.ExcuteNonQuery(sql);

                MessageBox.Show("Xóa thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
                VeBieuDo();
            }
        }
        void ResetForm()
        {
            txtNoiDung.Clear();
            dtpTime.Value = DateTime.Now;
            chkTrangThai.Checked = false;
            maChon = -1;
            dgvLichNhacNho.ClearSelection();
        }
    }
}
