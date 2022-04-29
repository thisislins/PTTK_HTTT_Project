using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTDangKY
    {
        int maPDK;
        int maVC;
        int soLuong;
        int donGia;
        decimal thanhTien;

        public CTDangKY(int maDK, int vac, int sl, int dg, decimal tt){
            this.maPDK = maDK;
            this.maVC = vac;
            this.soLuong = sl;
            this.donGia = dg;
            this.thanhTien = tt;
        }
    }
}
