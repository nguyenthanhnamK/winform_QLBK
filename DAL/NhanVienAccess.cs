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
    public class NhanVienAccess :DatabaseAccess
    {
        public List<NhanVien> LayToanNV()
        {

            List<NhanVien> dsNv = new List<NhanVien>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select NhanVienId, HoTen, Convert(varchar(10),NgaySinh, 103), GioiTinh from NhanVien";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);

                string ngaysinh = reader.GetString(2);
                int gioitinh = reader.GetInt32(3);

                NhanVien nv = new NhanVien();
                nv.NhanVienId = ma;
                nv.HoTen = ten;

                nv.Ngaysinh = ngaysinh;
                nv.GioiTinh = gioitinh;
                dsNv.Add(nv);
            }
            reader.Close();
            return dsNv;
        }
      
        public bool CapNhatNhanVien(int ma, string ten, string ngaysinh, int gt)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "Update nhanvien set hoten = N'"+ten+"', gioitinh ="+gt+" ,ngaysinh = '"+ngaysinh+"'  where nhanvienid ="+ma;
            command.CommandText = sql;
            command.Connection = conn;
            
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool ThemMoiNhanVien(string ten, string ngaysinh, int gt)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "insert into NhanVien values (N'"+ten+"', '"+ngaysinh+"', "+gt+" )";
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public bool XoaNhanVien(int ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "delete from Nhanvien where Nhanvienid = " + ma;
            command.CommandText = sql;
            command.Connection = conn;
            int kq = command.ExecuteNonQuery();
            if (kq > 0)
                return true;
            return false;
        }
        public List<NhanVien> HienThiChiTiet(int ma)
        {
            List<NhanVien> dsNv = new List<NhanVien>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from KhachHang where ma = "+ma;
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetInt32(0);
                string ten = reader.GetString(1);

                string ngaysinh = reader.GetString(2);
                int gioitinh = reader.GetInt32(3);

                NhanVien nv = new NhanVien();
                nv.NhanVienId = ma;
                nv.HoTen = ten;

                nv.Ngaysinh = ngaysinh;
                nv.GioiTinh = gioitinh;
                dsNv.Add(nv);
            }
            reader.Close();
            return dsNv;
        }
    }
}
