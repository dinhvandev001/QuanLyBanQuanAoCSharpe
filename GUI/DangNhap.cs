using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        NhanVien_DTO NV = new NhanVien_DTO();
        NhanVien_BUS nv = new NhanVien_BUS();
        public static string TenTaiKhoan = "";
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.TextLength == 0)
                MessageBox.Show("Ten tai khoan khong duoc bo trong");
            else if (txtMatKhau.TextLength == 0)
                MessageBox.Show("Mat khau khong duoc bo trong");
            else
            {
                try
                {
                    NV.MaNhanVien = txtMaNhanVien.Text;
                    NV.MatKhau = txtMatKhau.Text;
                    TenTaiKhoan = txtMaNhanVien.Text;
                    if (nv.KiemTraDangNhap(NV.MaNhanVien, NV.MatKhau) == 0)
                    {
                        var form = new TrangChuAdmin();
                        form.ShowDialog();
                    }
                    else if (nv.KiemTraDangNhap(NV.MaNhanVien, NV.MatKhau) == 1)
                    {
                        var form = new TrangChuNhanVien();
                        form.ShowDialog();
                    }
                    else if (nv.KiemTraDangNhap(NV.MaNhanVien, NV.MatKhau) == 2)
                        MessageBox.Show("Ten tai khoan hoac mat khau khong dung!", "Thong bao");
                    else
                        MessageBox.Show("Co loi!");
                }
                catch { MessageBox.Show("Co loi!"); }
            }
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Select();
        }
    }
}
