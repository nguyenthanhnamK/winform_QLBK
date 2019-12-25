using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class MenuBLL
    {
        MenuAccess menu = new MenuAccess();
        public List<Menu1> LayMenuTheoBan(int id)
        {
            
            return menu.LayMenuTheoBan(id);
        }
    }
}
