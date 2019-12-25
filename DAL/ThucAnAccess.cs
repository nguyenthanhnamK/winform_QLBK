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
    public class ThucAnAccess : DatabaseAccess
    {
        public List<ThucAn> LayToanBoThucAn()
        {

            List<ThucAn> dsFood = new List<ThucAn>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from ThucAn";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                
                int madm = reader.GetInt32(2);
                int gia = reader.GetInt32(3);

                ThucAn food = new ThucAn();
                food.FoodID = ma;
                food.TenThucAn = ten;
               
                food.DanhMucID = madm;
                 food.DonGia = gia;
                dsFood.Add(food);
            }
            reader.Close();
            return dsFood;
        }
        public List<ThucAn> LayToanBoThucAnTheoDanhMuc(int id)
        {

            List<ThucAn> dsFood = new List<ThucAn>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from ThucAn where DanhMucId = "+id;
            command.Connection = conn;
            
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);

                int madm = reader.GetInt32(2);
                int gia = reader.GetInt32(3);

                ThucAn food = new ThucAn();
                food.FoodID = ma;
                food.TenThucAn = ten;

                food.DanhMucID = madm;
                food.DonGia = gia;
                dsFood.Add(food);
            }
            reader.Close();
            return dsFood;
        }
        public bool CapNhatThucAn(string ten, int gia, int ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "Update ThucAn set Ten = N'" + ten + "', Gia =" + gia +" where foodid = "+ma;
            command.CommandText = sql;
            command.Connection = conn;

            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool ThemMoiThucAn(string ten, int gia, int madm)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "insert into ThucAn(Ten, gia, Danhmucid) values (N'" + ten + "', "+gia+ ", "+madm+ ")";
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool XoaThucAn(int ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "delete from ThucAn where FoodId = " + ma;
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
    }
}
