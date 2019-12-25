using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public bool LayTaiKhoan(string username, string pass)
        {
            
            return tkAccess.LayTaiKhoan(username, pass);
        }
        public List<TaiKhoan> LayTaiKhoanTheoUserName(string username)
        {
            return tkAccess.LayTaiKhoanTheoUserName(username);
        }
        public List<ThongTinTK> LayToanBoTaiKhoan()
        {
            return tkAccess.LayToanBoTaiKhoan();
        }
        public bool CapNhatTk(string user, string pass)
        {

            return tkAccess.CapNhatTk(user, pass);
        }
        public bool ThemMoiTk(string user, string pass, int nvid, int type)
        {

            return tkAccess.ThemMoiTk(user, pass, nvid, type);
        }
        public bool XoaTk(string user)
        {

            return tkAccess.XoaTk(user);
        }
    }
}
