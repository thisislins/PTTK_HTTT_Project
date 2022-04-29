using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHang_BLL
    {
        List<KhachHang> dsKH;
        KhachHang_DAL KH_DAL = new KhachHang_DAL();
        public List<int> DocDSMaKH() {
            List<int> dsMaKH = new List<int>();
            dsKH = KH_DAL.DocDSKhachHang(dsKH);
            foreach (KhachHang item in dsKH) {
                dsMaKH.Add(item.MaKH);
            }
            return dsMaKH;
        }

        public bool KiemTraMaKH(string input)
        {
            if (int.TryParse(input, out int ma)) {
                DocDSMaKH();
                foreach (KhachHang item in dsKH)
                {
                    if (item.MaKH == ma)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
