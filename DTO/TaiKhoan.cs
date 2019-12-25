using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int NhanVienId { get; set; }
        public int Type { get; set; }
    }
}
