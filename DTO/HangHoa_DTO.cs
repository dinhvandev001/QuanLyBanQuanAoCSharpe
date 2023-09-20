using System;

namespace DTO
{
    public class HangHoa_DTO
    {
        string mahanghoa_, tenhanghoa_, maloaihanghoa_, ghichu_;
        int kichthuoc_, soluong_;
        float gianhap_, giaban_;
        public string MaHangHoa
        { get { return mahanghoa_; } set { mahanghoa_ = value; } }
        public string TenHangHoa
        { get { return tenhanghoa_; } set { tenhanghoa_ = value; } }
        public string MaLoaiHangHoa
        { get { return maloaihanghoa_; } set { maloaihanghoa_ = value; } }
        public string GhiChu
        { get { return ghichu_; } set { ghichu_ = value; } }
        public int KichThuoc
        { get { return kichthuoc_; } set { kichthuoc_ = value; } }
        public int SoLuong
        { get { return soluong_; } set { soluong_ = value; } }
        public float GiaNhap
        { get { return gianhap_; } set { gianhap_ = value; } }
        public float GiaBan
        { get { return giaban_; } set { giaban_ = value; } }
    }
}
