using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhachHang_DAL
    {
        public List<KhachHang> DocDSKhachHang(List<KhachHang> ds) {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "SELECT * FROM KHACH_HANG";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ds.Add(new KhachHang(reader.GetInt32(0), reader.GetString(1),
                    reader.GetDateTime(2), reader.GetString(3), reader.GetString(4),
                    reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8)));
            }
            return ds;
        }
    }
}
