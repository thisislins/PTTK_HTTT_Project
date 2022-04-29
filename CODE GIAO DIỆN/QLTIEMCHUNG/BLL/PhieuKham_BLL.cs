using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuKham_BLL
    {
        public static DataTable LayDSPhieuKham()
        {
            return PhieuKham_DAL.LayDSPhieuKham();
        }
        public static DataTable LayDSBacSi()
        {
            return PhieuKham_DAL.LayDSBacSi();
        }
        public static DataTable LayDSKhachHang()
        {
            return PhieuKham_DAL.LayDSKhachHang();
        }
        public static void ThemPhieuKham(PhieuKham pk)
        {
            PhieuKham_DAL.ThemPhieuKham(pk);
        }

        public static void XoaPhieuKham(PhieuKham pk)
        {
            PhieuKham_DAL.XoaPhieuKham(pk);
        }

        public static void SuaPhieuKham(PhieuKham pk)
        {
            PhieuKham_DAL.SuaPhieuKham(pk);
        }

    }
}
