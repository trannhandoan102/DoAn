using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace DoAn_One
{
    public partial class frmBaoCaoChuyenMon : Form
    {
        public frmBaoCaoChuyenMon()
        {
            InitializeComponent();
        }

        private void frmBaoCaoChuyenMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNSuDataSet1.View_ChuyenMon' table. You can move, or remove it, as needed.
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            this.View_ChuyenMonTableAdapter.Fill(this.QLNSuDataSet1.View_ChuyenMon);
            this.rpvChuyenMon.RefreshReport();
            /*XuLi con = new XuLi();
            String sql = "Select * from View_ChuyenMon";
            rpvChuyenMon.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpvChuyenMon.LocalReport.ReportPath = "ReportChuyenMon.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "View_ChuyenMon";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                rpvChuyenMon.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvChuyenMon.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvChuyenMon.RefreshReport();
        }*/
        }
    }
}
