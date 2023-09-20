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
    public class HoaDon_BUS
    {
        Data data = new Data();
        HoaDon_DTO HoaDon = new HoaDon_DTO();
        public DataTable ShowHoaDon()
        {
            string sql = "select * from HoaDon";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public int InsertHoaDon(int mgd, int mkh, string mnv, DateTime tg)
        {
            string sql = "INSERT INTO HoaDon(MaGiaoDich, MaKhachHang, MaNhanVien, ThoiGian) VALUES ('" + mgd + "', '" + mkh + "', '" + mnv + "', '" + tg + "')";
            data.ExcuteNonQuery(sql);
            string sql2 = "SELECT TOP 1 * FROM HoaDon ORDER BY MaHoaDon DESC";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql2);
            int mhd = Int32.Parse(dt.Rows[0]["MaHoaDon"].ToString());
            return mhd;
        }
        public void UpdateHoaDon(int mgd, int mkh, string mnv, DateTime tg, int mhd)
        {
            string sql = "UPDATE HoaDon SET MaGiaoDich = '" + mgd + "', MaKhachHang = '" + mkh + "', MaNhanVien = '" + mnv + "', ThoiGian = '" + tg + "' WHERE MaHoaDon = '" + mhd + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteHoaDon(int mhd)
        {
            string sql = "DELETE FROM HoaDon WHERE MaHoaDon = '" + mhd + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
