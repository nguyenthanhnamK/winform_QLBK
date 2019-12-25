using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAccess nv = new NhanVienAccess();
        public List<NhanVien> LayToanNhanVien()
        {
            
            return nv.LayToanNV();
        }
        
        public bool CapNhatNhanVien(int ma, string ten, string ngaysinh, int gt)
        {
           
            return nv.CapNhatNhanVien(ma, ten, ngaysinh, gt);
        }
        public bool ThemNhanVien(string ten, string ngaysinh, int gt)
        {
           
            return nv.ThemMoiNhanVien(ten, ngaysinh, gt);
        }
        public bool XoaNhanVien(int ma)
        {
            
            return nv.XoaNhanVien(ma);
        }
        public List<NhanVien> HienThiChiTiet(int ma)
        {
           
            return nv.HienThiChiTiet(ma);
        }
    }

}
