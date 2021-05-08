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
using System.Data.SqlClient;

namespace DoAn_One
{
    public partial class frmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NHBTHUK\\SQLEXPRESS;Initial Catalog=QLNSu;Integrated Security=True");
        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát?", "Chú ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
                Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dta = new SqlDataAdapter("Select *from NguoiDung where TenDangNhap= '" + txtTaiKhoan.Text + "' and MatKhau='" + txtPassCu.Text + "'",con);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            erpDoiMK.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtPassNew.Text == txtNhapLaiPass.Text)
                {
                    SqlDataAdapter dta1 = new SqlDataAdapter("update NguoiDung set MatKhau='" + txtTaiKhoan.Text + "' where TenDangNhap='" + txtTaiKhoan.Text + "' and MatKhau='" + txtPassCu.Text + "'", con);
                    DataTable dt1 = new DataTable();
                    dta1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    erpDoiMK.SetError(txtPassNew, "Bạn chưa điền mật khẩu !");
                    erpDoiMK.SetError(txtNhapLaiPass, "Nhập lại mật khẩu chauw đúng !");
                }
            }
            else
            {
                erpDoiMK.SetError(txtTaiKhoan, "Tên người dùng không đúng !");
                erpDoiMK.SetError(txtPassCu, "Mật khẩu cũ không đúng !");
            }
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
        }

        private void txtPassCu_Click(object sender, EventArgs e)
        {
            txtPassCu.Clear();
        }

        private void txtPassNew_Click(object sender, EventArgs e)
        {
            txtPassNew.Clear();
        }

        private void txtNhapLaiPass_Click(object sender, EventArgs e)
        {
            txtNhapLaiPass.Clear();
        }
    }
}