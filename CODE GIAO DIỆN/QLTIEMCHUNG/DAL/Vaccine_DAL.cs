using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Vaccine_DAL
    {
        public DataTable DocDSVaccine() {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "SELECT * FROM VACCINE";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
