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
    }
}
