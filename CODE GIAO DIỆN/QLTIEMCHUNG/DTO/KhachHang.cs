using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        int maKH;
        string hoTen;
        DateTime ngaySinh;
        string gioiTinh;
        string diaChi;
        string SDT;
        string CMND;
        string loaiKH;
        int maNGH;

        public KhachHang(int ma, string ten, DateTime dob, string gioi, string dc, string sdt, string cmnd, string loai, int NGH) {
            this.maKH = ma;
            this.hoTen = ten;
            this.ngaySinh = dob;
            this.diaChi = dc;
            this.SDT = sdt;
            this.CMND = cmnd;
            this.loaiKH = loai;
            this.maNGH = NGH;
        }
        public KhachHang(int ma, string ten, DateTime dob, string gioi, string dc, string sdt, string cmnd, string loai) {
            this.maKH = ma;
            this.hoTen = ten;
            this.ngaySinh = dob;
            this.diaChi = dc;
            this.SDT = sdt;
            this.CMND = cmnd;
            this.loaiKH = loai;
        }
        public int MaKH {
            get{ return maKH; }
            set{ maKH = value;}
        }
    }
}
