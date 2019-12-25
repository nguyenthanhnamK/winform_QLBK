using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    
    public class DatabaseAccess
    {
        string strConn = @"server = DESKTOP-VG2CT3T\SQLEXPRESS; database = CSDL_QuanLyBanKem; uid = nhatnam99; pwd = nhatnam00";
        protected SqlConnection conn = null;
        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
