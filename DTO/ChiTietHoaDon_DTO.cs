using System;

namespace DTO
{
    public class ChiTietHoaDon_DTO
    {
        string mahanghoa_;
        int machitiethoadon_, machitiethoadon2_, mahoadon_, kichthuoc_, soluong_;
        float giaban_, thanhtien_;
        public string MaHangHoa
        { get { return mahanghoa_; } set { mahanghoa_ = value; } }
        public int MaChiTietHoaDon
        { get { return machitiethoadon_; } set { machitiethoadon_ = value; } }
        public int MaChiTietHoaDon2
        { get { return machitiethoadon2_; } set { machitiethoadon2_ = value; } }
        public int MaHoaDon
        { get { return mahoadon_; } set { mahoadon_ = value; } }
        public int KichThuoc
        { get { return kichthuoc_; } set { kichthuoc_ = value; } }
        public int SoLuong
        { get { return soluong_; } set { soluong_ = value; } }
        public float GiaBan
        { get { return giaban_; } set { giaban_ = value; } }
        public float ThanhTien
        { get { return thanhtien_; } set { thanhtien_ = value; } }
    }
}
