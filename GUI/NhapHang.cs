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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        HangHoa_DTO HH = new HangHoa_DTO();
        HangHoa_BUS hh = new HangHoa_BUS();
        GiaoDich_DTO GD = new GiaoDich_DTO();
        GiaoDich_BUS gd = new GiaoDich_BUS();
        //DoanhSo_DTO DS = new DoanhSo_DTO();
        DoanhSo_BUS ds = new DoanhSo_BUS();
        private void NhapHang_Load(object sender, EventArgs e)
        {
            //Load KichThuoc
            Data da = new Data();
            string sql = "select KichThuoc from KichThuoc";
            cbKichThuoc.DataSource = da.GetTable(sql);
            cbKichThuoc.DisplayMember = "KichThuoc";
            cbKichThuoc.ValueMember = "KichThuoc";
            //Load MaLoaiHangHoa
            Data da2 = new Data();
            string sql2 = "select MaLoaiHangHoa from LoaiHangHoa";
            cbMaLoaiHangHoa.DataSource = da2.GetTable(sql2);
            cbMaLoaiHangHoa.DisplayMember = "TenLoaiHangHoa";
            cbMaLoaiHangHoa.ValueMember = "MaLoaiHangHoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HH.TenHangHoa = txtTenHangHoa.Text;
                HH.MaHangHoa = txtMaHangHoa.Text;
                HH.KichThuoc = Int32.Parse(cbKichThuoc.SelectedValue.ToString());
                HH.GiaNhap = float.Parse(txtGiaNhap.Text);
                HH.MaLoaiHangHoa = cbMaLoaiHangHoa.SelectedValue.ToString();
                HH.GiaBan = float.Parse(txtGiaBan.Text);
                HH.SoLuong = Int32.Parse(txtSoLuong.Text);
                HH.GhiChu = txtGhiChu.Text;
                hh.InsertHangHoa(HH.MaHangHoa, HH.KichThuoc, HH.GiaNhap, HH.TenHangHoa, HH.MaLoaiHangHoa, HH.GiaBan, HH.SoLuong, HH.GhiChu);
                GD.SoTien = HH.GiaNhap * HH.SoLuong;
                GD.NoiDung = "Nhap hang";
                GD.MaGiaoDich = gd.InsertGiaoDich();
                gd.UpdateGiaoDich(GD.MaGiaoDich, GD.SoTien, GD.NoiDung);
                float stt = 0;
                ds.ThemDoanhSo(GD.MaGiaoDich, stt, GD.SoTien);
                MessageBox.Show("Nhap hang thanh cong", "Thong bao");
                txtTenHangHoa.Clear();
                txtMaHangHoa.Clear();
                txtGiaNhap.Clear();
                txtGiaBan.Clear();
                txtSoLuong.Clear();
                txtGhiChu.Clear();
                txtTenHangHoa.Focus();
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
