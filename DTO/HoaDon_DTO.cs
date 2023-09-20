using System;

namespace DTO
{
    public class HoaDon_DTO
    {
        string makhachhang_, manhanvien_;
        int mahoadon_, magiaodich_;
        DateTime thoigian_;
        public string MaKhachHang
        { get { return makhachhang_; } set { makhachhang_ = value; } }
        public string MaNhanVien
        { get { return manhanvien_; } set { manhanvien_ = value; } }
        public int MaHoaDon
        { get { return mahoadon_; } set { mahoadon_ = value; } }
        public int MaGiaoDich
        { get { return magiaodich_; } set { magiaodich_ = value; } }
        public DateTime ThoiGian
        { get { return thoigian_; } set { thoigian_ = value; } }  
    }
}
