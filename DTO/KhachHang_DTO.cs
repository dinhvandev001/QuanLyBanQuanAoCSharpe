using System;

namespace DTO
{
    public class KhachHang_DTO
    {
        int makhachhang_, demkhachhang_;
        string tenkhachhang_, sodienthoai_;
        public int MaKhachHang
        { get { return makhachhang_; } set { makhachhang_ = value; } }
        public int DemKhachHang
        { get { return demkhachhang_; } set { demkhachhang_ = value; } }
        public string TenKhachHang
        { get { return tenkhachhang_; } set { tenkhachhang_ = value; } }
        public string SoDienThoai
        { get { return sodienthoai_; } set { sodienthoai_ = value; } }
    }
}
