using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int NhanVienId { get; set; }
        public string HoTen { get; set; }
        public string Ngaysinh { get; set; }
        public int? GioiTinh { get; set; }
    }
}

