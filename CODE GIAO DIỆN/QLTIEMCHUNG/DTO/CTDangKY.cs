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
        decimal donGia;
        decimal thanhTien;

        public CTDangKY(int vac, int sl, int dg, decimal tt)
        {
            this.maVC = vac;
            this.soLuong = sl;
            this.donGia = dg;
            this.thanhTien = tt;
        }

        public int MaPDK
        {
            get { return maPDK; }
            set { maPDK = value; }
        }
        public int MaVC
        {
            get { return maVC; }
            set { maVC = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public decimal ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
