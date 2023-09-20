using System;

namespace DTO
{
    public class GiaoDich_DTO
    {
        string noidung_;
        int magiaodich_;
        float sotien_;
        public string NoiDung
        { get { return noidung_; } set { noidung_ = value; } }
        public int MaGiaoDich
        { get { return magiaodich_; } set { magiaodich_ = value; } }
        public float SoTien
        { get { return sotien_; } set { sotien_ = value; } }
    }
}
