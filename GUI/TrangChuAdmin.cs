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
    public partial class TrangChuAdmin : Form
    {
        public TrangChuAdmin()
        {
            InitializeComponent();
        }

        public void TrangChuAdmin_Load(object sender, EventArgs e)
        {
            lbTenTaiKhoan.Text = "Tai khoan: " + DangNhap.TenTaiKhoan.ToString();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BanHang();
            form.ShowDialog();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyNhanVien();
            form.ShowDialog();
        }

        private void quanLyLuongNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyLuongNhanVien();
            form.ShowDialog();
        }

        private void quanLyHangTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyKhachHang();
            form.ShowDialog();
        }

        private void quanLyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new QuanLyKhachHang();
            form.ShowDialog();
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyKhachHang();
            form.ShowDialog();
        }

        private void quanLyHangTrongKhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new QuanLyHangTrongKho();
            form.ShowDialog();
        }

        private void quanLyDoanhSoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyDoanhSo();
            form.ShowDialog();
        }

        private void quanLyLoaiHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyLoaiHangHoa();
            form.ShowDialog();
        }

        private void quanLyKichCoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyKichThuoc();
            form.ShowDialog();
        }

        private void quanLyGioiTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyGioiTinh();
            form.ShowDialog();
        }

        private void quanLyChucVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new QuanLyChucVu();
            form.ShowDialog();
        }

        private void danhSachThongTinNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DanhSachThongTinNhanVien();
            form.ShowDialog();
        }

        private void danhSachLuongNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DanhSachLuongNhanVien();
            form.ShowDialog();
        }

        private void danhSachKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DanhSachKhachHang();
            form.ShowDialog();
        }

        private void danhSachHangTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DanhSachHangTrongKho();
            form.ShowDialog();
        }

        private void danhSachDoanhSoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DanhSachDoanhSo();
            form.ShowDialog();
        }

        private void doiMatKhauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new DoiMatKhau();
            form.ShowDialog();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Ban co muon dang xuat!", "Thong bao", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Ban co muon thoat!", "Thong bao", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nhapHangToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new NhapHang();
            form.ShowDialog();
        }
    }
}
