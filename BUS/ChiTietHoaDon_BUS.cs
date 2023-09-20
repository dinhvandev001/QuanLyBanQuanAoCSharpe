using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;
using DAL;

namespace BUS
{
    public class ChiTietHoaDon_BUS
    {
        Data data = new Data();
        ChiTietHoaDon_DTO ChiTietHoaDon = new ChiTietHoaDon_DTO();
        HangHoa_BUS hh = new HangHoa_BUS();
        public DataTable ShowChiTietHoaDon()
        {
            string sql = "select MaHangHoa, KichThuoc, GiaBan, SoLuong, ThanhTien from ChiTietHoaDon";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable ShowChiTietHoaDonBanHang(int mhd)
        {
            string sql = "select MaHangHoa, KichThuoc, GiaBan, SoLuong, ThanhTien from ChiTietHoaDon WHERE MaHoaDon='" + mhd + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertChiTietHoaDon(int mcthd, int mhd, string mhh, int kt, float gb, int sl, float tt)
        {
            string sql = "INSERT INTO ChiTietHoaDon VALUES ('" + mcthd + "', '" + mhd + "', '" + mhh + "', '" + kt + "', '" + gb + "', '" + sl + "', '" + tt + "')";
            data.ExcuteNonQuery(sql);
        }
        public int TimMaChiTietHoaDon(int mhd, string mhh, int kt, float gb, int sl, float tt)
        {
            string sql = "select MaChiTietHoaDon from ChiTietHoaDon where MaHoaDon='" + mhd + "' and MaHangHoa='" + mhh + "' and " +
                "KichThuoc='" + kt + "' and GiaBan='" + gb + "' and SoLuong='" + sl + "' and ThanhTien='" + tt + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            int mcthd = Int32.Parse(dt.Rows[0]["MaChiTietHoaDon"].ToString());
            return mcthd;
        }
        public void UpdateChiTietHoaDon(int mcthd, int mhd, string mhh, int kt, float gb, int sl, float tt)
        { 
            string sql = "UPDATE ChiTietHoaDon SET MaHangHoa = '" + mhh + "', KichThuoc = '" + kt + "', GiaBan = '" + gb + "', " +
                "SoLuong = '" + sl + "', ThanhTien = '" + tt + "' WHERE MaChiTietHoaDon = '" + mcthd + "' AND MaHoaDon = '" + mhd + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteChiTietHoaDon(int mcthd, int mhd)
        {
            string sql = "DELETE FROM ChiTietHoaDon WHERE MaChiTietHoaDon = '" + mcthd + "' AND MaHoaDon = '" + mhd + "'";
            data.ExcuteNonQuery(sql);
        }
        public float TinhTongTien(int mhd)
        {
            string sql = "select ThanhTien from ChiTietHoaDon WHERE MaHoaDon='" + mhd + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            string tong = dt.Compute("SUM(ThanhTien)","").ToString();
            float tongTien = float.Parse(tong.ToString());
            return tongTien;
        }
        public void XoaHangHoa(int mhd)
        {
            string sql = "select MaHangHoa, KichThuoc, GiaBan, SoLuong from ChiTietHoaDon WHERE MaHoaDon= '" + mhd + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                try
                {
                    string mhh = dt.Rows[i]["MaHangHoa"].ToString();
                    int kt = Int32.Parse(dt.Rows[i]["KichThuoc"].ToString());
                    int gb = Int32.Parse(dt.Rows[i]["GiaBan"].ToString());
                    int slBan = Int32.Parse(dt.Rows[i]["SoLuong"].ToString());
                    int slGoc = hh.TimSoLuongHangHoa(mhh, kt.ToString(), gb.ToString());
                    int sl = slGoc - slBan;
                    hh.DeleteHangHoa(mhh, kt, gb, sl);
                }
                catch
                {
                    //khong bi gi ca
                }
            }
            hh.DeleteHangHoaLuon();
        }
    }
}
