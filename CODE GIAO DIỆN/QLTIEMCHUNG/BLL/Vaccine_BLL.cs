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
    public class Vaccine_BLL
    {
        Vaccine_DAL vac_DAL = new Vaccine_DAL();
        List<Vaccine> dsTam = new List<Vaccine>();
        public DataTable DocDSVaccine() {
            return vac_DAL.DocDSVaccine();
        }
        public void ThemVaoDSTam(Vaccine vac) {
            dsTam.Add(vac);
        }
    }
}
