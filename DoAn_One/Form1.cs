using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn_One
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        //public void skins()
        //{
        //    DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        //    themes.LookAndFeel.SkinName = "Valentine";
        //}
        public static string quyen = "";
        private void frmMain_Load(object sender, EventArgs e)
        {
            //skins();
            if (quyen!="")
            {
                rbQLDM.Visible = true;
                rbQLNS.Visible = true;
                rbBCTK.Visible = true;
                btnChangePass.Enabled = true;
                btnDangXuat.Enabled = true;
                btnDangNhap.Enabled = false;

                if (quyen == "Admin")
                {
                    btnQLTK.Enabled = true;
                    btnDangXuat.Enabled = true;
                    btnChangePass.Enabled = true;
                    btnBackUp.Enabled = true;

                }
            }
        }

        private void btnTinhThanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmTinhThanh();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }



        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmDanToc();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmChucVu();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKhoiPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmKhoiPhongBan();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnChuyenMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmChuyenMon();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnBaoCaoChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmBaoCaoChuyenMon();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMK dmk = new frmDoiMK();
            dmk.ShowDialog();
        }

        private void btnBackUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool IsActiv = false;
            var form = new frmBackUp();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmChamCong();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmNhanVien();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnQTCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmQTCT();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnQTDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmQTDT();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmPhongBan();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTrinhDoVH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmTDVH();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnNN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmNgoaiNgu();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnChungChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmChungChi();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDieuChuyenNB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmDieuChuyen();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnQuanHeThanNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmQHTN();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmHopDong();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnGiaHanHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool IsActiv = false;
            var form = new frmGiaHanHD();
            foreach (Form item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    IsActiv = true;
                }
            }
            if (!IsActiv)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn đăng xuất?", "Chú ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
                Close();
            frmDangNhap a = new frmDangNhap();
            a.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
    }
}
