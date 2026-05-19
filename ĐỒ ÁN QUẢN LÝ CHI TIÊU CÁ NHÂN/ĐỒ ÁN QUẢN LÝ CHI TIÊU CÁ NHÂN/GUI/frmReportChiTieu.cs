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
    public partial class frmReportChiTieu : Form
    {
        Database db = new Database();
        public frmReportChiTieu()
        {
            InitializeComponent();
        }
        private void frmReportChiTieu_Load(object sender, EventArgs e)
        {

            string sql = @"SELECT TenChiTieu, SoTien, Ngay
                           FROM ChiTieu
                           WHERE Username = '" + Session.Username + @"'
                           ORDER BY Ngay DESC";
            DataTable dt = db.Excute(sql);
            reportViewer1.LocalReport.ReportPath =@"../../rptChiTieu.rdlc";
            ReportDataSource rds =new ReportDataSource("dsChiTieu", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
