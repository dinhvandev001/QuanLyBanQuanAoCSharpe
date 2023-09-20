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
    public class LoaiHangHoa_BUS
    {
        Data data = new Data();
        LoaiHangHoa_DTO LoaiHangHoa = new LoaiHangHoa_DTO();
        public DataTable ShowLoaiHangHoa()
        {
            string sql = "select * from LoaiHangHoa";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertLoaiHangHoa(string mlhh, string tlhh)
        {
            string sql = "insert LoaiHangHoa values('" + mlhh + "','" + tlhh + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateLoaiHangHoa(string mlhh, string tlhh)
        {
            string sql = "update LoaiHangHoa set TenLoaiHangHoa ='" + tlhh + "' where MaLoaiHangHoa ='" + mlhh + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteLoaiHangHoa(string mlhh)
        {
            string sql = "delete LoaiHangHoa where MaLoaiHangHoa ='" + mlhh + "'";
            data.ExcuteNonQuery(sql);
        }
    }
}
