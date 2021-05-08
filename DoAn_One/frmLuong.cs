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
    public partial class frmLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmLuong()
        {
            InitializeComponent();
        }
        public string hanhDong = "";
        private void taiDuLieu()
        {
            XuLi cn = new XuLi();
            string sql = "Select * from MucLuong";
            dgvLuong.DataSource = cn.layDuLieu(sql);
        }
        private void frmLuong_Load(object sender, EventArgs e)
        {
            taiDuLieu();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hanhDong = "them";
            txtMaML.Text = "";
            txtMucLuong.Text = "";
            cbMaPhuCap.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        public void read_MaPhuCap()
        {
            XuLi ctct = new XuLi();
            string sql3 = "SELECT MaPhuCap,TenPhuCap FROM PhuCap";
            cbMaPhuCap.DataSource = ctct.layDuLieu(sql3);
            cbMaPhuCap.DisplayMember = "TenPhuCap";
            cbMaPhuCap.ValueMember = "MaPhuCap";
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string x = txtMaML.Text;
            string y = txtMucLuong.Text;
            string n = cbMaPhuCap.SelectedValue.ToString();
            string sql1 = "INSERT INTO MucLuong(MaML,MucLuong,MaPhuCap)" +
                "values('" + x + "','" + y + "','"+n+"')";
            if (hanhDong == "them")
            {
                cn.TacDong(sql1);
            }
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvLuong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaML.Text = dgvLuong.CurrentRow.Cells[0].Value.ToString();
                txtMucLuong.Text = dgvLuong.CurrentRow.Cells[1].Value.ToString();
                cbMaPhuCap.Text = dgvLuong.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql2 = "update MucLuong set MucLuong='" + txtMucLuong.Text + "',PhuCap='" + cbMaPhuCap.SelectedValue.ToString() + "' where MaML='" + txtMaML.Text + "'";
            cn.TacDong(sql2);
            taiDuLieu();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XuLi cn = new XuLi();
            string sql = "Delete from MucLuong where MaML='" + txtMaML.Text + "'";
            cn.TacDong(sql);
            taiDuLieu();
        }
    }
}