using System;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        string tentaikhoan_, matkhaucu_, matkhaumoi_, xacnhanmatkhau_;
        public string TenTaiKhoan
        { get { return tentaikhoan_; } set { tentaikhoan_ = value; } }
        public string MatKhauCu
        { get { return matkhaucu_; } set { matkhaucu_ = value; } }
        public string MatKhauMoi
        { get { return matkhaumoi_; } set { matkhaumoi_ = value; } }
        public string XacNhanMatKhau
        { get { return xacnhanmatkhau_; } set { xacnhanmatkhau_ = value; } }
    }
}
