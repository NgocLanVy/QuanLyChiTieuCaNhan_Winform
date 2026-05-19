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
    public partial class frmDoiMK : Form
    {
        Database db = new Database();
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string mkCu = txtMKCu.Text.Trim();
            string mkMoi = txtMKMoi.Text.Trim();
            string nhapLai = txtNhapLai.Text.Trim();

            if (mkCu == "" || mkMoi == "" || nhapLai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlKiem = @"SELECT COUNT(*) FROM TaiKhoan
                               WHERE Username = N'" + Session.Username + @"'
                               AND MatKhau = N'" + mkCu + @"'";

            int count = Convert.ToInt32(db.ExecuteScalar(sqlKiem));

            if (count == 0)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKCu.Clear();
                txtMKCu.Focus();
                return;
            }
            if (mkMoi != nhapLai)
            {
                MessageBox.Show("Mật khẩu mới không khớp!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMKMoi.Clear();
                txtNhapLai.Clear();
                txtMKMoi.Focus();
                return;
            }

            if (mkMoi == mkCu)
            {
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKMoi.Clear();
                txtNhapLai.Clear();
                txtMKMoi.Focus();
                return;
            }
            string sqlUpdate = @"UPDATE TaiKhoan
                                 SET MatKhau = N'" + mkMoi + @"'
                                 WHERE Username = N'" + Session.Username + @"'";

            db.ExcuteNonQuery(sqlUpdate);

            MessageBox.Show("Đổi mật khẩu thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
