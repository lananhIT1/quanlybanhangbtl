using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO
    {

    }
    public class dbConnectionData
    {
        public static SqlConnection ketNoi()
        {
            return new SqlConnection(@"Data Source=DESKTOP-A20L5JU\SQLEXPRESS;Initial Catalog=quanlybanhang;Integrated Security=True");
        }
        public static DataTable getTable(string sql)
        {
            SqlConnection conn = ketNoi();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public static void ExcuteNonQuery(string sql)
        {

            SqlConnection conn = ketNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();


        }
    }
    //dao dang nhap
    public class DAO_DANGNHAP
    {
        public static DataTable checkLogin(string user,string pass)
        {
            string sql = "Select * from DANGNHAP where username='" + user + "'and password='" + pass + "'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
    }
    public class DAO_SANPHAM
    {
        /*quản lý sản phẩm*/
        public static DataTable showListSP()
        {
             string sql = "select maSP,tenSP,donGia,soLuongTon,ngayNhap,tenDM,tenNCC from SANPHAM inner join DANHMUC on SANPHAM.maDM=DANHMUC.maDM inner join NCC on NCC.maNCC=SANPHAM.maNCC";
           DataTable dt = new DataTable();
             dt = dbConnectionData.getTable(sql);
            return dt;

        }
        public static DataTable getSPByCat(string maDM)
        {
            string sql = "select * from SANPHAM where maDM='" + maDM + "'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static bool getMaSP(string ma)
        {
            string sql = "select * from SANPHAM where maSP='" + ma + "'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public static DataTable getGiaByMaSP(string maSP)
        {
            string sql = "select donGia from SANPHAM where maSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static void insertSP(SP sp)
        {
            string sql = "insert into SANPHAM values('" + sp.MaSP + "','" + sp.TenSP + "','" + sp.DonGia + "','" + sp.SoLuongTon + "','" + sp.NgayNhap + "','" + sp.MaDM + "','" + sp.MaNCC + "')";
            dbConnectionData.ExcuteNonQuery(sql);

        }
        public static void updateSP(string ma, SP sp)
        {
            string sql = "update SANPHAM set tenSP='" + sp.TenSP + "',donGia='" + sp.DonGia + "',soLuongTon='" + sp.SoLuongTon + "',ngayNhap='" + sp.NgayNhap + "',maDM='" + sp.MaDM + "',maNCC='" + sp.MaNCC + "' where maSP='" + ma + "'";
            dbConnectionData.ExcuteNonQuery(sql);
        }
        public static void DeleteSP(string ma)
        {
            string sql = "delete SANPHAM where maSP='" + ma + "'";
            dbConnectionData.ExcuteNonQuery(sql);
        }
        public static DataTable SearchFullSp(Double from, Double to, string maDM, string keyword)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM  SANPHAM where tenSP like '%" + keyword + "%' and maDM='" + maDM + "' and donGia between '" + from + "' and '" + to + "' ";
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static DataTable SearchByDateDM(Double from, Double to, string maDM)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM  SANPHAM where  maDM='" + maDM + "' and donGia between '" + from + "' and '" + to + "' ";
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static DataTable SearchByDMKey(string maDM, string keyword)
        {
            string sql = "select * from KHACHHANG where tenKH like '%" + keyword + "%' and maDM='" + maDM + "'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static DataTable getQTYSP(string ma)
        {
            string sql = "select soLuongTon from SANPHAM where maSP='" + ma + "'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static void updateQTYSP(string maSP,int sl)
        {
            string sql = "update SANPHAM set soLuongTon=soLuongTon-'" + sl + "' where maSP='" + maSP + "'";
            dbConnectionData.ExcuteNonQuery(sql);
        }
    }
     public class DAO_DANHMUC
    {
        public static DataTable showListCategory()
        {
            string sql = "select * from DANHMUC";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;

        }
    }
    public class DAO_NCC
    {
        public static DataTable showListNCC()
        {
            String sql = "select * from NCC";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
    }
    public class DAO_KHACHHANG
    {
        public static DataTable showListKH()
        {
            String sql = "select * from KHACHHANG";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static void insertKH(KhachHang kh)
        {
            string sql = "insert into KHACHHANG values('" + kh.MaKH + "','" + kh.TenKH + "','" + kh.Sdt + "','" + kh.Email + "','" + kh.DiaChi + "')";
            dbConnectionData.ExcuteNonQuery(sql);
        }
        public static void updateKH(String maKH,KhachHang kh)
        {
            string sql = "update KHACHHANG set tenKH='" + kh.TenKH + "',sdt='" + kh.Sdt + "',email='" + kh.Email + "',diaChi='" + kh.DiaChi + "' where maKH='" + maKH + "'";
            dbConnectionData.ExcuteNonQuery(sql);
        }
        public static void deleteKH(string maKH)
        {
            string sql = "delete from KHACHHANG where maKH='" + maKH + "'";
            dbConnectionData.ExcuteNonQuery(sql);
        }
        public static DataTable searchKH(string q)
        {
            string sql = "select * from KHACHHANG where tenKH like '%" + q + "%'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
    }
    public class DAO_HOADON
    {
        public static DataTable showListHoaDon()
        {
            string sql = "select maHD, tenKH,tenSP,soLuong,donGia,ngayLap,donGia*soLuong as Thanhtien from HOADON inner join KHACHHANG on HOADON.maKH=KHACHHANG.maKH inner join SANPHAM on SANPHAM.maSP=HOADON.maSP group by maHD, tenKH,tenSP,soLuong,donGia,ngayLap";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
     
        }

        public static void insertHD(HOADON hd)
        {
            string sql = "insert into HoaDon values('" + hd.MaHD + "','" + hd.MaKH + "','" + hd.Masp + "','" + hd.Gia + "','" + hd.SoLuong + "','" + hd.NgayLap+"')";
            dbConnectionData.ExcuteNonQuery(sql);
        }
        public static void deleteHD(string maHD)
        {
            string sql = "delete from HOADON where maHD='" + maHD + "'";
            dbConnectionData.ExcuteNonQuery(sql);
        }
        public static void updateHD(string maHD,HOADON hd)
        {
            string sql = "update HOADON set maKH='" + hd.MaKH + "',maSP='" + hd.Masp + "',gia='" + hd.Gia + "',soLuong='" + hd.SoLuong + "',ngayLap='" + hd.NgayLap + "' where maHD='"+maHD+"'";
            dbConnectionData.ExcuteNonQuery(sql);
        }
        public static DataTable getHDByMaHD(string maHD)
        {
            string sql = "select * from HOADON where maHD='" + maHD + "'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static DataTable searchHDByTenKH(string keyword)
        {

            string sql = "select * from HOADON inner join KHACHHANG on HOADON.maKH=KHACHHANG.maKH where tenKH '%" + keyword + "%' ";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static DataTable searchHDByTenSP(string keyword)
        { 
            string sql = "select maHD,tenKH,tenSP,soLuong,gia,ngayLap,soLuong*gia as thanhTien from HOADON inner join SANPHAM on SANPHAM.maSP=HOADON.maSP inner join KHACHHANG on HOADON.maKH=KHACHHANG.maKH where tenSP like '%" + keyword + "%' group by maHD,tenKH,tenSP,soLuong,gia,ngayLap";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }
        public static DataTable getTotalSale(int thang)
        {
            string sql = "select sum(gia*soLuong) as thanhTien from HOADON where month(ngayLap)='" + thang+"'";
            DataTable dt = new DataTable();
            dt = dbConnectionData.getTable(sql);
            return dt;
        }

    }
    

}
