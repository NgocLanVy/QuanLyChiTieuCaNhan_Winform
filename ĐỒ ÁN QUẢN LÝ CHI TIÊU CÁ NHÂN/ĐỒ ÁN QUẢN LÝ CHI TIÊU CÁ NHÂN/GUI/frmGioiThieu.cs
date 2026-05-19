using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.GUI
{
    public partial class frmGioiThieu : Form
    {
        private bool _chiXem = false;
        public frmGioiThieu()
        {
            InitializeComponent();
            _chiXem = false;
        }
        public frmGioiThieu(bool chiXem)
        {
            InitializeComponent();
            _chiXem = chiXem;
        }

        private void frmGioiThieu_Load(object sender, EventArgs e)
        {
            string bannerPath = Path.Combine(
                Application.StartupPath, "Resources", "banner.jpg");

            if (File.Exists(bannerPath))
                picBanner.Image = Image.FromFile(bannerPath);
           

            lblClick.BringToFront();
            if (_chiXem)
            {
                lblClick.Text = "🖱️  Nhấn vào để đóng";
                timerNhapNhay.Start();
            }
            else
            {
                lblClick.Text = "🖱️  Nhấn vào để tiếp tục...";
                timerNhapNhay.Start();
            }
        }

        private void picBanner_Click(object sender, EventArgs e)
        {
            MoFrmDangNhap();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if (_chiXem)
                {
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Application.Exit();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lblClick_Click(object sender, EventArgs e)
        {
            MoFrmDangNhap();
        }

        private void timerNhapNhay_Tick(object sender, EventArgs e)
        {
            lblClick.Visible = !lblClick.Visible;
        }
        private void MoFrmDangNhap()
        {
            if (_chiXem)
            {
                this.Close();
                return;
            }
            timerNhapNhay.Stop();

            frmDangNhap frmDN = new frmDangNhap();

            if (frmDN.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                timerNhapNhay.Start();
            }
        }
    }
}
