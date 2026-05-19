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
    public partial class frmKhoanVay : Form
    {
        Database db = new Database();
        int maVayDangChon = -1;
        public frmKhoanVay()
        {
            InitializeComponent();
            this.Load += frmKhoanVay_Load;
            dgvKhoanVay.CellClick += dgvKhoanVay_CellClick;
            dgvKhoanVayQuaHan.CellClick += dgvKhoanVayQuaHan_CellClick;
            dgvThanhToan.CellClick += dgvThanhToan_CellClick;
            btnThemKhoanVay.Click += btnThemKhoanVay_Click;
            btnThanhToan.Click += btnThanhToan_Click;
            btnXoahet.Click += btnXoahet_Click;
        }

        private void frmKhoanVay_Load(object sender, EventArgs e)
        {
            KiemTraVaTaoBang();
            CauHinhDgv();
            LoadTatCaDgv();
        }
        void KiemTraVaTaoBang()
        {
            try
            {
                string sql = @"
                IF NOT EXISTS
                (
                    SELECT * FROM sys.objects
                    WHERE object_id = OBJECT_ID(N'[KhoanVay]')
                    AND type = N'U'
                )
                BEGIN
                    CREATE TABLE KhoanVay
                    (
                        MaVay INT IDENTITY(1,1) PRIMARY KEY,

                        TenKhoanVay NVARCHAR(100) NOT NULL,

                        SoTienVay DECIMAL(18,2) NOT NULL,

                        NgayVay DATE NOT NULL,

                        HanTra DATE NOT NULL,

                        TrangThai NVARCHAR(50)
                        DEFAULT N'Chưa thanh toán',

                        GhiChu NVARCHAR(255),

                        Username NVARCHAR(50) NOT NULL,

                        FOREIGN KEY (Username)
                        REFERENCES TaiKhoan(Username)
                    )
                END";

                db.ExcuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo bảng: " + ex.Message);
            }
        }

        void CauHinhDgv()
        {
            foreach (DataGridView dgv in new[]
            {
                dgvKhoanVay,
                dgvKhoanVayQuaHan,
                dgvThanhToan
            })
            {
                dgv.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgv.RowTemplate.Height = 33;

                dgv.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgv.ReadOnly = true;

                dgv.AllowUserToAddRows = false;

                dgv.RowHeadersVisible = false;
            }
        }

        public void LoadTatCaDgv()
        {
            try
            {

                string sqlChuaThanhToan = $@"
                SELECT
                    MaVay,
                    TenKhoanVay,
                    SoTienVay,
                    HanTra
                FROM KhoanVay
                WHERE Username = '{Session.Username}'
                AND TrangThai = N'Chưa thanh toán'
                AND HanTra >= CAST(GETDATE() AS DATE)";

                dgvKhoanVay.DataSource =
                    db.Excute(sqlChuaThanhToan);


                string sqlQuaHan = $@"
                SELECT
                    MaVay,
                    TenKhoanVay,
                    SoTienVay,
                    HanTra
                FROM KhoanVay
                WHERE Username = '{Session.Username}'
                AND TrangThai = N'Chưa thanh toán'
                AND HanTra < CAST(GETDATE() AS DATE)";

                dgvKhoanVayQuaHan.DataSource =
                    db.Excute(sqlQuaHan);


                string sqlDaThanhToan = $@"
                SELECT
                    MaVay,
                    TenKhoanVay,
                    SoTienVay,
                    HanTra
                FROM KhoanVay
                WHERE Username = '{Session.Username}'
                AND TrangThai = N'Đã thanh toán'";

                dgvThanhToan.DataSource =
                    db.Excute(sqlDaThanhToan);


                foreach (DataGridView dgv in new[]
                {
                    dgvKhoanVay,
                    dgvKhoanVayQuaHan,
                    dgvThanhToan
                })
                {
                    if (dgv.Columns["MaVay"] != null)
                    {
                        dgv.Columns["MaVay"].Visible = false;
                        dgv.Columns["SoTienVay"].DefaultCellStyle.Format = "N0";
                    }
                }

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        void DisplayDetail
        (
            DataGridView dgv,
            int rowIndex,
            string trangThai
        )
        {
            if (rowIndex < 0)
                return;

            if (dgv.Rows[rowIndex].Cells["MaVay"].Value == null)
                return;

            DataGridViewRow row = dgv.Rows[rowIndex];

            maVayDangChon =
                Convert.ToInt32(row.Cells["MaVay"].Value);

            txtKhoanVay.Text =
                row.Cells["TenKhoanVay"].Value.ToString();

            txtSodu.Text =
                Convert.ToDecimal(row.Cells["SoTienVay"].Value)
                .ToString("N0") + " VNĐ";

            txtThoiHan.Text =
                Convert.ToDateTime(row.Cells["HanTra"].Value)
                .ToString("dd/MM/yyyy");

            txtTrangThai.Text = trangThai;
        }

        void ClearFields()
        {
            txtKhoanVay.Clear();
            txtSodu.Clear();
            txtThoiHan.Clear();
            txtTrangThai.Clear();

            maVayDangChon = -1;
        }

        private void dgvKhoanVay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayDetail(dgvKhoanVay, e.RowIndex, "Chưa thanh toán");
        }

        private void dgvKhoanVayQuaHan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayDetail(dgvKhoanVayQuaHan, e.RowIndex, "Quá hạn");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (maVayDangChon == -1)
            {
                MessageBox.Show
                (
                    "Vui lòng chọn khoản vay!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (txtTrangThai.Text == "Đã thanh toán")
            {
                MessageBox.Show
                (
                    "Khoản vay đã thanh toán rồi!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult r = MessageBox.Show
            (
                "Xác nhận thanh toán khoản vay?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                try
                {
                    string sql = $@"
                    UPDATE KhoanVay
                    SET TrangThai = N'Đã thanh toán'
                    WHERE MaVay = {maVayDangChon}
                    AND Username = '{Session.Username}'";

                    db.ExcuteNonQuery(sql);

                    MessageBox.Show
                    (
                        "Thanh toán thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadTatCaDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoahet_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show
            (
                "Bạn muốn xóa lịch sử thanh toán?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                try
                {
                    string sql = $@"
                    DELETE FROM KhoanVay
                    WHERE Username = '{Session.Username}'
                    AND TrangThai = N'Đã thanh toán'";

                    db.ExcuteNonQuery(sql);

                    MessageBox.Show
                    (
                        "Đã xóa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadTatCaDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThemKhoanVay_Click(object sender, EventArgs e)
        {
            frmThemKhoanVay frm =new frmThemKhoanVay();
            frm.ShowDialog();
            LoadTatCaDgv();
        }
        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayDetail(dgvThanhToan, e.RowIndex, "Đã thanh toán");
        }
    }
}
