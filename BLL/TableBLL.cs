using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class TableBLL
    {

        TableAccess banaccess = new TableAccess();
        public List<Table> LayToanBoBan()
        {
            
            return banaccess.LayToanBoBan();
        }
        public bool CapNhatBan(int ma, int ten, string trangthai)
        {

            return banaccess.CapNhatBan(ma, ten, trangthai);
        }
        public bool ThemBan(string ten, string trangthai)
        {

            return banaccess.ThemMoiBan(ten, trangthai);
        }
        public bool XoaBan(int ma)
        {

            return banaccess.XoaBan(ma);
        }

    }
}
