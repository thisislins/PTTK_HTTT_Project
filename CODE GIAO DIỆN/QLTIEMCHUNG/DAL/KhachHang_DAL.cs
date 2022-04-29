using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhachHang_DAL
    {
        public List<KhachHang> DocDSKhachHang(List<KhachHang> ds) {
            return DBAccess.DocDSKhachHang(ds);
        }
    }
}
