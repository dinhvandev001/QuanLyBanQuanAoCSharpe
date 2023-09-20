using System;

namespace DTO
{
    public class DoanhSo_DTO
    {
        int magiaodich_;
        float vonbandau_, vonhientai_, doanhso_;
        public int MaGiaoDich
        { get { return magiaodich_; } set { magiaodich_ = value; } }
        public float VonBanDau
        { get { return vonbandau_; } set { vonbandau_ = value; } }
        public float VonHienTai
        { get { return vonhientai_; } set { vonhientai_ = value; } }
        public float DoanhSo
        { get { return doanhso_; } set { doanhso_ = value; } }
    }
}
