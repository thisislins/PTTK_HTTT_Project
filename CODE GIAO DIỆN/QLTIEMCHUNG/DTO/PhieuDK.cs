using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDK
    {
        List<CTDangKY> DSCT_PDK = new List<CTDangKY>();
        string loai;
        int maKH;
        int maNV;
        int maPDK;
        DateTime ngayTiem;
        decimal tongTien;
        string trangThai;
        string trangThaiTT;
        int soDTT;
        int tongSL;
        public PhieuDK(int MaPDK)
        {
            this.loai = null;
            this.maKH = 0;
            this.maNV = 0;
            this.maPDK = MaPDK;
            this.ngayTiem = DateTime.Parse("01/01/2000");
            this.tongTien = 0;
            this.trangThai = null;
            this.trangThaiTT = null;
        }
        public PhieuDK(int MaPDK,decimal TT) {
            this.loai = null;
            this.maKH = 0;
            this.maNV = 0;
            this.maPDK = MaPDK;
            this.ngayTiem = DateTime.Parse("01/01/2000");
            this.tongTien = TT;
            this.trangThai = null;
            this.trangThaiTT = null;
        }
        public PhieuDK(int MaPDK, DateTime NgayTiem, string TrangThai, string Loai,
            decimal TongTien, string TrangThaiTT, int DTT, int MaKH, int MaNV
             )
        {
            this.loai = Loai;
            this.maKH = MaKH;
            this.maNV = MaNV;
            this.maPDK = MaPDK;
            this.soDTT = DTT;
            this.ngayTiem = NgayTiem;
            this.tongTien = TongTien;
            this.trangThai = TrangThai;
            this.trangThaiTT = TrangThaiTT;
        }

        public PhieuDK(DateTime NgayTiem, string TrangThai, string Loai,
decimal TongTien, string TrangThaiTT, int DTT, int MaKH, int MaNV
)
        {
            this.loai = Loai;
            this.maKH = MaKH;
            this.maNV = MaNV;
            this.maPDK = MaPDK;
            this.soDTT = DTT;
            this.ngayTiem = NgayTiem;
            this.tongTien = TongTien;
            this.trangThai = TrangThai;
            this.trangThaiTT = TrangThaiTT;
        }

        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public int SoDTT
        {
            get { return soDTT; }
            set { soDTT = value; }
        }

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public int MaPDK
        {
            get { return maPDK; }
            set { maPDK = value; }
        }

        public DateTime NgayTiem
        {
            get { return ngayTiem; }
            set { ngayTiem = value; }
        }

        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public string TrangThaiTT
        {
            get { return trangThaiTT; }
            set { trangThaiTT = value; }
        }

        public List<CTDangKY> DSCT_DangKy
        {
            get { return DSCT_PDK; }
            set { DSCT_PDK = value; }
        }
    }
}
