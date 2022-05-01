using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static decimal LayTongTien(int MaPDK)
        {
            SqlConnection conn = DBAccess.Connect();
            decimal tongtien = 0;

            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT TONGTIEN FROM PHIEU_DANG_KY WHERE MAPDK = " + MaPDK;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        rd.Read(); // read first row
                        tongtien = rd.GetDecimal(0);
                    }

                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tongtien;
        }

        public static int LaySoDotTT(int MaPDK)
        {
            SqlConnection conn = DBAccess.Connect();
            int SoDotTT = 0;

            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) AS SODOTTT FROM HOA_DON WHERE MAPDK = " + MaPDK;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        rd.Read(); // read first row
                        SoDotTT = rd.GetInt32(0);
                    }

                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return SoDotTT;
        }

        public static string LayTTTT(int MaPDK)
        {
            SqlConnection conn = DBAccess.Connect();
            string TrangThai = "";

            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT TRANGTHAITT FROM PHIEU_DANG_KY WHERE MAPDK = " + MaPDK;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        rd.Read(); // read first row
                        TrangThai = rd.GetString(0);
                    }

                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return TrangThai;
        }

        public static decimal LayTongTienDTT(int MaPDK)
        {
            SqlConnection conn = DBAccess.Connect();
            decimal tongtiendtt = 0;

            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT SUM(TONGTIENTHANHTOAN) AS TONGTIEN FROM HOA_DON WHERE MAPDK = " + MaPDK;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        rd.Read(); // read first row
                        tongtiendtt = rd.GetDecimal(0);
                    }

                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tongtiendtt;
        }

        public static int LayMaKH(int MaPDK)
        {
            SqlConnection conn = DBAccess.Connect();
            int MaKH = 0;

            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT MAKH FROM PHIEU_DANG_KY WHERE MAPDK = " + MaPDK;
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        rd.Read(); // read first row
                        MaKH = rd.GetInt32(0);
                    }

                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return MaKH;
        }
    }
}
