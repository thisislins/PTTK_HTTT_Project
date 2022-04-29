using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Linq;

namespace DTO
{
    public class PhieuKham
    {
        public int MAPK;
        public int MABS;
        public int MAKH;
        public DateTime NGAYKHAM;
        public int NHIETDO;
        public int NHIPTIM;
        public int HUYETAP;
        public string KETLUAN;

        public PhieuKham(int mABS, int mAKH, DateTime nGAYKHAM, int nHIETDO, int nHIPTIM, int hUYETAP, string kETLUAN)
        {
            MABS = mABS;
            MAKH = mAKH;
            NGAYKHAM = nGAYKHAM;
            NHIETDO = nHIETDO;
            NHIPTIM = nHIPTIM;
            HUYETAP = hUYETAP;
            KETLUAN = kETLUAN;
        }

        public PhieuKham(int mAPK, int mABS, int mAKH, DateTime nGAYKHAM, int nHIETDO, int nHIPTIM, int hUYETAP, string kETLUAN)
        {
            MAPK = mAPK;
            MABS = mABS;
            MAKH = mAKH;
            NGAYKHAM = nGAYKHAM;
            NHIETDO = nHIETDO;
            NHIPTIM = nHIPTIM;
            HUYETAP = hUYETAP;
            KETLUAN = kETLUAN;
        }
    }
}
