using ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN.DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReportThuNhap : Form
    {
        Database db = new Database();
        public frmReportThuNhap()
        {
            InitializeComponent();
        }

        private void frmReportThuNhap_Load(object sender, EventArgs e)
        {
            string sql = $@"SELECT
                            TenThuNhap,
                            SoTien,
                            Ngay
                            FROM ThuNhap
                            WHERE Username = '{Session.Username}'
                            ORDER BY Ngay DESC";

            DataTable dt = db.Excute(sql);
            reportViewer1.LocalReport.ReportPath = @"../../rptThuNhap.rdlc";
            ReportDataSource rds = new ReportDataSource("dtThuNhap", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
