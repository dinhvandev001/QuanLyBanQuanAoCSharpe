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
    public class GioiTinh_BUS
    {
        Data data = new Data();
        GioiTinh_DTO GioiTinh = new GioiTinh_DTO();
        public DataTable ShowGioiTinh()
        {
            string sql = "select GioiTinh from GioiTinh";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertGioiTinh(string gt)
        {
            string sql = "INSERT INTO GioiTinh VALUES('" + gt + "')";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteGioiTinh(string gt)
        {
            string sql = "delete GioiTinh where GioiTinh ='" + gt + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
