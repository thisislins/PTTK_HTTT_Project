using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DSPhieuDat
    {
        List<PhieuDat> dsPhieuDat;

        public DSPhieuDat(List<PhieuDat> ds)
        {
            this.dsPhieuDat = ds;
        }
        public List<PhieuDat> DS_PD
        {
            set { dsPhieuDat = value; }
            get { return dsPhieuDat; }
        }
    }
}
