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
    public partial class frmThemChi : Form
    {
        Database db = new Database();
        string tenDanhMuc = "";
        public frmThemChi()
        {
            InitializeComponent();
        }

        private void frmThemChi_Load(object sender, EventArgs e)
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
        }

        private void btnChonTaiKhoan_Click(object sender, EventArgs e)
        {
            dgvViTien.Visible =!dgvViTien.Visible;
        }

        private void dgvViTien_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnAnUong_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Ăn uống";
        }

        private void btnMuaSam_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Mua sắm";
        }

        private void btnXeCo_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Xe cộ";
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Hóa đơn";
        }

        private void btnGiaiTri_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Giải trí";
        }

        private void btnYTe_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Y tế";
        }

        private void btnHocTap_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Học tập";
        }

        private void btnDuLich_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Du lịch";
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            tenDanhMuc = "Khác";
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

            int dong =
                dgvViTien.CurrentRow.Index;

            int maVi =
                Convert.ToInt32(
                dgvViTien.Rows[dong]
                .Cells[0]
                .Value);

            decimal soTien =
                Convert.ToDecimal(
                txtSoTien.Text);

            string sql = @"INSERT INTO ChiTieu
                           (
                               TenChiTieu,
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

            string sqlUpdate =
                @"UPDATE ViTien
                  SET SoDu = SoDu - " + soTien + @"
                  WHERE MaVi = " + maVi;

            db.ExcuteNonQuery(sqlUpdate);

            MessageBox.Show("Thêm thành công");

            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
