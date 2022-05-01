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
    public class PhieuDat_DAL
    {
        public bool ThemPhieuDat(PhieuDK pdk,DataGridView view) {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "INSERT INTO PHIEU_DAT_MUA (THANHTIEN, MANV, MAPDK, TRANGTHAI) VALUES(" + pdk.TongTien + "," + pdk.MaNV + "," + pdk.MaPDK + ",N'Chờ duyệt');"
                + "SELECT CAST(scope_identity() AS int)";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            try
            {
                int maPD = 0;
                maPD = (Int32)cmd.ExecuteScalar();
                for (int i = 0; i < view.RowCount - 1; i++)
                {

                    strSQL = "INSERT INTO CHI_TIET_PHIEU_DAT (MAPD ,MAVC, SLDAT, DONGIA, THANHTIEN) VALUES(" + maPD + "," + view.Rows[i].Cells[1].Value + "," + view.Rows[i].Cells[2].Value
                        + "," + view.Rows[i].Cells[3].Value + "," + view.Rows[i].Cells[4].Value + ");";
                    cmd = new SqlCommand(strSQL, conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public DataTable DocDSPhieuDat() {
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
        public bool DuyetPhieuDat(int pd) {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "UPDATE PHIEU_DAT_MUA SET TRANGTHAI = N'Duyệt' WHERE MAPD = " + pd;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            try
            {
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public bool HuyPhieuDat(int pd) {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "UPDATE PHIEU_DAT_MUA SET TRANGTHAI = N'Hủy' WHERE MAPD = " + pd;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            try
            {
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public DataTable XemCTPD(int pd) {
            SqlConnection conn = DBAccess.Connect();
            conn.Open();
            string strSQL = "SELECT * FROM CHI_TIET_PHIEU_DAT WHERE MAPD = " + pd;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Close();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
