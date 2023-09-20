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
    public class ChucVu_BUS
    {
        Data data = new Data();
        ChucVu_DTO ChucVu = new ChucVu_DTO();
        public DataTable ShowChucVu()
        {
            string sql = "SELECT * FROM ChucVu";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertChucVu(string mcv, string tcv)
        {
            string sql = "INSERT INTO ChucVu VALUES('" + mcv + "', '" + tcv + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateChucVu(string mcv, string tcv)
        {
            string sql = "UPDATE ChucVu SET TenChucVu = '" + tcv + "' WHERE MaChucVu = '" + mcv + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteChucVu(string mcv)
        {
            string sql = "delete ChucVu where MaChucVu ='" + mcv + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
