using System;

namespace DTO
{
    public class LuongNhanVien_DTO
    {
        string manhanvien_;
        int magiaodich_;
        float luongcoban_, doanhso_, tongluong_;
        DateTime thoigian_;
        public string MaNhanVien
        { get { return manhanvien_; } set { manhanvien_ = value; } }
        public int MaGiaoDich
        { get { return magiaodich_; } set { magiaodich_ = value; } }
        public float LuongCoBan
        { get { return luongcoban_; } set { luongcoban_ = value; } }
        public float DoanhSo
        { get { return doanhso_; } set { doanhso_ = value; } }
        public float TongLuong
        { get { return tongluong_; } set { tongluong_ = value; } }
        public DateTime ThoiGian
        { get { return thoigian_; } set { thoigian_ = value; } }
    }
}
