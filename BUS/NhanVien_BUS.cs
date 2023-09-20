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
    public class NhanVien_BUS
    {
        Data data = new Data();
        NhanVien_DTO NhanVien = new NhanVien_DTO();
        
        public int KiemTraDangNhap(string ttk, string mk)
        {
            int dn = 2;
            string sql = "select * from NhanVien " +
                "where MaNhanVien ='" + ttk + "' AND MatKhau = '" + mk + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            if (dt.Rows.Count == 1)
            {
                if (ttk == "admin")
                    dn = 0;
                else
                    dn = 1;
            }
            else
                dn = 2;
            return dn;
        }
        public DataTable ShowNhanVien()
        {
            string sql = "select MaNhanVien, TenNhanVien, SoDienThoai, NamSinh, GioiTinh, DiaChi, MaChucVu from NhanVien";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public void InsertNhanVien(string mnv, string tnv, string sdt, int ns, string gt, string dc, string mcv)
        {
            string sql = "insert into NhanVien(MaNhanVien, TenNhanVien, SoDienThoai, NamSinh, GioiTinh,  DiaChi, MaChucVu) " +
                "values('" + mnv + "','" + tnv + "','" + sdt + "','" + ns + "','" + gt + "','" + dc + "','" + mcv + "')";
            data.ExcuteNonQuery(sql);
        }
        public void UpdateNhanVien(string mnv, string tnv, string sdt, int ns, string gt, string dc, string mcv)
        {
            string sql = "update NhanVien set TenNhanVien ='" + tnv + "', SoDienThoai ='" + sdt + "', NamSinh ='" + ns + "'," +
                " GioiTinh ='" + gt + "', DiaChi ='" + dc + "', MaChucVu ='" + mcv + "' where MaNhanVien ='" + mnv + "'";
            data.ExcuteNonQuery(sql);
        }
        public void DeleteNhanVien(string mnv)
        {
            string sql = "delete NhanVien where MaNhanVien ='" + mnv + "'";
            data.ExcuteNonQuery(sql);
        }
        public DataTable TimKiemNhanVien(string mnv)
        {
            string sql = "select MaNhanVien, TenNhanVien, SoDienThoai, NamSinh, GioiTinh, DiaChi, MaChucVu" +
                " from NhanVien where MaNhanVien LIKE '%" + mnv + "%' OR TenNhanVien LIKE '%" + mnv + "%'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
        public DataTable PhanLoaiThongTinNhanVien(string tk)
        {
            string sql = "select MaNhanVien, TenNhanVien, SoDienThoai, NamSinh, GioiTinh, DiaChi, MaChucVu" +
                " from NhanVien WHERE GioiTinh = '" + tk + "' OR MaChucVu = '" + tk + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            return dt;
        }
    }
}
