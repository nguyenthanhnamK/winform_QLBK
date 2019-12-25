using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class DanhMucAccess : DatabaseAccess
    {
        public List<DanhMuc> LayToanBoDanhMuc()
        {
            List<DanhMuc> dsDM = new List<DanhMuc>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from DanhMuc";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);

                
                DanhMuc danhMuc = new DanhMuc();
                danhMuc.DanhMucID = ma;
                danhMuc.TenDanhMuc = ten;
                
                dsDM.Add(danhMuc);
            }
            reader.Close();
            return dsDM;
        }
        public bool CapNhatDanhMuc(string ten, int ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "Update DanhMuc set TenDanhMuc = N'" + ten + "'  where DanhMucId = " + ma+" ";
            command.CommandText = sql;
            command.Connection = conn;

            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool ThemMoiDanhMuc(string ten)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "insert into DanhMuc(TenDanhMuc) values (N'" + ten + "') ";
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool XoaDanhMuc(int ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "delete from DanhMuc where DanhMucId = " + ma;
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
    }
}
