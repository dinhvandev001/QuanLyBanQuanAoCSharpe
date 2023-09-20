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
    public class DoanhSo_BUS
    {
        Data data = new Data();
        DoanhSo_DTO DoanhSo = new DoanhSo_DTO();
        public DataTable ShowDoanhSo()
        {
            string sql = "select * from DoanhSo";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertDoanhSo(int mgd, float vbd, float vht)
        {
            float ds = vht - vbd;
            string sql = "INSERT INTO DoanhSo (MaGiaoDich, VonBanDau, VonHienTai, DoanhSo) VALUES ('" + mgd + "', '" + vbd + "', '" + vht + "', '" + ds + "')";
            data.ExcuteNonQuery(sql);
        }

        public void ThemDoanhSo(int mgd, float stt, float stg)
        {
            float vbd, vht, ds;
            string sql = "select TOP 1 * from DoanhSo ORDER BY MaGiaoDich DESC";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            vbd = float.Parse(dt.Rows[0]["VonBanDau"].ToString());
            vht = float.Parse(dt.Rows[0]["VonHienTai"].ToString());
            vht = vht + stt - stg;
            ds = vht - vbd;
            //
            string sql2 = "INSERT INTO DoanhSo (MaGiaoDich, VonBanDau, VonHienTai, DoanhSo) VALUES ('" + mgd + "', '" + vbd + "', '" + vht + "', '" + ds + "')";
            data.ExcuteNonQuery(sql2);
        }


        public DataTable TimDoanhSoGanNhat()
        {
            string sql = "select TOP 1 * from DoanhSo ORDER BY MaGiaoDich DESC";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
