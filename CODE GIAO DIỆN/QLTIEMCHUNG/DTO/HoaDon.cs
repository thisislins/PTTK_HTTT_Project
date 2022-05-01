using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int _MaHD;
        public DateTime _NgayLap;
        public string _NoiDung;
        public decimal _TongTienThanhToan;
        public int _MaPDK;
        public int _MaNV;
        public int _MaKH;
        public string _PTTT;
        public string _HTTT;

        public HoaDon()
        {
            this._MaHD = 0;
            this._NgayLap = DateTime.Parse("01/01/2000");
            this._NoiDung = "";
            this._TongTienThanhToan = 0;
            this._MaPDK = 0;
            this._MaNV = 0;
            this._MaKH = 0;
            this._PTTT = "";
            this._HTTT = "";
        }
        public HoaDon(int MaHD, DateTime NgayLap, string NoiDung, decimal TongTienThanhToan, int MaPDK,
            int MaNV, int MaKH, string PTTT, string HTTT)
        {
            this._MaHD = MaHD;
            this._NgayLap = NgayLap;
            this._NoiDung = NoiDung;
            this._TongTienThanhToan = TongTienThanhToan;
            this._MaPDK = MaPDK;
            this._MaNV = MaNV;
            this._MaKH = MaKH;
            this._PTTT = PTTT;
            this._HTTT = HTTT;
        }

        public int MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }

        public decimal TongTienThanhToan
        {
            get { return _TongTienThanhToan; }
            set { _TongTienThanhToan = value; }
        }

        public int MaPDK
        {
            get { return _MaPDK; }
            set { _MaPDK = value; }
        }

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        public string PTTT
        {
            get { return _PTTT; }
            set { _PTTT = value; }
        }

        public string HTTT
        {
            get { return _HTTT; }
            set { _HTTT = value; }
        }

    }
}
