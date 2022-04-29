using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vaccine
    {
        int maVC;
        string tenVC;
        string loaiVC;
        string loSX;
        DateTime HSD;
        string moTa;
        int slTon;
        string xuatXu;
        string phanLoai;

        public Vaccine(int ma, string ten, string loai, string lo, DateTime hsd, string mota, int sl, string xx, string pl) {
            this.maVC = ma;
            this.tenVC = ten;
            this.loaiVC = loai;
            this.loSX = lo;
            this.HSD = hsd;
            this.moTa = mota;
            this.slTon = sl;
            this.xuatXu = xx;
            this.phanLoai = pl;
        }


    }
}
