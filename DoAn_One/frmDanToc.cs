using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAn_One
{
    public partial class frmDanToc : DevExpress.XtraEditors.XtraForm
    {
        public frmDanToc()
        {
            InitializeComponent();
        }
        public string hanhDong = "";
        private void taiDuLieu()
        {
            XuLi cn = new XuLi();
            string sql = "Select * from DanToc";
            dgvDT.DataSource = cn.layDuLieu(sql);
        }
        private void frmDanToc_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hanhDong = "them";
            txtMaDT.Text = "";
            txtTenDT.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string x = txtMaDT.Text;
            string y = txtTenDT.Text;
            string sql1 = "INSERT INTO DanToc(MaDanToc,TenDanToc)" +
                "values('" + x + "','" + y + "')";
            if (hanhDong == "them")
            {
                cn.TacDong(sql1);
            }
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void dgvDT_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaDT.Text = dgvDT.CurrentRow.Cells[0].Value.ToString();
                txtTenDT.Text = dgvDT.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql2 = "update DanToc set TenDanToc='" + txtTenDT.Text + "' where MaDanToc='" + txtMaDT.Text + "'";
            cn.TacDong(sql2);
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql = "Delete from DanToc where MaDanToc='" + txtMaDT.Text + "'";
            cn.TacDong(sql);
            taiDuLieu();
        }
    }
}