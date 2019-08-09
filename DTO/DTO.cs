using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO
    {
    }
    public class KhachHang
    {
        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string tenKH;
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        private string sdt;
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public KhachHang(string maKH, string tenKH, string sdt, string email, string diaChi)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.email = email;
            this.diaChi = diaChi;
        }

    }
    public class SP
    {
        private string maSP;
        private string tenSP;
        private float donGia;
        private int soLuongTon;
        private string ngayNhap;
        private string maDM;
        private string maNCC;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public string TenSP
        {
            get { return tenSP; }
            set { maSP = value; }
        }
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }
        public string NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public string MaDM
        {
            get { return maDM; }
            set { maDM = value; }
        }
        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public SP(string maSP, string tenSP, float donGia, int soLuongTon, string nn, string maDM, string maNCC)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donGia = donGia;
            this.soLuongTon = soLuongTon;
            this.ngayNhap = nn;
            this.maDM = maDM;
            this.maNCC = maNCC;
        }


    }
    public class HOADON {
        private string maHD;
        private string maKH;
        private string maSP;
        private float gia;
        private int soLuong;
        private string ngayLap;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; } 
        }
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string Masp
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        public HOADON(string maHD,string maKH,string maSP,float gia,int soLuong,string ngayLap)
        {
            this.maHD = maHD;
            this.maKH=maKH;
            this.maSP=maSP;
            this.gia=gia;
            this.soLuong=soLuong;
            this.ngayLap=ngayLap;
            
        }
    }

}
