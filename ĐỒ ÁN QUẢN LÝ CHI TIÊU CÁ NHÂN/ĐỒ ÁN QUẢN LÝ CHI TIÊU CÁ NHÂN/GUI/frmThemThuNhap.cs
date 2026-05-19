using System;
using System.Windows.Forms;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmThemThuNhap : Form
    {
        Database db = new Database();

        string tenDanhMuc = "";

        public frmThemThuNhap()
        {
            InitializeComponent();
        }

        private void frmThemThuNhap_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT
                           MaVi,
                           TenVi,
                           SoDu
                           FROM ViTien
                           WHERE Username = 'admin'";

            dgvViTien.DataSource = db.Excute(sql);

            dgvViTien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvViTien.RowHeadersVisible = false;
            dgvViTien.Visible = false;
            dgvViTien.Columns[0].HeaderText = "Mã Ví";
            dgvViTien.Columns[1].HeaderText = "Tên Ví";
            dgvViTien.Columns[2].HeaderText = "Số Dư";
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Lương";
        }

        private void btnViecVat_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Việc vặt";
        }

        private void btnTietKiem_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Tiết kiệm";
        }

        private void btnDauTu_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Đầu tư";
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Thưởng";
        }

        private void btnLamThem_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Làm thêm";
        }

        private void btnHoaHong_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Hoa hồng";
        }

        private void btnPhuCap_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Phụ cấp";
        }

        private void btnQuaTang_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Quà tặng";
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (txtSoTien.Text == "")
            {
                MessageBox.Show("Nhập số tiền");

                return;
            }

            if (tenDanhMuc == "")
            {
                MessageBox.Show("Chọn danh mục");

                return;
            }

            if (dgvViTien.CurrentRow == null)
            {
                MessageBox.Show("Chọn ví tiền");

                return;
            }

            int dong = dgvViTien.CurrentRow.Index;

            int maVi =
                Convert.ToInt32(
                dgvViTien.Rows[dong].Cells[0].Value);

            decimal soTien =
                Convert.ToDecimal(txtSoTien.Text);

            // ===== THÊM THU NHẬP =====

            string sql = @"INSERT INTO ThuNhap
                   (
                       TenThuNhap,
                       SoTien,
                       Ngay,
                       MaVi,
                       Username
                   )
                   VALUES
                   (
                       N'" + tenDanhMuc + @"',
                       " + soTien + @",
                       GETDATE(),
                       " + maVi + @",
                       'admin'
                   )";

            db.ExcuteNonQuery(sql);

            string sqlUpdate = @"UPDATE ViTien SET SoDu = SoDu + " + soTien + @" WHERE MaVi = " + maVi;

            db.ExcuteNonQuery(sqlUpdate);

            MessageBox.Show("Thêm thành công");

            this.Close();
        }

        private void btnChonTaiKhoan_Click(object sender, EventArgs e)
        {
            dgvViTien.Visible = true;
        }
        private void dgvViTien_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                string tenVi =
                    dgvViTien.Rows[dong]
                    .Cells[1]
                    .Value
                    .ToString();
                btnChonTaiKhoan.Text = tenVi;
                dgvViTien.Visible = false;
            }
        }
    }
}