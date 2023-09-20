using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class LuongNhanVien_BUS
    {
        Data data = new Data();
        LuongNhanVien_DTO LuongNhanVien = new LuongNhanVien_DTO();
        public void ThemLuongNhanVien(string mnv, DateTime tg, int mgd, float lcb, float ds, float tl)
        {
            string sql = "INSERT INTO LuongNhanVien (MaNhanVien, ThoiGian, MaGiaoDich, LuongCoBan, DoanhSo, TongLuong) VALUES " +
                "('" + mnv + "', '" + tg + "', '" + mgd + "', '" + lcb + "', '" + ds + "', '" + tl + "')";
            data.ExcuteNonQuery(sql);
          
        }
        public DataTable HienThiLuongNhanVien()
        {
            string sql = "select LuongNhanVien.MaNhanVien, NhanVien.TenNhanVien, ThoiGian, LuongCoBan, " +
                "DoanhSo, TongLuong from LuongNhanVien, NhanVien where LuongNhanVien.MaNhanVien = NhanVien.MaNhanVien";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable PhanLoaiLuongNhanVien(DateTime tg)
        {
            string sql = "select LuongNhanVien.MaNhanVien, NhanVien.TenNhanVien, ThoiGian, LuongCoBan, DoanhSo, TongLuong from" +
                " LuongNhanVien, NhanVien where LuongNhanVien.MaNhanVien = NhanVien.MaNhanVien AND ThoiGian = '" + tg + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable TimKiemLuongNhanVien(string mnv)
        {
            string sql = "select LuongNhanVien.MaNhanVien, NhanVien.TenNhanVien, ThoiGian, LuongCoBan, DoanhSo, TongLuong from" +
                " LuongNhanVien, NhanVien where LuongNhanVien.MaNhanVien = NhanVien.MaNhanVien AND LuongNhanVien.MaNhanVien LIKE '%" + mnv + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public float TinhLuongNhanVien(string mnv)
        {
            string sql = "select HoaDon.MaNhanVien, GiaoDich.SoTien from HoaDon, GiaoDich where " +
                "MaNhanVien= '" + mnv + "' AND HoaDon.MaGiaoDich = GiaoDich.MaGiaoDich ORDER BY GiaoDich.SoTien DESC";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            string tong = dt.Compute("SUM(SoTien)", "").ToString();
            float tongTien = float.Parse(tong.ToString());
            return tongTien;
        }
    }
}
