using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVien
    {
        public int MANV;
        public string HOTEN;
        public DateTime NGAYSINH;
        public string GIOITINH;
        public string CMND;
        public string SDT;
        public string DIACHI;
        public string TENLOAINV;

        public NhanVien(int mANV, string hOTEN, DateTime nGAYSINH, string gIOITINH, string cMND, string sDT, string dIACHI, string tENLOAINV)
        {
            MANV = mANV;
            HOTEN = hOTEN;
            NGAYSINH = nGAYSINH;
            GIOITINH = gIOITINH;
            CMND = cMND;
            SDT = sDT;
            DIACHI = dIACHI;
            TENLOAINV = tENLOAINV;
        }
    }
}
