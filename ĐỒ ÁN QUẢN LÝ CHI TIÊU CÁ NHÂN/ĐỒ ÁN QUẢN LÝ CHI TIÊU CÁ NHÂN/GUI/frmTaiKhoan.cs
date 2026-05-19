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
    public partial class frmTaiKhoan : Form
    {
        Database db = new Database();
        int maViDangChon = -1;
        public frmTaiKhoan()
        {
            InitializeComponent();
            this.Load += frmTaiKhoan_Load;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.RowTemplate.Height = 35;
            dgvTaiKhoan.BorderStyle = BorderStyle.None;
            dgvTaiKhoan.BackgroundColor = Color.White;
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.RowHeadersVisible = false;

            dgvTaiKhoan.SelectionChanged += dgvTaiKhoan_SelectionChanged;

            txtMaVi.ReadOnly = true;
            txtMaVi.BackColor = Color.WhiteSmoke;

            LoadDanhSach();
        }
        void LoadDanhSach()
        {
            string sql = @"SELECT MaVi, TenVi, SoDu
                           FROM ViTien
                           WHERE Username = N'"
                           + Session.Username + @"'";

            DataTable dt = db.Excute(sql);

            dgvTaiKhoan.DataSource = dt;

            if (dgvTaiKhoan.Columns.Count >= 3)
            {
                dgvTaiKhoan.Columns[0].HeaderText = "Mã Ví";
                dgvTaiKhoan.Columns[1].HeaderText = "Tên Ví";
                dgvTaiKhoan.Columns[2].HeaderText = "Số Dư";
                dgvTaiKhoan.Columns[2].DefaultCellStyle.Format = "N0";
            }
            lblTongTK.Text = "Số lượng tài khoản là " + dt.Rows.Count;

            txtMaVi.Clear();
            txtTenVi.Clear();
            txtSoDu.Clear();
            maViDangChon = -1;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenVi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên ví!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal soDu = 0;
            if (txtSoDu.Text.Trim() != "")
            {
                string soDuStr = txtSoDu.Text.Replace(",", "").Trim();
                if (!decimal.TryParse(soDuStr, out soDu))
                {
                    MessageBox.Show("Số dư không hợp lệ!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string sql = @"INSERT INTO ViTien (TenVi, SoDu, Username)
                           VALUES (N'" + txtTenVi.Text.Trim() + @"', "
                           + soDu + @", N'"
                           + Session.Username + @"')";

            db.ExcuteNonQuery(sql);
            MessageBox.Show("Thêm ví thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maViDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn ví cần sửa!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTenVi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên ví!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal soDu = 0;
            if (txtSoDu.Text.Trim() != "")
            {
                string soDuStr = txtSoDu.Text.Replace(",", "").Trim();
                if (!decimal.TryParse(soDuStr, out soDu))
                {
                    MessageBox.Show("Số dư không hợp lệ!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            string sql = @"UPDATE ViTien
                           SET TenVi = N'" + txtTenVi.Text.Trim() + @"',
                               SoDu = " + soDu + @"
                           WHERE MaVi = " + maViDangChon;
            db.ExcuteNonQuery(sql);
            MessageBox.Show("Cập nhật ví thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maViDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn ví cần xóa!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn xóa ví này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                string sqlThu = @"UPDATE ThuNhap SET MaVi = NULL
                                  WHERE MaVi = " + maViDangChon;
                db.ExcuteNonQuery(sqlThu);
                string sqlChi = @"UPDATE ChiTieu SET MaVi = NULL
                                  WHERE MaVi = " + maViDangChon;
                db.ExcuteNonQuery(sqlChi);
                string sql = @"DELETE FROM ViTien
                               WHERE MaVi = " + maViDangChon;
                db.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa ví thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDanhSach(); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null) return;

            DataGridViewRow row = dgvTaiKhoan.CurrentRow;

            maViDangChon = Convert.ToInt32(row.Cells[0].Value);
            txtMaVi.Text = row.Cells[0].Value.ToString();
            txtTenVi.Text = row.Cells[1].Value.ToString();
            txtSoDu.Text = Convert.ToDecimal(row.Cells[2].Value).ToString("N0");
        }
    }
}
