using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class TableAccess : DatabaseAccess
    {

        public List<Table> LayToanBoBan()
        {

            List<Table> dsBan = new List<Table>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Ban";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                int tenban = reader.GetInt32(1);

                string trangThai = reader.GetString(2);


                Table ban = new Table();
                ban.TableId = ma;
                ban.TenBan = tenban;

                ban.TrangThai = trangThai;

                dsBan.Add(ban);
            }
            reader.Close();
            return dsBan;
        }
        public bool CapNhatBan(int ma, int ten, string trangthai)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "Update Ban set TenBan = " + ten + ", trangthai = N'" + trangthai + "' where TableId = " + ma;
            command.CommandText = sql;
            command.Connection = conn;

            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool ThemMoiBan(string ten, string trangthai)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "insert into Ban(TenBan, trangthai) values ('" + ten + "', N'" + trangthai + "')";
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool XoaBan(int ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "delete from Ban where TableId = " + ma;
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
    }
}
