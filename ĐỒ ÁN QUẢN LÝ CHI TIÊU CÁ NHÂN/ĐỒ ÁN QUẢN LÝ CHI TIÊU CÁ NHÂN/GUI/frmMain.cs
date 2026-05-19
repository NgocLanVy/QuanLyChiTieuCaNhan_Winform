using ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.DTO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmMain : Form
    {
        Database db = new Database();

        public frmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Activate();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Session.Username;

            pnlSoLuoc.Visible = true;
            pnlTaiKhoan.Visible = true;
            pnlThuNhap.Visible = true;
            pnlChiTieu.Visible = true;

            LoadThuNhap();
            LoadChiTieu();
            LoadThongKe();
            LoadViTien();
            LoadChart();
            LoadKhoanVay();

            foreach (Control c in pnlMenu.Controls)
            {
                if (c is Button btn)
                {
                    btn.MouseEnter += Menu_MouseEnter;
                    btn.MouseLeave += Menu_MouseLeave;
                }
            }

            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.RowTemplate.Height = 35;
            dgvTaiKhoan.BorderStyle = BorderStyle.None;
            dgvTaiKhoan.BackgroundColor = Color.White;
            dgvTaiKhoan.RowHeadersVisible = false;

            dgvTaiKhoan.Columns[0].HeaderText = "Mã Ví";
            dgvTaiKhoan.Columns[1].HeaderText = "Tên Ví";
            dgvTaiKhoan.Columns[2].HeaderText = "Số Dư";

            dgvThuNhap.RowHeadersVisible = false;

            dgvChiTieu.RowHeadersVisible = false;

            dgvKhoanVay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoanVay.RowTemplate.Height = 35;
            dgvKhoanVay.BorderStyle = BorderStyle.None;
            dgvKhoanVay.BackgroundColor = Color.White;
            dgvKhoanVay.RowHeadersVisible = false;

            dgvKhoanVay.Columns[0].HeaderText = "Khoản Vay";
            dgvKhoanVay.Columns[1].HeaderText = "Số Tiền";
            dgvKhoanVay.Columns[2].HeaderText = "Hạn Trả";
            dgvKhoanVay.Columns[3].HeaderText = "Trạng Thái";
        }

        void RemoveChildForm()
        {
            Form oldForm = null;

            foreach (Control c in pnlContent.Controls)
            {
                if (c is Form)
                {
                    oldForm = (Form)c;
                    break;
                }
            }

            if (oldForm != null)
            {
                pnlContent.Controls.Remove(oldForm);
                oldForm.Dispose();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            pnlSoLuoc.Visible = false;
            pnlTaiKhoan.Visible = false;
            pnlThuNhap.Visible = false;
            pnlChiTieu.Visible = false;
            pnlKhoanNo.Visible = false;

            RemoveChildForm();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);

            childForm.Show();
        }
        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            RemoveChildForm();

            pnlSoLuoc.Visible = true;
            pnlTaiKhoan.Visible = true;
            pnlThuNhap.Visible = true;
            pnlChiTieu.Visible = true;
            pnlKhoanNo.Visible = true;

            LoadThuNhap();
            LoadChiTieu();
            LoadThongKe();
            LoadViTien();
            LoadChart();
            LoadKhoanVay();
        }
        void LoadThuNhap()
        {
            dgvThuNhap.DataSource = db.Excute(
                $@"SELECT
                    TenThuNhap,
                    SoTien,
                    Ngay
                FROM ThuNhap
                WHERE Username = N'{Session.Username}'");

            dgvThuNhap.Columns["SoTien"].DefaultCellStyle.Format = "N0";
        }
        void LoadChiTieu()
        {
            dgvChiTieu.DataSource = db.Excute(
                $@"SELECT
                    TenChiTieu,
                    SoTien,
                    Ngay
                FROM ChiTieu
                WHERE Username = N'{Session.Username}'");

            dgvChiTieu.Columns["SoTien"].DefaultCellStyle.Format = "N0";
        }
        void LoadViTien()
        {
            dgvTaiKhoan.DataSource = db.Excute(
                $@"SELECT
                    MaVi,
                    TenVi,
                    SoDu
                FROM ViTien
                WHERE Username = N'{Session.Username}'");

            dgvTaiKhoan.Columns["SoDu"].DefaultCellStyle.Format = "N0";
        }

        void LoadKhoanVay()
        {
            dgvKhoanVay.DataSource = db.Excute(
                $@"SELECT
                    TenKhoanVay,
                    SoTienVay,
                    HanTra,
                    TrangThai
                FROM KhoanVay
                WHERE Username = N'{Session.Username}'
                ORDER BY HanTra ASC");

            dgvKhoanVay.Columns["SoTienVay"].DefaultCellStyle.Format = "N0";
        }
        void LoadThongKe()
        {
            decimal tongThu = Convert.ToDecimal(db.ExecuteScalar(
                $@"SELECT ISNULL(SUM(SoTien),0)
                FROM ThuNhap
                WHERE Username = N'{Session.Username}'"));

            decimal tongChi = Convert.ToDecimal(db.ExecuteScalar(
                $@"SELECT ISNULL(SUM(SoTien),0)
                FROM ChiTieu
                WHERE Username = N'{Session.Username}'"));
            lblThuNhap.Text ="Thu nhập : " + tongThu.ToString("N0") + " VNĐ";
            lblChiTieu.Text ="Chi tiêu : " + tongChi.ToString("N0") + " VNĐ";
            lblTongCong.Text ="Tổng cộng : " + (tongThu - tongChi).ToString("N0") + " VNĐ";
        }
        void LoadChart()
        {
            decimal tongThu = Convert.ToDecimal(db.ExecuteScalar(
                $@"SELECT ISNULL(SUM(SoTien),0)
                FROM ThuNhap
                WHERE Username = N'{Session.Username}'"));
            decimal tongChi = Convert.ToDecimal(
                db.ExecuteScalar(
                $@"SELECT ISNULL(SUM(SoTien),0)
                FROM ChiTieu
                WHERE Username = N'{Session.Username}'"));

            chartTron.Series.Clear();
            Series s = new Series("ThongKe");
            s.ChartType = SeriesChartType.Doughnut;
            s.Points.AddXY("Thu", tongThu);
            s.Points.AddXY("Chi", tongChi);
            s.IsValueShownAsLabel = true;
            chartTron.Series.Add(s);
            chartTron.Legends[0].Enabled = false;
        }
        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.FromArgb(35, 35, 35);
            btn.Padding = new Padding(30, 0, 0, 0);
            btn.ForeColor = Color.DeepSkyBlue;
        }
        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(17, 17, 17);
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.ForeColor = Color.White;
        }
        private void btnThuNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThuNhap());
        }

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChiTieu());
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNguoiDung());
        }

        private void btnKhoanVay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhoanVay());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTaiKhoan());
        }

        private void btnTietKiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTietKiem());
        }

        private void btnNhacNho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhacNho());
        }
        private void btnThemThu_Click(object sender, EventArgs e)
        {
            frmThemThuNhap f = new frmThemThuNhap();

            f.ShowDialog();

            LoadThuNhap();
            LoadThongKe();
            LoadViTien();
            LoadChart();
            LoadKhoanVay();
        }
        private void btnThemChi_Click(object sender, EventArgs e)
        {
            frmThemChi f = new frmThemChi();
            f.ShowDialog();
            LoadChiTieu();
            LoadThongKe();
            LoadViTien();
            LoadChart();
            LoadKhoanVay();
        }

        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}