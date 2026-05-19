using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒ_ÁN_QUẢN_LÝ_CHI_TIÊU_CÁ_NHÂN
{
    internal class Database
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;

        public Database()
        {
            string strConn =
                @"Data Source=.;
                  Initial Catalog=DB_QLyChiTieu;
                  Integrated Security=True";
            sqlConn = new SqlConnection(strConn);
        }

        // SELECT
        public DataTable Excute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        // INSERT UPDATE DELETE
        public void ExcuteNonQuery(string sqlStr)
        {
            try
            {
                sqlConn.Open();
                SqlCommand cmd =new SqlCommand(sqlStr, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // COUNT
        public object ExecuteScalar(string sqlStr)
        {
            object kq = 0;
            try
            {
                sqlConn.Open();
                SqlCommand cmd =new SqlCommand(sqlStr, sqlConn);
                kq = cmd.ExecuteScalar();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kq;
        }
    }
}