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
   public class PhieuKhamBLL
    {
        public static DataTable LayDSPhieuKham()
        {
            return PhieuKhamDAL.LayDSPhieuKham();
        }
        public static DataTable LayDSBacSi()
        {
            return PhieuKhamDAL.LayDSBacSi();
        }
        public static DataTable LayDSKhachHang()
        {
            return PhieuKhamDAL.LayDSKhachHang();
        }
        public static void ThemPhieuKham(PhieuKham pk)
        {
            PhieuKhamDAL.ThemPhieuKham(pk);
        }

        public static void XoaPhieuKham(PhieuKham pk)
        {
            PhieuKhamDAL.XoaPhieuKham(pk);
        }

        public static void SuaPhieuKham(PhieuKham pk)
        {
            PhieuKhamDAL.SuaPhieuKham(pk);
        }

    }
}
