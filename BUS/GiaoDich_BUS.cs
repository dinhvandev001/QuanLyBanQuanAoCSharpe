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
    public class GiaoDich_BUS
    {
        Data data = new Data();
        GiaoDich_DTO GiaoDich = new GiaoDich_DTO();
        public DataTable ShowGiaoDich()
        {
            string sql = "select * from GiaoDich";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public int InsertGiaoDich()
        {
            string sql = "INSERT INTO GiaoDich(NoiDung) VALUES ('Tao giao dich')";
            data.ExcuteNonQuery(sql);
            string sql2 = "SELECT TOP 1 * FROM GiaoDich ORDER BY MaGiaoDich DESC";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql2);
            int mgd = Int32.Parse(dt.Rows[0]["MaGiaoDich"].ToString());
            return mgd;
        }
        public void UpdateGiaoDich(int mgd, float st, string nd)
        {
            string sql = "UPDATE GiaoDich SET SoTien = '" + st + "', NoiDung = '" + nd + "' WHERE MaGiaoDich = '" + mgd + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteGiaoDich(int mgd)
        {
            string sql = "DELETE FROM GiaoDich WHERE MaGiaoDich = '" + mgd + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
