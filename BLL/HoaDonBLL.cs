using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonAccess hd = new HoaDonAccess();
        public int KiemTraBan(int id)
        {
            
            return hd.KiemTraBan(id);
        }
        public List<HoaDon> LayToanBoHD()
        {

            return hd.LayToanHD();
        }
        public bool InsertBill(int id,int nvid)
        {
           
            return hd.InsertBill(id, nvid);
        }
       
        public bool ThanhToan(int id)
        {
           
            return hd.ThanhToan(id);
        }
        public int getMaxId()
        {
            
            return hd.GetMaxIDBill();
        }
    }
}
