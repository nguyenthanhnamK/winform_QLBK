using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class DanhMucBLL
    {
        DanhMucAccess dmAccsess = new DanhMucAccess();
        public List<DanhMuc> LayToanBoDanhMuc()
        {
            
            return dmAccsess.LayToanBoDanhMuc();
        }
        public bool CapNhatDanhMuc(string ten, int ma)
        {

            return dmAccsess.CapNhatDanhMuc(ten, ma);
        }
        public bool ThemMoiDanhMuc(string ten)
        {

            return dmAccsess.ThemMoiDanhMuc(ten);
        }
        public bool XoaDanhMuc(int ma)
        {

            return dmAccsess.XoaDanhMuc(ma);
        }
    }
}
