using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUS
    {


    }
    public class BUS_DANGNHAP
    {
        public static DataTable checkLogin2(string username, string password)
        {
            return DAO_DANGNHAP.checkLogin(username, password);
        }
    }
    public class BUS_SANPHAM
    {
        public static DataTable LoadListSP()
        {
            return DAO_SANPHAM.showListSP();
        }
        public static bool GetMaSP(string ma)
        {
            return DAO_SANPHAM.getMaSP(ma);
        }
        public static void InsertSP(SP sp)
        {
            DAO_SANPHAM.insertSP(sp);
        }
        public static void UpdateSP(string maSP,SP sp)
        {
            DAO_SANPHAM.updateSP(maSP,sp);
        }
        public static void DeleteSP(string ma)
        {
            DAO_SANPHAM.DeleteSP(ma);
        }
        public static DataTable GetGiaByMaSP(string maSP)
        {
            return DAO_SANPHAM.getGiaByMaSP(maSP);
        }
        public static void UpdateQTYSP(string maSP,int sl)
        {
            DAO_SANPHAM.updateQTYSP(maSP, sl);
        }
        public static DataTable GetQTYSP(string ma)
        {
            return DAO_SANPHAM.getQTYSP(ma);
        }

    }
    public class BUS_DANHMUC
    {
        public static DataTable loadListCategory()
        {
            return DAO_DANHMUC.showListCategory();
        }
    }
    public class BUS_NCC
    {
        public static DataTable loadListNCC()
        {
            return DAO_NCC.showListNCC();
        }

    }
    public class BUS_HOADON
    {
        public static DataTable showListHoaDon()
        {
            return DAO_HOADON.showListHoaDon();
        }
        public static void InsertHD(HOADON hd)
        {
            DAO_HOADON.insertHD(hd);
        }
        public static void DeleteHD(string maHD)
        {
            DAO_HOADON.deleteHD(maHD);
        }
        public static void UpdateHD(string maHD,HOADON hd)
        {
            DAO_HOADON.updateHD(maHD, hd);
        }
        public static DataTable DuplicateHD(string maHD)
        {
            return DAO_HOADON.getHDByMaHD(maHD);
        }
        public static DataTable SearchHDByTenSP(string tenSP)
        {
            return DAO_HOADON.searchHDByTenSP(tenSP);
        }
        public static DataTable GetTotalSale(int thang)
        {
            return DAO_HOADON.getTotalSale(thang);
        }
    }
    public class BUS_KHACHHANG
    {
        public static DataTable showListKhachHang()
        {
            return DAO_KHACHHANG.showListKH();
        }
        public static void InsertKH(KhachHang kh)
        {
            DAO_KHACHHANG.insertKH(kh);
        }
        public static void UpdateKH(string maKH, KhachHang kh)
        {
            DAO_KHACHHANG.updateKH(maKH, kh);
        }
        public static void DeleteKH(string maKH)
        {
            DAO_KHACHHANG.deleteKH(maKH);
        }
        public static DataTable SearchKH(string q)
        {
            return DAO_KHACHHANG.searchKH(q);
        }
    }

}
