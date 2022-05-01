using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DBAccess
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=KAYDEE;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";
            //string strcon = @"Data Source=LIN-LIN\SQLEXPRESS;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";
            //string strcon = @"Data Source=LAPTOP-KTF30DB7\SQLEXPRESS;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";
            //string strcon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect
            return conn;
        }
    }
}
