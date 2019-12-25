using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class CTHDBLL
    {
        CTHDAccess cthd = new CTHDAccess();
        public List<CTHD> LayToanCTHD(int id)
        {
           
            return cthd.LayToanBoCTHDTheoHoaDon(id);
        }
        public void InsertCthd(int idBill, int idFood, int soluong)
        {
           
            cthd.InsertCTHD(idBill, idFood, soluong);
        }
        
    }
}
