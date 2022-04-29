using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PhieuDat_DAL
    {
        public bool ThemPhieuDat(PhieuDK pdk,DataGridView view) {
            return DBAccess.ThemPhieuDat(pdk,view);
        }
        public DataTable DocDSPhieuDat() {
            return DBAccess.DocDSPhieuDat();
        }
        public bool DuyetPhieuDat(int pd) {
            return DBAccess.DuyetPhieuDat(pd);
        }
        public bool HuyPhieuDat(int pd) {
            return DBAccess.HuyPhieuDat(pd);
        }
        public DataTable XemCTPD(int pd) {
            return DBAccess.XemCTPD(pd);
        }
    }
}
