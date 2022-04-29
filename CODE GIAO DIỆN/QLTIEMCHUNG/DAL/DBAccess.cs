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
            //string strcon = @"Data Source=KAYDEE;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";
            string strcon = @"Data Source=LIN-LIN\SQLEXPRESS;Initial Catalog=QLTIEMCHUNG;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect
            return conn;
        }

        public static List<PhieuDK> DocDSPDK_DTO()
        {
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

        public static DataTable DocCTPDK_DTO(PhieuDK pdk){
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

        public static bool ThemPhieuDat(PhieuDK pdk,DataGridView view) {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "INSERT INTO PHIEU_DAT_MUA (THANHTIEN, MANV, MAPDK, TRANGTHAI) VALUES(" + pdk.TongTien + "," + pdk.MaNV + "," + pdk.MaPDK + ",N'Chờ duyệt');"
                + "SELECT CAST(scope_identity() AS int)";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            try
            {
                int maPD=0;
                maPD = (Int32)cmd.ExecuteScalar();
                for (int i = 0; i < view.RowCount-1; i++)
                {

                    strSQL = "INSERT INTO CHI_TIET_PHIEU_DAT (MAPD ,MAVC, SLDAT, DONGIA, THANHTIEN) VALUES("+maPD+","+view.Rows[i].Cells[1].Value+","+view.Rows[i].Cells[2].Value
                        +","+view.Rows[i].Cells[3].Value+"," + view.Rows[i].Cells[4].Value + ");";
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

        public static DataTable DocDSPhieuDat() {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "SELECT * FROM PHIEU_DAT_MUA";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static bool DuyetPhieuDat(int maPD)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "UPDATE PHIEU_DAT_MUA SET TRANGTHAI = N'Duyệt' WHERE MAPD = "+maPD;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool HuyPhieuDat(int maPD)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "UPDATE PHIEU_DAT_MUA SET TRANGTHAI = N'Hủy' WHERE MAPD = " + maPD;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static DataTable XemCTPD(int maPD) {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "SELECT * FROM CHI_TIET_PHIEU_DAT WHERE MAPD = "+maPD;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static List<KhachHang> DocDSKhachHang(List<KhachHang> ds) {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "SELECT * FROM KHACH_HANG";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                ds.Add(new KhachHang(reader.GetInt32(0),reader.GetString(1),
                    reader.GetDateTime(2),reader.GetString(3),reader.GetString(4),
                    reader.GetString(5),reader.GetString(6),reader.GetString(7),reader.GetInt32(8)));
            }
            return ds;
        }

        public static DataTable DocDSVaccine() {
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
