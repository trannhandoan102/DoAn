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
    public partial class frmKhoiPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoiPhongBan()
        {
            InitializeComponent();
        }
        public string hanhDong = "";
        private void taiDuLieu()
        {
            XuLi cn = new XuLi();
            string sql = "Select * from KhoiPhongBan";
            dgvKPB.DataSource = cn.layDuLieu(sql);
        }
        private void frmKhoiPhongBan_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hanhDong = "them";
            txtMaKPB.Text = "";
            txtTenKPB.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string x = txtMaKPB.Text;
            string y = txtTenKPB.Text;
            string sql1 = "INSERT INTO KhoiPhongBan(MaKPB,TenKhoiPhongBan)" +
                "values('" + x + "','" + y + "')";

            if (hanhDong == "them")
            {
                cn.TacDong(sql1);
            }
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void dgvKPB_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaKPB.Text = dgvKPB.CurrentRow.Cells[0].Value.ToString();
                txtTenKPB.Text = dgvKPB.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql2 = "update KhoiPhongBan set TenKhoiPhongBan='" + txtTenKPB.Text + "' where MaKPB='" + txtMaKPB.Text + "'";
            cn.TacDong(sql2);
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql = "Delete from KhoiPhongBan where MaKPB='" + txtMaKPB.Text + "'";
            cn.TacDong(sql);
            taiDuLieu();
        }
    }
}