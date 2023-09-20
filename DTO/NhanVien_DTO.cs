using System;

namespace DTO
{
    public class NhanVien_DTO
    {
        string manhanvien_, tennhanvien_, sodienthoai_, gioitinh_, diachi_, machucvu_, matkhau_;
        int namsinh_;
        public string MaNhanVien
        { get { return manhanvien_; } set { manhanvien_ = value; } }
        public string TenNhanVien
        { get { return tennhanvien_; } set { tennhanvien_ = value; } }
        public string SoDienThoai
        { get { return sodienthoai_; } set { sodienthoai_ = value; } }
        public string GioiTinh
        { get { return gioitinh_; } set { gioitinh_ = value; } }
        public string DiaChi
        { get { return diachi_; } set { diachi_ = value; } }
        public string MaChucVu
        { get { return machucvu_; } set { machucvu_ = value; } }
        public string MatKhau
        { get { return matkhau_; } set { matkhau_ = value; } }
        public int NamSinh
        { get { return namsinh_; } set { namsinh_ = value; } }
    }
}
