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
    public partial class LuongNhanVien : Form
    {
        public LuongNhanVien()
        {
            InitializeComponent();
        }
        LuongNhanVien_DTO LNV = new LuongNhanVien_DTO();
        LuongNhanVien_BUS lnv = new LuongNhanVien_BUS();

        private void LuongNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //Load LuongNhanVien
                LNV.MaNhanVien = DangNhap.TenTaiKhoan.ToString();
                dgvLuongNhanVien.DataSource = lnv.TimKiemLuongNhanVien(LNV.MaNhanVien);
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
