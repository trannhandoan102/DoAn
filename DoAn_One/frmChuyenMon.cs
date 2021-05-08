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
    public partial class frmChuyenMon : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenMon()
        {
            InitializeComponent();
        }
        public string hanhDong = "";
        private void taiDuLieu()
        {
            XuLi cn = new XuLi();
            string sql = "Select * from ChuyenMon";
            dgvChuyenMon.DataSource = cn.layDuLieu(sql);
        }
        private void frmChuyenMon_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hanhDong = "them";
            txtMaCM.Text = "";
            txtTenCM.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string x = txtMaCM.Text;
            string y = txtTenCM.Text;
            string sql1 = "INSERT INTO ChuyenMon(MaChuyenMon,TenChuyenMon)" +
                "values('" + x + "','" + y + "')";

            if (hanhDong == "them")
            {
                cn.TacDong(sql1);
            }
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void dgvChuyenMon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaCM.Text = dgvChuyenMon.CurrentRow.Cells[0].Value.ToString();
                txtTenCM.Text = dgvChuyenMon.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            XuLi cn = new XuLi();
            string sql2 = "update ChuyenMon set TenChuyenMon='" + txtTenCM.Text + "' where MaChuyenMon='" + txtMaCM.Text + "'";
            cn.TacDong(sql2);
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql = "Delete from ChuyenMon where MaChuyenMon='" + txtMaCM.Text + "'";
            cn.TacDong(sql);
            taiDuLieu();
        }
    }
}