using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Data
    {
        public SqlConnection GetConnect()
        {
            //Data Source=NITRO\DIHVO;Initial Catalog=BTL_Nhom4_QuanLyBanQuanAo;Integrated Security=True
            return new SqlConnection(@"Data Source=NITRO\DIHVO;Initial Catalog=BTL_Nhom4_QuanLyBanQuanAo;Integrated Security=True");
        }
        public DataTable GetTable(string sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
