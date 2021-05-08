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
    public partial class frmPhuCap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhuCap()
        {
            InitializeComponent();
        }
        public string hanhDong = "";
        private void taiDuLieu()
        {
            XuLi cn = new XuLi();
            string sql = "Select * from PhuCap";
            dgvPhuCap.DataSource = cn.layDuLieu(sql);
        }
        private void frmPhuCap_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hanhDong = "them";
            txtMaPC.Text = "";
            txtTenPC.Text = "";
            txtMucPC.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string x = txtMaPC.Text;
            string y = txtTenPC.Text;
            string n = txtMucPC.Text;
            string sql1 = "INSERT INTO PhuCap(MaPhuCap,TenPhuCap,MucPhuCap)" +
                "values('" + x + "','" + y + "','" + n + "')";
            if (hanhDong == "them")
            {
                cn.TacDong(sql1);
            }
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void dgvPhuCap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaPC.Text = dgvPhuCap.CurrentRow.Cells[0].Value.ToString();
                txtTenPC.Text = dgvPhuCap.CurrentRow.Cells[1].Value.ToString();
                txtMucPC.Text = dgvPhuCap.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql2 = "update PhuCap set TenPhuCap='" + txtTenPC.Text + "',MucPhuCap='" + txtMucPC.Text + "' where MaPhuCap='" + txtMaPC.Text + "'";
            cn.TacDong(sql2);
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql = "Delete from PhuCap where MaPhuCap='" + txtMaPC.Text + "'";
            cn.TacDong(sql);
            taiDuLieu();
        }
    }
}