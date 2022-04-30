using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SoTiemChung
    {
        int MAVC;
        DateTime NGAYTIEM;
        string PHANUNG;
        int MAKH;

        public int mAVC
        {
            get { return MAVC; }
            set { MAVC = value; }
        }

        public int mAKH
        {
            get { return MAKH; }
            set { MAKH = value; }
        }

        public string pHANUNG
        {
            get { return PHANUNG; }
            set { PHANUNG = value; }
        }

        public DateTime nGAYTIEM
        {
            get { return NGAYTIEM; }
            set { NGAYTIEM = value; }
        }

        public SoTiemChung(int mAVC, int mAKH, DateTime nGAYTIEM, string pHANUNG)
        {
            this.MAVC = mAVC;
            this.MAKH = mAKH;
            this.NGAYTIEM = nGAYTIEM;
            this.PHANUNG = pHANUNG;
        }
    }
}
