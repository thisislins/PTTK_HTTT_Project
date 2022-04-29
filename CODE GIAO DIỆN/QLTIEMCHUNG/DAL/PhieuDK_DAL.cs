using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuDK_DAL
    {
        public List<PhieuDK> DocDSPDK() {
            return DBAccess.DocDSPDK_DTO();
        }

        public DataTable XemCTPDK(PhieuDK pdk) {
            return DBAccess.DocCTPDK_DTO(pdk);
        }
    }
}
