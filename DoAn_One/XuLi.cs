using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn_One
{
    class XuLi
    {
        public SqlConnection con = new SqlConnection();
        string ChuoiKetNoi = "Data Source=DESKTOP-NHBTHUK\\SQLEXPRESS;Initial Catalog=QLNSu;Integrated Security=True";
        public bool KetNoi()
        {
            try
            {
                con = new SqlConnection(ChuoiKetNoi);
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public void DongKetNoi()
        {
            con.Close();
        }
        public DataTable layDuLieu(string sql)
        {
            XuLi cn = new XuLi();
            cn.KetNoi();
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter dta = new SqlDataAdapter(sql, cn.con);
                dta.Fill(ds, sql);
                DataTable tbl = ds.Tables[0];
                return tbl;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void TacDong(string x)
        {
            XuLi cn = new XuLi();
            try
            {
                cn.KetNoi();
                SqlCommand cmd = new SqlCommand(x, cn.con);
                cmd.ExecuteNonQuery();
                cn.DongKetNoi();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
