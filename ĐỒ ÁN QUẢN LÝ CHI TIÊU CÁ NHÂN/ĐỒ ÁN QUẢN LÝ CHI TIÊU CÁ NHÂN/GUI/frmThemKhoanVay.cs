using ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmThemKhoanVay : Form
    {
        Database db = new Database();

        int maViDuocChon = -1;

        public event EventHandler OnDataAdded;

        public frmThemKhoanVay()
        {
            InitializeComponent();

            this.Load += frmThemKhoanVay_Load;

            btnThemMoi.Click += btnThemMoi_Click;
            btnHuy.Click += btnHuy_Click;

            dgvTaiKhoanVay.CellClick += dgvTaiKhoanVay_CellClick;
        }

        private void frmThemKhoanVay_Load(object sender, EventArgs e)
        {
            dtpNgayHan.MinDate = DateTime.Now;

            LoadDanhSachVi();
        }

        void LoadDanhSachVi()
        {
            try
            {
                string sql = $@"
                SELECT 
                    MaVi,
                    TenVi,
                    SoDu
                FROM ViTien
                WHERE Username = '{Session.Username}'";

                dgvTaiKhoanVay.DataSource = db.Excute(sql);

                dgvTaiKhoanVay.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvTaiKhoanVay.RowHeadersVisible = false;
                dgvTaiKhoanVay.AllowUserToAddRows = false;
                dgvTaiKhoanVay.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                if (dgvTaiKhoanVay.Columns["MaVi"] != null)
                    dgvTaiKhoanVay.Columns["MaVi"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load ví: " + ex.Message);
            }
        }

        private void dgvTaiKhoanVay_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTaiKhoanVay.Rows[e.RowIndex];

            maViDuocChon =
                Convert.ToInt32(row.Cells["MaVi"].Value);

            btnChonTaiKhoan.Text =
                row.Cells["TenVi"].Value.ToString();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtThemKhoanVay.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khoản vay!");
                txtThemKhoanVay.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoTienVay.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền vay!");
                txtSoTienVay.Focus();
                return;
            }

            if (maViDuocChon == -1)
            {
                MessageBox.Show("Vui lòng chọn ví!");
                return;
            }

            decimal soTien;

            if (!decimal.TryParse(txtSoTienVay.Text, out soTien))
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                return;
            }

            if (soTien <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0!");
                return;
            }

            try
            {
                string tenKhoanVay =
                    txtThemKhoanVay.Text.Trim();

                string ngayVay =
                    DateTime.Now.ToString("yyyy-MM-dd");

                string hanTra =
                    dtpNgayHan.Value.ToString("yyyy-MM-dd");

                string sql = $@"
                INSERT INTO KhoanVay
                (
                    TenKhoanVay,
                    SoTienVay,
                    NgayVay,
                    HanTra,
                    TrangThai,
                    MaVi,
                    Username
                )
                VALUES
                (
                    N'{tenKhoanVay}',
                    {soTien},
                    '{ngayVay}',
                    '{hanTra}',
                    N'Chưa thanh toán',
                    {maViDuocChon},
                    '{Session.Username}'
                )";

                db.ExcuteNonQuery(sql);

                MessageBox.Show("Thêm khoản vay thành công!");

                OnDataAdded?.Invoke(this, EventArgs.Empty);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}