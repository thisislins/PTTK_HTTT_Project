using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class HoaDon_BLL
    {
        public static DataTable HienThiDSHoaDon()
        {
            return HoaDon_DAL.HienThiDSHoaDon();
        }

        public static DataTable LayDSMaHD()
        {
            return HoaDon_DAL.LayDSMaHD();
        }

        public static DataTable LayMaPDK()
        {
            return HoaDon_DAL.LayMaPDK();
        }

        public static DataTable LayMaKH()
        {
            return HoaDon_DAL.LayMaKH();
        }

        public static DataTable LayMaNVTN()
        {
            return HoaDon_DAL.LayMaNVTN();
        }

        public static DataTable LayDSCTPDK(int MaPDK)
        {
            return HoaDon_DAL.LayDSCTPDK(MaPDK);
        }

        public static void CapNhatHD(HoaDon hd)
        {
            HoaDon_DAL.CapNhatHD(hd);
        }

        public static void XoaHoaDon(int MaHD)
        {
            HoaDon_DAL.XoaHoaDon(MaHD);
        }

        public static HoaDon LayThongTinHD(int MaHD)
        {
            return HoaDon_DAL.LayThongTinHD(MaHD);
        }

        public static void TaoMoiHoaDon(HoaDon hd)
        {
            HoaDon_DAL.TaoMoiHoaDon(hd);
        }
    }
}
