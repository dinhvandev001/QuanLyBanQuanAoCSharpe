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
    public class HangHoa_BUS
    {
        Data data = new Data();
        HangHoa_DTO HangHoa = new HangHoa_DTO();
        public DataTable ShowHangHoa()
        {
            string sql = "select * from HangHoa";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertHangHoa(string mhh, int kt, float gn, string thh, string mlhh, float gb, int sl, string gc)
        {
            string sql = "INSERT INTO HangHoa(MaHangHoa, KichThuoc, GiaNhap, TenHangHoa, MaLoaiHangHoa, GiaBan, SoLuong, GhiChu) " +
                "VALUES ('" + mhh + "', '" + kt + "', '" + gn + "', '" + thh + "', '" + mlhh + "', '" + gb + "', '" + sl + "', '" + gc + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateHangHoa(string mhh, int kt, float gn, string thh, float gb, string gc)
        {
            string sql = "UPDATE HangHoa SET TenHangHoa = '" + thh + "', GiaBan = '" + gb + "', GhiChu = '" + gc + "' " +
                "WHERE MaHangHoa = '" + mhh + "' AND KichThuoc = '" + kt + "' AND GiaNhap = '" + gn + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteHangHoa(string mhh, int kt, float gb, int sl)
        {
            string sql = "UPDATE HangHoa SET SoLuong = '" + sl + "' WHERE MaHangHoa = '" + mhh + "' AND KichThuoc = '" + kt + "' AND GiaBan = '" + gb + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteHangHoaLuon()
        {
            string sql = "DELETE FROM HangHoa WHERE SoLuong <= '0'";
            data.ExcuteNonQuery(sql);
        }
        public int TimSoLuongHangHoa(string mhh, string kt, string gb)
        {
            string sql = "select distinct SoLuong from HangHoa where MaHangHoa = '" + mhh + "' AND" +
                " KichThuoc = '" + kt + "' AND GiaBan ='" + gb + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            int sl = Int32.Parse(dt.Rows[0]["SoLuong"].ToString());
            return sl;
        }
        public DataTable TimHangHoa(string thh)
        {
            string sql = "select * from HangHoa WHERE MaHangHoa LIKE '%" + thh + "%' OR TenHangHoa LIKE '%" + thh + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable PhanLoaiHangHoa(string kt)
        {
            string sql = "select * from HangHoa WHERE KichThuoc = '%" + kt + "%' OR MaLoaiHangHoa = '%" + kt + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
