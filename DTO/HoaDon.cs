using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int BillId { get; set; }
        public int TableId { get; set; }
        public DateTime NgayVao { get; set; }
        public int TrangThai { get; set; }
        public int? NhanVienId { get; set; }
    }
}
