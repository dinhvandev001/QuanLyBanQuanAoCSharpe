using System;

namespace DTO
{
    public class LoaiHangHoa_DTO
    {
        string maloaihanghoa_, tenloaihanghoa_;
        public string MaLoaiHangHoa
        { get { return maloaihanghoa_; } set { maloaihanghoa_ = value; } }
        public string TenLoaiHangHoa
        { get { return tenloaihanghoa_; } set { tenloaihanghoa_ = value; } }
    }
}
