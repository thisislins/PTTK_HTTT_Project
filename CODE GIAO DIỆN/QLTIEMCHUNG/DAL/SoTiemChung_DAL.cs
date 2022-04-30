using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class SoTiemChung_DAL
    {
        public static DataTable LayDSSoTiemChung()
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM SO_TIEM_CHUNG";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public static DataTable LayDSKhachHang()
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT MAKH FROM KHACH_HANG";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }
            
            return dt;
        }

        public static DataTable LayDSVaccine()
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT MAVC FROM VACCINE";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public static DataTable LaySoTiemChung(int makh)
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM SO_TIEM_CHUNG WHERE MAKH = " + makh;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);

                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public static SoTiemChung LaySoTiemChung(int mavc, int makh, DateTime ngaytiem)
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();

            conn.Open();
            string query = "SELECT * FROM SO_TIEM_CHUNG WHERE MAKH = " + makh + " AND MAVC = " + mavc + " AND NGAYTIEM = '" + ngaytiem.ToString("yyyy-MM-dd") + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            SoTiemChung stc;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    stc = new SoTiemChung(reader.GetInt32(1), reader.GetInt32(3), reader.GetDateTime(0), reader.GetString(2));
                    return stc;
                }
            }
            conn.Close();
            stc = new SoTiemChung(0,0, DateTime.Parse("01/01/2000"), "");
            return stc;
        }

        public static KhachHang LayTTKhachHang(int makh)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "SELECT HOTEN, DIACHI FROM KHACH_HANG WHERE MAKH = " + makh;
            SqlCommand cmd = new SqlCommand(strSQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            KhachHang ttKH;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ttKH = new KhachHang(makh, reader.GetString(0), reader.GetString(1));
                    return ttKH;
                }
            }
            conn.Close();
            ttKH = new KhachHang(makh, "", "");
            return ttKH;
        }

        public static void ThemSoTiemChung(SoTiemChung stc)
        {
            //pk.NGAYKHAM.ToString("yyyy-MM-dd")
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string query = "INSERT INTO SO_TIEM_CHUNG VALUES ('" + stc.nGAYTIEM + "', " + stc.mAVC + ", N'" + stc.pHANUNG + "', " + stc.mAKH + ")";
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void SuaSoTiemChung(SoTiemChung stc)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string query = "UPDATE SO_TIEM_CHUNG SET NGAYTIEM = '" + stc.nGAYTIEM + "', PHANUNG = N'" + stc.pHANUNG + "'  WHERE MAKH = " + stc.mAKH + " AND MAVC = " + stc.mAVC;
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void XoaSoTiemChung(SoTiemChung stc)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string query = "DELETE SO_TIEM_CHUNG WHERE NGAYTIEM = '" + stc.nGAYTIEM + "' AND MAVC = " + stc.mAVC + " AND MAKH = " + stc.mAKH;
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
