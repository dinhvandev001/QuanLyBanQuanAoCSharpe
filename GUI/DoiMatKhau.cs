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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        TaiKhoan_DTO TK = new TaiKhoan_DTO();
        TaiKhoan_BUS tk = new TaiKhoan_BUS();

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            lbTenTaiKhoan.Text = "Tai khoan: " + DangNhap.TenTaiKhoan.ToString();
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.TextLength == 0)
            {
                MessageBox.Show("Ban chua nhap mat khau cu");
            }
            else if (txtMatKhauMoi.TextLength == 0 || txtXacNhanMatKhau.TextLength == 0)
            {
                MessageBox.Show("Ban chua nhap mat khau moi");
            }
            else
            {
                TK.TenTaiKhoan = DangNhap.TenTaiKhoan.ToString();
                TK.MatKhauCu = txtMatKhauCu.Text;
                TK.MatKhauMoi = txtMatKhauMoi.Text;
                TK.XacNhanMatKhau = txtXacNhanMatKhau.Text;
                int kt = tk.DoiMatKhau(TK.TenTaiKhoan, TK.MatKhauCu, TK.MatKhauMoi, TK.XacNhanMatKhau);
                if (kt == 1)
                {
                    this.Close();
                }
                else if (kt == 0)
                {
                    txtMatKhauCu.Clear();
                    txtMatKhauCu.Focus();
                }
                else if (kt == 2)
                {
                    txtMatKhauMoi.Clear();
                    txtXacNhanMatKhau.Clear();
                    txtMatKhauMoi.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
