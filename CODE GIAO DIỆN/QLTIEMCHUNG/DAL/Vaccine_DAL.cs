using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Vaccine_DAL
    {
        public DataTable DocDSVaccine() {
            return DBAccess.DocDSVaccine();
        }
    }
}
