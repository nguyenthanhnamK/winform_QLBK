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
    public class HoaDonAccess : DatabaseAccess
    {
        public List<HoaDon> LayToanHD()
        {

            List<HoaDon> dsNv = new List<HoaDon>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from HoaDon";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                int tableid = reader.GetInt32(1);

                DateTime ngayvao = reader.GetDateTime(2);
                int gioitinh = reader.GetInt32(3);

                
                int trangthai = reader.GetInt32(3);
                int nvid = reader.GetInt32(3);
                HoaDon hd = new HoaDon();
                hd.BillId = ma;
                hd.TableId = tableid;

                hd.NgayVao = ngayvao;
                hd.TrangThai = trangthai;
                hd.NhanVienId = nvid;
                dsNv.Add(hd);
            }
            reader.Close();
            return dsNv;
        }
        public int KiemTraBan(int id)
        {
            List<HoaDon> dshd = new List<HoaDon>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from HoaDon where tableid = "+id+" and TrangThai = 0";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int mahd = reader.GetInt32(0);
                int tableid = reader.GetInt32(1);
                DateTime ngayvao = reader.GetDateTime(2);
                int trangthai = reader.GetInt32(3);
                int nvid = reader.GetInt32(4);


                HoaDon hd = new HoaDon();
                hd.BillId = mahd;
                hd.TableId = tableid;
                hd.NgayVao = ngayvao;
                hd.TrangThai = trangthai;
                hd.NhanVienId = nvid;

                dshd.Add(hd);
            }
            reader.Close();
            int sl = dshd.Where(p=>p.TableId==id).Count();

            if (sl == 0)
                return -1;
            else
            {
                int hd1 = dshd.Max(p => p.BillId);
                return hd1;
            }
            
        }
        public bool InsertBill(int id, int nvid)
        {
           
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert HoaDon(TableId,NgayVao, TrangThai, NhanVienId) values(" +id+", getdate(), 0, "+nvid+")";
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
            
        }
       
        public bool ThanhToan(int id)
        {
            string query = "Update HoaDon set TrangThai = 1 where BillId = " + id;
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public int GetMaxIDBill()
        {
            try
            {
                string query = "select Max(BillId) from HoaDon";
               
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                int kq = (int)command.ExecuteScalar();
                
                
                return kq;
            }
            catch
            {
                return 1;
            }
        }
    }
}
