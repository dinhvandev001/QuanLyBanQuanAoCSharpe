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
    public partial class DanhSachThongTinNhanVien : Form
    {
        public DanhSachThongTinNhanVien()
        {
            InitializeComponent();
        }
        NhanVien_DTO NV = new NhanVien_DTO();
        NhanVien_BUS nv = new NhanVien_BUS();
        private void DanhSachThongTinNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //Load NhanVien
                dgvDanhSachThongTinNhanVien.DataSource = nv.ShowNhanVien();
                //Load GioiTinh
                Data da = new Data();
                string sql = "select * from GioiTinh";
                cbGioiTinh.DataSource = da.GetTable(sql);
                cbGioiTinh.DisplayMember = "GioiTinh";
                cbGioiTinh.ValueMember = "GioiTinh";
                //Load MaChucVu
                Data da2 = new Data();
                string sql2 = "select * from ChucVu";
                cbMaChucVu.DataSource = da2.GetTable(sql2);
                cbMaChucVu.DisplayMember = "MaChucVu";
                cbMaChucVu.ValueMember = "MaChucVu";
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0)
            {
                MessageBox.Show("Ban chua nhap tu khoa", "Thong bao");
            }
            else
            {
                try
                {
                    NV.MaNhanVien = txtTimKiem.Text;
                    dgvDanhSachThongTinNhanVien.DataSource = nv.TimKiemNhanVien(NV.MaNhanVien);
                }
                catch
                {
                    MessageBox.Show("Loi!");
                }
            }
        }

        private void cbGioiTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                NV.GioiTinh = cbGioiTinh.Text;
                dgvDanhSachThongTinNhanVien.DataSource = nv.PhanLoaiThongTinNhanVien(NV.GioiTinh);
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void cbMaChucVu_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                NV.MaChucVu = cbMaChucVu.Text;
                dgvDanhSachThongTinNhanVien.DataSource = nv.PhanLoaiThongTinNhanVien(NV.MaChucVu);
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DanhSachThongTinNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
