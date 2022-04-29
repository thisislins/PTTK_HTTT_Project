using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using DTO;
namespace DAL
{
    public class PhieuKhamDAL
    {
   
        public static DataTable LayDSPhieuKham()
        {
            SqlConnection conn = DatabaseAccess.ConnectDB();
            DataTable dt = new DataTable();
            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM PHIEU_KHAM";
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

        public static void ThemPhieuKham(PhieuKham pk)
        {
            //pk.NGAYKHAM.ToString("yyyy-MM-dd")
            SqlConnection conn = DatabaseAccess.ConnectDB();
            conn.Open();
            string query = "INSERT INTO PHIEU_KHAM VALUES (" + pk.MABS + ", " + pk.MAKH + ", '" + pk.NGAYKHAM + "', " + pk.NHIETDO + ", "
                + pk.NHIPTIM + ", " + pk.HUYETAP + ", N'" + pk.KETLUAN + "')";
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void SuaPhieuKham(PhieuKham pk)
        {
            SqlConnection conn = DatabaseAccess.ConnectDB();
            conn.Open();
            string query = "UPDATE PHIEU_KHAM SET MABS = " + pk.MABS + ", MAKH = " + pk.MAKH + ", NGAYKHAM = '" + pk.NGAYKHAM +"', NHIETDO = "
                + pk.NHIETDO + ", NHIPTIM = " + pk.NHIPTIM +", HUYETAP = " + pk.HUYETAP + ", KETLUAN = N'" + pk.KETLUAN+ "' WHERE MAPK = " + pk.MAPK;
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void XoaPhieuKham(PhieuKham pk)
        {
            SqlConnection conn = DatabaseAccess.ConnectDB();
            conn.Open();
            string query = "DELETE PHIEU_KHAM WHERE MAPK = " + pk.MAPK;
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable LayDSBacSi()
        {
            SqlConnection conn = DatabaseAccess.ConnectDB();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "SELECT MANV FROM NHAN_VIEN WHERE TENLOAINV = N'Bác sĩ'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable LayDSKhachHang()
        {
            SqlConnection conn = DatabaseAccess.ConnectDB();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "SELECT MAKH FROM KHACH_HANG";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
