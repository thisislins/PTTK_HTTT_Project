using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DSPhieuDK
    {
        List<PhieuDK> dsPhieuDK;

        public DSPhieuDK(List<PhieuDK> ds) {
            this.dsPhieuDK = ds;
        }
        public List<PhieuDK> DS_PDK {
            set { dsPhieuDK = value; }
            get { return dsPhieuDK; }
        }
    }
}
