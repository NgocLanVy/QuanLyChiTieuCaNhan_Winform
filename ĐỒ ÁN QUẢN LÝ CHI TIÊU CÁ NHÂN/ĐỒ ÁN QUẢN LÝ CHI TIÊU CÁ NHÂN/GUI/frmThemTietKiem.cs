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

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmThemTietKiem : Form
    {
        Database db = new Database();
        string tenMucTieu = "";
        int maViChon = -1;

        public frmThemTietKiem()
        {
            InitializeComponent();
            this.Load += frmThemTietKiem_Load;
            btnHoanThanh.Click += btnHoanThanh_Click;
            btnChonTaiKhoan.Click += btnChonTaiKhoan_Click;
            dgvViTien.CellClick += dgvViTien_CellClick;

            btnNSCanhan.Click += (s, e) => ChonMucTieu("Ngân sách cá nhân", btnNSCanhan);
            btnQKhanCap.Click += (s, e) => ChonMucTieu("Quỹ khẩn cấp", btnQKhanCap);
            btnQDuPhong.Click += (s, e) => ChonMucTieu("Quỹ dự phòng", btnQDuPhong);
            btnSTietKiem.Click += (s, e) => ChonMucTieu("Sổ tiết kiệm", btnSTietKiem);
            btnDauTu.Click += (s, e) => ChonMucTieu("Đầu tư bản thân", btnDauTu);
            btnKhac.Click += (s, e) => ChonMucTieu("Khác", btnKhac);
        }

        private void frmThemTietKiem_Load(object sender, EventArgs e)
        {
            LoadViTien();
            dgvViTien.Visible = true;
        }
        void LoadViTien()
        {
            string sql = $@"SELECT MaVi, TenVi, SoDu
                            FROM ViTien
                            WHERE Username = '{Session.Username}'";
            dgvViTien.DataSource = db.Excute(sql);
            dgvViTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViTien.RowHeadersVisible = false;
            dgvViTien.ReadOnly = true;
            dgvViTien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViTien.AllowUserToAddRows = false;

            if (dgvViTien.Columns["MaVi"] != null)
                dgvViTien.Columns["MaVi"].Visible = false;
            if (dgvViTien.Columns["SoDu"] != null)
                dgvViTien.Columns["SoDu"].DefaultCellStyle.Format = "N0";
        }
        void ChonMucTieu(string ten, Button btnChon)
        {
            tenMucTieu = ten;
            foreach (Control c in pnlDanhMuc.Controls)
            {
                if (c is Button btn)
                    btn.BackColor = Color.FromArgb(90, 90, 90);
            }
            btnChon.BackColor = Color.FromArgb(30, 144, 255);
        }

        private void btnChonTaiKhoan_Click(object sender, EventArgs e)
        {
            dgvViTien.Visible = !dgvViTien.Visible;
            dgvViTien.BringToFront();
        }

        private void dgvViTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            maViChon = Convert.ToInt32(dgvViTien.Rows[e.RowIndex].Cells["MaVi"].Value);
            string tenVi = dgvViTien.Rows[e.RowIndex].Cells["TenVi"].Value.ToString();
            decimal soDu = Convert.ToDecimal(dgvViTien.Rows[e.RowIndex].Cells["SoDu"].Value);
            btnChonTaiKhoan.Text = $"{tenVi} - {soDu:N0} VNĐ";
            dgvViTien.Visible = false;
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenMucTieu))
            {
                MessageBox.Show("Vui lòng chọn mục tiêu tiết kiệm!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (maViChon == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền mục tiêu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal soTienMucTieu;
            if (!decimal.TryParse(txtSoTien.Text.Replace(",", "").Trim(),
                out soTienMucTieu) || soTienMucTieu <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sqlSoDu = $"SELECT SoDu FROM ViTien WHERE MaVi = {maViChon}";
                decimal soDu = Convert.ToDecimal(db.ExecuteScalar(sqlSoDu));

                if (soTienMucTieu > soDu)
                {
                    MessageBox.Show(
                        "Số tiền tiết kiệm vượt quá số dư ví!\n" +
                        "Số dư hiện có: " + soDu.ToString("N0") + " VNĐ",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sqlInsert = $@"INSERT INTO TietKiem
                                     (TenMucTieu, SoTienMucTieu, SoTienHienCo,
                                      NgayBatDau, NgayHanChot, Username)
                                     VALUES
                                     (N'{tenMucTieu}', {soTienMucTieu}, {soTienMucTieu},
                                      GETDATE(), DATEADD(month, 1, GETDATE()),
                                      '{Session.Username}')";
                db.ExcuteNonQuery(sqlInsert);

                string sqlUpdateVi = $@"UPDATE ViTien
                                        SET SoDu = SoDu - {soTienMucTieu}
                                        WHERE MaVi = {maViChon}";
                db.ExcuteNonQuery(sqlUpdateVi);

                MessageBox.Show("Thêm mục tiêu tiết kiệm thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
