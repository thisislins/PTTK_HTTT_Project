using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDat
    {
        int maPD;
        int tongSLDat;
        decimal thanhTien;
        int maNV;
        int maPDK;
        string trangThai;
        public PhieuDat(int pd, int slDat, decimal tTien, int nv, int pdk, string trThai)
        {
            this.maPD = pd;
            this.tongSLDat = slDat;
            this.thanhTien = tTien;
            this.maNV = nv;
            this.maPDK = pdk;
            this.trangThai = trThai;
        }

        public int MaPD
        {
            get { return maPD; }
            set { maPD = value; }
        }

        public int MaPDK
        {
            get { return maPDK; }
            set { maPDK = value; }
        }

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public int TongSLDat
        {
            get { return tongSLDat; }
            set { tongSLDat = value; }
        }

        public decimal ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
