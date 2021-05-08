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
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        public string hanhDong = "";
        private void taiDuLieu()
        {
            XuLi cn = new XuLi();
            string sql = "Select * from ChucVu";
            dgvChucVu.DataSource = cn.layDuLieu(sql);
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hanhDong = "them";
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string x = txtMaChucVu.Text;
            string y = txtTenChucVu.Text;
            string sql1 = "INSERT INTO ChucVu(MaChucVu,TenChucVu)" +
                "values('" + x + "','" + y + "')";

            if (hanhDong == "them")
            {
                cn.TacDong(sql1);
            }
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void dgvChucVu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaChucVu.Text = dgvChucVu.CurrentRow.Cells[0].Value.ToString();
                txtTenChucVu.Text = dgvChucVu.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql2 = "update ChucVu set TenChucVu='" + txtTenChucVu.Text + "' where MaChucVu='" + txtMaChucVu.Text + "'";
            cn.TacDong(sql2);
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql = "Delete from ChucVu where MaChucVu='" + txtMaChucVu.Text + "'";
            cn.TacDong(sql);
            taiDuLieu();
        }
    }
}