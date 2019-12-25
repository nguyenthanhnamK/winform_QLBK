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
    public class MenuAccess : DatabaseAccess
    {
        public List<Menu1> LayMenuTheoBan(int id)
        {
            List<Menu1> menu = new List<Menu1>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string query = "select  t.Ten, c.Soluong, t.Gia, t.Gia*c.SoLuong as totalPrice from ThucAn t, HoaDon h, cthd c where t.Foodid = c.Foodid and h.Billid = c.Billid and h.TrangThai = 0 and h.Tableid = " + id;
            command.CommandText = query;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string ten = reader.GetString(0);
                int sl = reader.GetInt32(1);
                int gia = reader.GetInt32(2);
                int thanhtien = reader.GetInt32(3);

                Menu1 mn = new Menu1();
                mn.TenThucAn = ten;
                mn.SoLuong = sl;
                mn.Gia = gia;
                mn.ThanhTien = thanhtien;

                menu.Add(mn);
            }
            reader.Close();
            return menu;
        }
        
    }
}
