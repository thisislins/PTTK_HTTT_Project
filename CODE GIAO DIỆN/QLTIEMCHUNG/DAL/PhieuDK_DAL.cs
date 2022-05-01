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
            List<PhieuDK> dsPDK = new List<PhieuDK>();
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "SELECT * FROM PHIEU_DANG_KY";
            SqlCommand cmd = new SqlCommand(strSQL, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dsPDK.Add(new PhieuDK(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetString(3),
                    reader.GetDecimal(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8)));
            }
            conn.Close();
            return dsPDK;
        }

        public DataTable XemCTPDK(PhieuDK pdk) {
            int maPDK = pdk.MaPDK;
            string strSQL = "SELECT * FROM CT_DANG_KY WHERE MAPDK = " + maPDK;
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool TaoPhieuDK(PhieuDK pdk)
        {
            string strSQL = "INSERT INTO PHIEU_DANG_KY (NGAYTIEM,TRANGTHAI,LOAI,TONGTIEN,TRANGTHAITT,SODOTTT,MAKH,MANV) VALUES ('" + pdk.NgayTiem + "'," + pdk.TrangThai + ",'" + pdk.Loai + "'," +
                pdk.TongTien + "," + pdk.TrangThaiTT + "," +
                pdk.SoDTT + "," + pdk.MaKH + "," + pdk.MaNV + ");" + "SELECT CAST(scope_identity() AS int)";
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                int id = (Int32)cmd.ExecuteScalar();
                foreach (CTDangKY item in pdk.DSCT_DangKy)
                {
                    strSQL = "INSERT INTO CT_DANG_KY VALUES(" + id + "," + item.MaVC + "," + item.SoLuong +
                        "," + item.DonGia + "," + item.ThanhTien + ")";
                    cmd = new SqlCommand(strSQL, conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
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
