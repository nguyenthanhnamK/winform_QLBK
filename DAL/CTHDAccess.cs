using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class CTHDAccess : DatabaseAccess
    {
        public List<CTHD> LayToanBoCTHDTheoHoaDon(int id)
        {
            List<CTHD> dscthd = new List<CTHD>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from CTHD where BillId = " + id;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int mahd = reader.GetInt32(0);
                int foodid = reader.GetInt32(1);
                int sl = reader.GetInt32(2);
              
                CTHD cthd = new CTHD();
                cthd.BillId = mahd;
                cthd.FoodId = foodid;
                cthd.SoLuong = sl;
               
                dscthd.Add(cthd);
            }
            reader.Close();
            return dscthd;
        }
        public void InsertCTHD(int idbill, int idfood, int soluong)
        {

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "USP_InsertBillInfo "+idbill+", "+idfood+", "+soluong+"";
            command.Connection = conn;
            command.ExecuteNonQuery();

        }
        
    }
}
