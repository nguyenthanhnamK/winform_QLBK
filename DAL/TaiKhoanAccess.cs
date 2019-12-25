using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class TaiKhoanAccess : DatabaseAccess
    {
        public bool LayTaiKhoan(string username, string password)
        {
            
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "USP_Login '"+username+"', '"+password+"'";
           
            command.Connection = conn;
            
            int kq = (int)command.ExecuteScalar();
            if(kq ==1)
                return true;
            else
                return false;

        }
        public List<TaiKhoan> LayTaiKhoanTheoUserName(string username)
        {
            OpenConnection();
            List<TaiKhoan> dsTK = new List<TaiKhoan>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from TaiKhoan where username = '" + username+"'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                username = reader.GetString(0);
                string password = reader.GetString(1);

                int nvid = reader.GetInt32(2);
                int type = reader.GetInt32(3);

                TaiKhoan nv = new TaiKhoan();
                nv.UserName = username;
                nv.Password = password;

                nv.NhanVienId = nvid;
                nv.Type = type;
                dsTK.Add(nv);
            }
            reader.Close();
            return dsTK;
        }
        public List<ThongTinTK> LayToanBoTaiKhoan()
        {
            OpenConnection();
            List<ThongTinTK> dsTK = new List<ThongTinTK>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select username, password, nv.Hoten, type  from TaiKhoan tk, NhanVien nv where tk.NhanVienId = nv.NhanVienId";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(0);
                string password = reader.GetString(1);

                string ten = reader.GetString(2);
                int type = reader.GetInt32(3);

                ThongTinTK nv = new ThongTinTK();
                nv.UserName = username;
                nv.Password = password;

                nv.HoTen = ten;
                nv.Type = type;
                dsTK.Add(nv);
            }
            reader.Close();
            return dsTK;
        }
        public bool CapNhatTk(string user, string pass)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "Update TaiKhoan set  password = '" + pass + "' where username = '" + user + "'";
            command.CommandText = sql;
            command.Connection = conn;

            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool ThemMoiTk(string user, string pass, int nvid, int type)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "insert into TaiKhoan values ('" + user + "', '" + pass + "', " + nvid + ", " + type + " )";
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool XoaTk(string user)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "delete from TaiKhoan where Username = '" + user+"' and  type = 0";
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
    }
}
