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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát?", "Chú ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
                Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //XuLi con = new XuLi();
            //con.KetNoi();
            //DataTable dt = new DataTable();
            //dt = con.layDuLieu("select *from NguoiDung where TenDangNhap= '" + txtuser.Text + "' and MatKhau='" + txtpass.Text + "'");
            //if (dt.Rows.Count > 0)
            //{
            //    string x = dt.Rows[0][3].ToString();
            //    if (x == "True")
            //    {
            //        frmMain.quyen = "Admin";
            //        x = "Admin";
            //        MessageBox.Show("Đăng nhập thành công!!!(Quyền" + x + ")");
            //    }
            //    else
            //        if (x == "False")
            //    {
            //        x = "User";
            //        frmMain.quyen = "User";
            //        MessageBox.Show("Đăng nhập thành công!!!(Quyền" + x + ")");
            //    }
            //    Close();
            //    frmMain f = new frmMain();
            //    f.ShowDialog();

            //}
            //else
            //    MessageBox.Show("Đăng nhập thất bại!!!");
            XuLi con = new XuLi();
            con.KetNoi();
            DataTable dt = new DataTable();
            string xx = txtUser.Text;
            string y = txtPass.Text;
            dt = con.layDuLieu("select *from NguoiDung where TenDangNhap= '" + xx + "' and MatKhau='" + y + "'");
            if (dt.Rows.Count > 0)
            {
                string x = dt.Rows[0][3].ToString();
                if (x == "True")
                {
                    frmMain.quyen = "Admin";
                    x = "Admin";
                    MessageBox.Show("Đăng nhập thành công!!!(Quyền" + x + ")");
                }
                else
                    if (x == "False")
                {
                    x = "User";
                    frmMain.quyen = "User";
                    MessageBox.Show("Đăng nhập thành công!!!(Quyền" + x + ")");
                }
                Close();
                frmMain f = new frmMain();
                f.ShowDialog();

            }
            else
                MessageBox.Show("Đăng nhập thất bại!!!");
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
 }