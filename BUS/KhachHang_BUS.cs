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
    public class KhachHang_BUS
    {
        Data data = new Data();
        KhachHang_DTO KhachHang = new KhachHang_DTO();
        public DataTable ShowKhachHang()
        {
            string sql = "select * from KhachHang";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable KiemTraKhachHang(string sdt)
        {
            string sql = "select * from KhachHang where SoDienThoai = '" + sdt + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertKhachHang(string tkh, string sdt)
        {
            string sql = "INSERT INTO KhachHang(TenKhachHang, SoDienThoai) VALUES('" + tkh + "', '" + sdt +"')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateKhachHang(int mkh, string tkh, string sdt)
        {
            string sql = "UPDATE KhachHang SET TenKhachHang = '" + tkh + "', SoDienThoai = '" + sdt + "' WHERE MaKhachHang = '" + mkh + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteKhachHang(int mkh)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKhachHang = '" + mkh + "'";
            data.ExcuteNonQuery(sql);
        }
        public DataTable SearchKhachHang(string tkh)
        {
            string sql = "SELECT * FROM KhachHang WHERE TenKhachHang LIKE '%" + tkh + "%' OR SoDienThoai LIKE '%" + tkh + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
