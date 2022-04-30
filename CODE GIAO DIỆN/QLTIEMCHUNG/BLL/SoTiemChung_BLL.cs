using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class SoTiemChung_BLL
    {
        public static DataTable LayDSSoTiemChung()
        {
            return SoTiemChung_DAL.LayDSSoTiemChung();
        }
        public static DataTable LayDSKhachHang()
        {
            return SoTiemChung_DAL.LayDSKhachHang();
        }

        public static DataTable LayDSVaccine()
        {
            return SoTiemChung_DAL.LayDSVaccine();
        }

        public static DataTable LaySoTiemChung(int MAKH)
        {
            return SoTiemChung_DAL.LaySoTiemChung(MAKH);
        }

        public static SoTiemChung LaySoTiemChung(int MAVC, int MAKH, DateTime NGAYTIEM)
        {
            return SoTiemChung_DAL.LaySoTiemChung(MAVC, MAKH, NGAYTIEM);
        }

        public static KhachHang LayTTKhachHang(int MAKH)
        {
            return SoTiemChung_DAL.LayTTKhachHang(MAKH);
        }

        public static void ThemSoTiemChung(SoTiemChung stc)
        {
            SoTiemChung_DAL.ThemSoTiemChung(stc);
        }

        public static void XoaSoTiemChung(SoTiemChung stc)
        {
            SoTiemChung_DAL.XoaSoTiemChung(stc);
        }

        public static void SuaSoTiemChung(SoTiemChung stc)
        {
            SoTiemChung_DAL.SuaSoTiemChung(stc);
        }
    }
}
