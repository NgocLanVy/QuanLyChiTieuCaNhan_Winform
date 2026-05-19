using ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.StartPosition =FormStartPosition.CenterScreen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string sql = @"SELECT COUNT(*)
                   FROM TaiKhoan
                   WHERE Username = N'" + txtUser.Text + @"'
                   AND MatKhau = N'" + txtPass.Text + @"'";
            int kq = (int)db.ExecuteScalar(sql);
            if (kq > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                Session.Username = txtUser.Text;
                this.Hide();
                frmMain f = new frmMain();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy f = new frmDangKy();
            f.ShowDialog();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
