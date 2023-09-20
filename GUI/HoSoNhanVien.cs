using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class HoSoNhanVien : Form
    {
        public HoSoNhanVien()
        {
            InitializeComponent();
        }
        NhanVien_DTO NV = new NhanVien_DTO();
        NhanVien_BUS nv = new NhanVien_BUS();
        private void HoSoNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //Load NhanVien
                NV.MaNhanVien = DangNhap.TenTaiKhoan.ToString();
                txtMaNhanVien.Text = NV.MaNhanVien;
                txtTenNhanVien.Text = nv.TimKiemNhanVien(NV.MaNhanVien).Rows[0]["TenNhanVien"].ToString();
                txtSoDienThoai.Text = nv.TimKiemNhanVien(NV.MaNhanVien).Rows[0]["SoDienThoai"].ToString();
                txtNamSinh.Text = nv.TimKiemNhanVien(NV.MaNhanVien).Rows[0]["NamSinh"].ToString();
                txtGioiTinh.Text = nv.TimKiemNhanVien(NV.MaNhanVien).Rows[0]["GioiTinh"].ToString();
                txtDiaChi.Text = nv.TimKiemNhanVien(NV.MaNhanVien).Rows[0]["DiaChi"].ToString();
                txtMaChucVu.Text = nv.TimKiemNhanVien(NV.MaNhanVien).Rows[0]["MaChucVu"].ToString();
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NV.MaNhanVien = DangNhap.TenTaiKhoan.ToString();
                NV.TenNhanVien = txtTenNhanVien.Text;
                NV.SoDienThoai = txtSoDienThoai.Text;
                NV.NamSinh = Int32.Parse(txtNamSinh.Text);
                NV.GioiTinh = txtGioiTinh.Text;
                NV.DiaChi = txtDiaChi.Text;
                NV.MaChucVu = txtMaChucVu.Text;
                nv.UpdateNhanVien(NV.MaNhanVien, NV.TenNhanVien, NV.SoDienThoai, NV.NamSinh, NV.GioiTinh, NV.DiaChi, NV.MaChucVu);
                HoSoNhanVien_Load(sender, e);
                MessageBox.Show("Sua thong tin nhan vien thanh cong", "Thong bao");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
