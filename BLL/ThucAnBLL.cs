using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ThucAnBLL
    {
        ThucAnAccess foodAccsess = new ThucAnAccess();
        public List<ThucAn> LayToanBoThucAn()
        {
            
            return foodAccsess.LayToanBoThucAn();
        }
        public List<ThucAn> LayToanBoThucAnTheoDanhMuc(int id)
        {
            
            return foodAccsess.LayToanBoThucAnTheoDanhMuc(id);
        }
        public bool CapNhatThucAn(string ten, int gia, int ma)
        {

            return foodAccsess.CapNhatThucAn(ten, gia, ma);
        }
        public bool ThemMoiThucAn(string ten, int gia, int madm)
        {

            return foodAccsess.ThemMoiThucAn(ten, gia, madm);
        }
        public bool XoaThucAn(int ma)
        {

            return foodAccsess.XoaThucAn(ma);
        }
    }
}
