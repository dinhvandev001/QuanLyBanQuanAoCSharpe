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
    public class KichThuoc_BUS
    {
        Data data = new Data();
        KichThuoc_DTO KichThuoc = new KichThuoc_DTO();
        public DataTable ShowKichThuoc()
        {
            string sql = "SELECT * FROM KichThuoc";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertKichThuoc(int kt)
        {
            string sql = "INSERT INTO KichThuoc VALUES('" + kt + "')";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteKichThuoc(int kt)
        {
            string sql = "delete KichThuoc where KichThuoc ='" + kt + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
