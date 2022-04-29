using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class PhieuDat_BLL
    {
        PhieuDat_DAL phieuDat_DAL = new PhieuDat_DAL();
        DSPhieuDat dsPhietDat;
        public string ThemPhieuDat(PhieuDK pdk, DataGridView view) {
            if (pdk != null)
            {
                try {
                    if (phieuDat_DAL.ThemPhieuDat(pdk,view))
                    {
                        return "Thêm thành công!";
                    }
                }
                catch {
                    return "Thêm thất bại!";
                }
            }
            return "Thêm thất bại!";
        }

        public DataTable DocDSPhieuDat() {
            return phieuDat_DAL.DocDSPhieuDat();
        }

        public void DuyetPD(int pd) {
            phieuDat_DAL.DuyetPhieuDat(pd);
        }

        public void HuyPD(int pd) {
            phieuDat_DAL.HuyPhieuDat(pd);
        }

        public DataTable XemCTPD(int pd) {
            return phieuDat_DAL.XemCTPD(pd);
        }
    }
}
