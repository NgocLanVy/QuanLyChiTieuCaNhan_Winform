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
    public partial class frmNguoiDung : Form
    {
        Database db = new Database();
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void btnThemThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThemThuNhap f = new frmThemThuNhap();
            f.ShowDialog();
            this.Show();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadThongTin();

            LoadViTien();

            LoadThuChi();
        }
        void LoadThongTin()
        {
            string sql = @"SELECT *
                   FROM TaiKhoan
                   WHERE Username = N'"
                           + Session.Username + @"'";

            DataTable dt = db.Excute(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];

                lblHoTen.Text =
                    "Họ tên : " +
                    r["HoTen"].ToString();

                lblUsername.Text =
                    "Username : " +
                    r["Username"].ToString();

                lblEmail.Text =
                    "Email : " +
                    r["Email"].ToString();

                lblRole.Text =
                    "Vai trò : " +
                    r["Role"].ToString();

                txtHoTen.Text =
                    r["HoTen"].ToString();
                txtEmail.Text =
                    r["Email"].ToString();

                if (r["HoTen"].ToString() == "")
                    lblHoTen.Visible = false;

                if (r["Username"].ToString() == "")
                    lblUsername.Visible = false;

                if (r["Email"].ToString() == "")
                    lblEmail.Visible = false;

                if (r["Role"].ToString() == "")
                    lblRole.Visible = false;
            }
        }

        void LoadViTien()
        {
            string sql = @"SELECT
                           TenVi,
                           SoDu
                           FROM ViTien
                           WHERE Username = N'"
                           + Session.Username + @"'";

            dgvViTien.DataSource = db.Excute(sql);

            dgvViTien.Columns[0].HeaderText = "Tên ví";

            dgvViTien.Columns[1].HeaderText = "Số dư";
            dgvViTien.Columns[1].DefaultCellStyle.Format = "N0";
            dgvViTien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvViTien.RowHeadersVisible = false;

            dgvViTien.BorderStyle = BorderStyle.None;

            dgvViTien.RowTemplate.Height = 35;

            dgvViTien.BackgroundColor = Color.White;
        }

        void LoadThuChi()
        {
            string sqlThu =
                @"SELECT ISNULL(SUM(SoTien),0)
                  FROM ThuNhap
                  WHERE Username = N'"
                  + Session.Username + @"'";

            decimal tongThu =
                Convert.ToDecimal(
                    db.ExecuteScalar(sqlThu));

            string sqlChi =
                @"SELECT ISNULL(SUM(SoTien),0)
                  FROM ChiTieu
                  WHERE Username = N'"
                  + Session.Username + @"'";

            decimal tongChi =
                Convert.ToDecimal(
                    db.ExecuteScalar(sqlChi));

            lblTongThu.Text =
                "Thu nhập : " +
                tongThu.ToString("N0") +
                " VNĐ";

            lblTongChi.Text =
                "Chi tiêu : " +
                tongChi.ToString("N0") +
                " VNĐ";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn đăng xuất?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                frmDangNhap fDangNhap = new frmDangNhap();
                fDangNhap.Show();

                Form mainForm = Application.OpenForms["frmMain"];
                if (mainForm != null)
                    mainForm.Close();
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult r =MessageBox.Show("Bạn chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                string sql1 =@"DELETE FROM ThuNhapWHERE Username = N'"+ Session.Username + @"'";
                db.ExcuteNonQuery(sql1);
                string sql2 =@"DELETE FROM ChiTieuWHERE Username = N'"
                      + Session.Username + @"'";

                db.ExcuteNonQuery(sql2);

                string sql3 =
                    @"DELETE FROM ViTien
              WHERE Username = N'"
                      + Session.Username + @"'";

                db.ExcuteNonQuery(sql3);

                string sql4 =
                    @"DELETE FROM TaiKhoan
              WHERE Username = N'"
                      + Session.Username + @"'";

                db.ExcuteNonQuery(sql4);

                MessageBox.Show("Đã xóa tài khoản");

                Application.Exit();
            }
        }


        private void btnThemChi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThemChi f = new frmThemChi();
            f.ShowDialog();
            this.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE TaiKhoan
                   SET
                   HoTen = N'" + txtHoTen.Text + @"',

                   Email = N'" + txtEmail.Text + @"'

                   WHERE Username = N'"
                  + Session.Username + @"'";

            db.ExcuteNonQuery(sql);

            MessageBox.Show("Cập nhật thành công");

            LoadThongTin();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMK f = new frmDoiMK();
            f.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == "" && txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần cập nhật!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = @"UPDATE TaiKhoan
                   SET
                   HoTen = N'" + txtHoTen.Text.Trim() + @"',
                   Email = N'" + txtEmail.Text.Trim() + @"'
                   WHERE Username = N'" + Session.Username + @"'";
            db.ExcuteNonQuery(sql);
            MessageBox.Show("Cập nhật thông tin thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadThongTin();
        }
    }
}
