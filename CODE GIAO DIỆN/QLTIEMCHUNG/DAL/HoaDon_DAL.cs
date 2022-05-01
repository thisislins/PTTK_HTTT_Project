using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class HoaDon_DAL
    {
        public static DataTable HienThiDSHoaDon()
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "SELECT * FROM HOA_DON";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable LayDSMaHD()
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "SELECT MAHD FROM HOA_DON";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable LayMaPDK()
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "SELECT MAPDK FROM PHIEU_DANG_KY";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable LayMaKH()
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "SELECT MAKH FROM KHACH_HANG";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable LayMaNVTN()
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "SELECT MANV FROM NHAN_VIEN WHERE TENLOAINV = N'THU NGÂN'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void CapNhatHD(HoaDon hd)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string query = "UPDATE HOA_DON SET MAKH = " + hd.MaKH.ToString() + ", MANV = " + hd.MaNV.ToString() + ", MAPDK = " + hd.MaPDK.ToString() + ", NGAYLAP = '"
                + hd.NgayLap.ToString() + "' ,NOIDUNG = N'" + hd.NoiDung + "' , TONGTIENTHANHTOAN = " + hd.TongTienThanhToan + ", PHUONGTHUCTT = N'" + hd.PTTT 
                + "', HINHTHUCTT = N'" + hd.HTTT + "' WHERE MAHD = " + hd.MaHD.ToString();
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void XoaHoaDon(int MaHD)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string query = "DELETE HOA_DON WHERE MAHD = " + MaHD;
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable LayDSCTPDK(int MaPDK)
        {
            SqlConnection conn = DBAccess.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "SELECT * FROM CT_DANG_KY WHERE MAPDK = " + MaPDK;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            conn.Close();
            return dt;
        }

        public static HoaDon LayThongTinHD(int MaHD)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string query = "SELECT * FROM HOA_DON WHERE MAHD = " + MaHD;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            HoaDon hd;

            reader.Read();
            hd = new HoaDon(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetDecimal(3),
                        reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetString(7), reader.GetString(8));

            conn.Close();

            return hd;
        }

        public static void TaoMoiHoaDon(HoaDon hd)
        {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string query = "INSERT HOA_DON(NGAYLAP, NOIDUNG, TONGTIENTHANHTOAN, MAPDK, MANV, MAKH, PHUONGTHUCTT, HINHTHUCTT) VALUES ('" +
                hd.NgayLap.ToString() + "', N'"+ hd.NoiDung.ToString() +"', "+ hd.TongTienThanhToan.ToString() +", "+ hd.MaPDK.ToString() +", "+ hd.MaNV.ToString()
                +", "+ hd.MaKH.ToString() +", N'"+ hd.PTTT.ToString() +"', N'"+ hd.HTTT.ToString() +"')";      
            Console.WriteLine(query);
            MessageBox.Show(query);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
