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
    public partial class frmTinhThanh : DevExpress.XtraEditors.XtraForm
    {
        public frmTinhThanh()
        {
            InitializeComponent();
        }
        public string hanhDong = "";
        private void taiDuLieu()
        {
            XuLi cn = new XuLi();
            string sql = "Select * from TinhThanh";
            dgvTH.DataSource = cn.layDuLieu(sql);
        }
        private void frmTinhThanh_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hanhDong = "them";
            txtMaTinhThanh.Text = "";
            txtTenTinhThanh.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string x = txtMaTinhThanh.Text;
            string y = txtTenTinhThanh.Text;
            string sql1 = "INSERT INTO TinhThanh(MaTinhThanh,TenTinhThanh)" +
                "values('" + x + "','" + y + "')";
            if (hanhDong == "them")
            {
                cn.TacDong(sql1);
            }
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void dgvTH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaTinhThanh.Text = dgvTH.CurrentRow.Cells[0].Value.ToString();
                txtTenTinhThanh.Text = dgvTH.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql2 = "update TinhThanh set TenTinhThanh='" + txtTenTinhThanh.Text + "' where MaTinhThanh='" + txtMaTinhThanh.Text + "'";
            cn.TacDong(sql2);
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql = "Delete from TinhThanh where MaTinhThanh='" + txtMaTinhThanh.Text + "'";
            cn.TacDong(sql);
            taiDuLieu();
        }
    }
}