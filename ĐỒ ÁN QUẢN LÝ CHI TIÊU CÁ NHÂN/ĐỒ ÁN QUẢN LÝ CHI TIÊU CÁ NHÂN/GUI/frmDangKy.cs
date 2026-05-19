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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDangNhapTab_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" ||
                txtPass.Text == "" ||
                txtEmail.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");

                return;
            }
            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");

                return;
            }
            Database db = new Database();
            string sql = @"INSERT INTO TaiKhoan
                           (
                               Username,
                               MatKhau,
                               Email
                           )
                           VALUES
                           (
                               N'" + txtUser.Text + @"',
                               N'" + txtPass.Text + @"',
                               N'" + txtEmail.Text + @"'
                           )";
            db.ExcuteNonQuery(sql);
            MessageBox.Show("Đăng ký thành công");
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Close();
        }

        private void btnDangKyTab_Click(object sender, EventArgs e)
        {

        }
    }
}
