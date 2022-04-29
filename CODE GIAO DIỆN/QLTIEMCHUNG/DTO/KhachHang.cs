using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class KhachHang
    {
        public int MAKH;
        public string HOTEN;
        public DateTime NGAYSINH;
        public string DIACHI;
        public string SDT;
        public string CMND;
        public string LOAIKH;
        public int MANGH;

        public KhachHang(int mAKH, string hOTEN, DateTime nGAYSINH, string dIACHI, string sDT, string cMND, string lOAIKH, int mANGH)
        {
            MAKH = mAKH;
            HOTEN = hOTEN;
            NGAYSINH = nGAYSINH;
            DIACHI = dIACHI;
            SDT = sDT;
            CMND = cMND;
            LOAIKH = lOAIKH;
            MANGH = mANGH;
        }
    }
}
 