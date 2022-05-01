using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuDK_BLL
    {
        PhieuDK_DAL pdk_DAL = new PhieuDK_DAL();
        DSPhieuDK ds_PDK;

        public DSPhieuDK DocDSPDK() {
            ds_PDK = new DSPhieuDK(pdk_DAL.DocDSPDK());
            return ds_PDK;
        }

        public DataTable XemCTPDK(PhieuDK pdk) {
            return pdk_DAL.XemCTPDK(pdk);
        }

        public PhieuDK XemTT(int maPDK)
        {
            foreach(PhieuDK item in ds_PDK.DS_PDK) {
                if (item.MaPDK == maPDK) {
                    return item;
                }
            }
            return null;
        }

        public bool TaoPhieuDK(PhieuDK pdk)
        {
            return pdk_DAL.TaoPhieuDK(pdk);
        }

        public static decimal LayTongTien(int MaPDK)
        {
            return PhieuDK_DAL.LayTongTien(MaPDK);
        }

        public static int LaySoDotTT(int MaPDK)
        {
            return PhieuDK_DAL.LaySoDotTT(MaPDK);
        }

        public static string LayTTTT(int MaPDK)
        {
            return PhieuDK_DAL.LayTTTT(MaPDK);
        }

        public static decimal LayTongTienDTT(int MaPDK)
        {
            return PhieuDK_DAL.LayTongTienDTT(MaPDK);
        }

        public static int LayMaKH(int MaPDK)
        {
            return PhieuDK_DAL.LayMaKH(MaPDK);
        }
    }
}
