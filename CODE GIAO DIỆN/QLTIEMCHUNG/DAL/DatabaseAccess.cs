using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class Connect
    {
        
    }
    public class DatabaseAccess
    {
        public static SqlConnection ConnectDB()
        {
            string strconn = @"Data Source=LIN-LIN\SQLEXPRESS;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
    }
}
