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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }

        KhachHang_DTO KH = new KhachHang_DTO();
        KhachHang_BUS kh = new KhachHang_BUS();
        HangHoa_DTO HH = new HangHoa_DTO();
        HangHoa_BUS hh = new HangHoa_BUS();
        ChiTietHoaDon_DTO CTHD = new ChiTietHoaDon_DTO();
        ChiTietHoaDon_BUS cthd = new ChiTietHoaDon_BUS();
        GiaoDich_DTO GD = new GiaoDich_DTO();
        GiaoDich_BUS gd = new GiaoDich_BUS();
        HoaDon_DTO HD = new HoaDon_DTO();
        HoaDon_BUS hd = new HoaDon_BUS();
        DoanhSo_DTO DS = new DoanhSo_DTO();
        DoanhSo_BUS ds = new DoanhSo_BUS();
        int soLuong;

        private void BanHang_Load(object sender, EventArgs e)
        {
            //Load MaHangHoa
            Data da = new Data();
            string sql = "select distinct MaHangHoa from HangHoa";
            cbMaHangHoa.DataSource = da.GetTable(sql);
            cbMaHangHoa.DisplayMember = "MaHangHoa";
            cbMaHangHoa.ValueMember = "MaHangHoa";
            KH.DemKhachHang = 0;
        }

        private void cbMaHangHoa_SelectedValueChanged(object sender, EventArgs e)
        {
            //Load Kich thuoc
            Data da2 = new Data();
            string sql2 = "select distinct KichThuoc from HangHoa where MaHangHoa = '" + cbMaHangHoa.Text + "'";
            cbKichThuoc.DataSource = da2.GetTable(sql2);
            cbKichThuoc.DisplayMember = "KichThuoc";
            cbKichThuoc.ValueMember = "KichThuoc";
        }

        private void cbKichThuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            //Load GiaBan
            Data da = new Data();
            string sql = "select distinct GiaBan from HangHoa where MaHangHoa = '" + cbMaHangHoa.Text + "' AND KichThuoc = '" + cbKichThuoc.Text + "'";
            cbGiaBan.DataSource = da.GetTable(sql);
            cbGiaBan.DisplayMember = "GiaBan";
            cbGiaBan.ValueMember = "GiaBan";
        }

        private void cbGiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load SoLuong
            HH.SoLuong = hh.TimSoLuongHangHoa(cbMaHangHoa.Text, cbKichThuoc.Text, cbGiaBan.Text);
            if (HH.SoLuong > 0)
            {
                soLuong = 0;
                txtSoLuong.Text = soLuong.ToString();
                soLuong = 1;
                txtSoLuong.Text = soLuong.ToString();
            }
            else
            {
                soLuong = 0;
                txtSoLuong.Text = soLuong.ToString();
                MessageBox.Show("San pham dang het hang!", "Thong bao");
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (soLuong <= 0)
            {
                soLuong = 1;
                txtSoLuong.Text = soLuong.ToString();
            }
            else if(soLuong > HH.SoLuong)
            {
                soLuong = HH.SoLuong;
                txtSoLuong.Text = soLuong.ToString();
            }
            soLuong = Int32.Parse(txtSoLuong.Text);
            HH.GiaBan = Int32.Parse(cbGiaBan.Text);
            txtThanhTien.Text = (soLuong * HH.GiaBan).ToString();
        }

        private void btnCongSoLuong_Click(object sender, EventArgs e)
        {
            soLuong = Int32.Parse(txtSoLuong.Text);
            soLuong += 1;
            txtSoLuong.Text = soLuong.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CTHD.MaHangHoa = cbMaHangHoa.SelectedValue.ToString();
            CTHD.KichThuoc = Int32.Parse(cbKichThuoc.SelectedValue.ToString());
            CTHD.GiaBan = float.Parse(cbGiaBan.SelectedValue.ToString());
            CTHD.SoLuong = Int32.Parse(txtSoLuong.Text);
            CTHD.ThanhTien = float.Parse(txtThanhTien.Text);
            cthd.UpdateChiTietHoaDon(CTHD.MaChiTietHoaDon2, CTHD.MaHoaDon, CTHD.MaHangHoa, CTHD.KichThuoc, CTHD.GiaBan, CTHD.SoLuong, CTHD.ThanhTien);
            dgvChiTietHoaDon.DataSource = cthd.ShowChiTietHoaDonBanHang(CTHD.MaHoaDon);
            try
            {
                txtTongTien.Text = cthd.TinhTongTien(CTHD.MaHoaDon).ToString();
            }
            catch
            {
                txtTongTien.Text = "0";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cthd.DeleteChiTietHoaDon(CTHD.MaChiTietHoaDon2, CTHD.MaHoaDon);
            dgvChiTietHoaDon.DataSource = cthd.ShowChiTietHoaDonBanHang(CTHD.MaHoaDon);
            try
            {
                txtTongTien.Text = cthd.TinhTongTien(CTHD.MaHoaDon).ToString();
            }
            catch
            {
                txtTongTien.Text = "0";
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string noiDung = "Ban hang";
            float soTien = cthd.TinhTongTien(CTHD.MaHoaDon);
            float stg = 0;
            gd.UpdateGiaoDich(GD.MaGiaoDich, soTien, noiDung);
            ds.ThemDoanhSo(GD.MaGiaoDich, soTien, stg);
            cthd.XoaHangHoa(CTHD.MaHoaDon);
            MessageBox.Show("Thanh toan thanh cong", "Thong bao");
            this.Close();
        }

        private void dgvChiTietHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                cbMaHangHoa.SelectedValue = dgvChiTietHoaDon.Rows[dong].Cells[0].Value.ToString();
                cbKichThuoc.SelectedValue = dgvChiTietHoaDon.Rows[dong].Cells[1].Value.ToString();
                cbGiaBan.SelectedValue = dgvChiTietHoaDon.Rows[dong].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvChiTietHoaDon.Rows[dong].Cells[3].Value.ToString();
                txtThanhTien.Text = dgvChiTietHoaDon.Rows[dong].Cells[4].Value.ToString();
                string maHangHoa = cbMaHangHoa.Text;
                int kichThuoc = Int32.Parse(cbKichThuoc.Text);
                float giaBan = float.Parse(cbGiaBan.Text);
                int soLuong = Int32.Parse(txtSoLuong.Text);
                float thanhTien = float.Parse(txtThanhTien.Text);
                CTHD.MaChiTietHoaDon2 = cthd.TimMaChiTietHoaDon(CTHD.MaHoaDon, maHangHoa, kichThuoc, giaBan, soLuong, thanhTien);
            }
            catch
            {
                MessageBox.Show("Co loi!");
            }
        }

        private void btnTruSoLuong_Click(object sender, EventArgs e)
        {
            soLuong = Int32.Parse(txtSoLuong.Text);
            soLuong -= 1;
            txtSoLuong.Text = soLuong.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KH.DemKhachHang == 0)
            {
                MessageBox.Show("Ban can them khach hang truoc!", "Thong bao");
            }
            if (KH.DemKhachHang == 1)
            {
                CTHD.MaHangHoa = cbMaHangHoa.SelectedValue.ToString();
                CTHD.KichThuoc = Int32.Parse(cbKichThuoc.SelectedValue.ToString());
                CTHD.GiaBan = float.Parse(cbGiaBan.SelectedValue.ToString());
                CTHD.SoLuong = Int32.Parse(txtSoLuong.Text);
                CTHD.ThanhTien = float.Parse(txtThanhTien.Text);
                cthd.InsertChiTietHoaDon(CTHD.MaChiTietHoaDon, CTHD.MaHoaDon, CTHD.MaHangHoa, CTHD.KichThuoc, CTHD.GiaBan, CTHD.SoLuong, CTHD.ThanhTien);
                CTHD.MaChiTietHoaDon += 1;
                dgvChiTietHoaDon.DataSource = cthd.ShowChiTietHoaDonBanHang(CTHD.MaHoaDon);
                try
                {
                    txtTongTien.Text = cthd.TinhTongTien(CTHD.MaHoaDon).ToString();
                }
                catch
                {
                    txtTongTien.Text = "0";
                }
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            string tkh = txtTenKhachHang.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            if (tkh.Length == 0)
            {
                MessageBox.Show("Ban chua nhap ten!", "Thong bao");
                txtTenKhachHang.Focus();
            }
            else if (sdt.Length != 10)
            {
                MessageBox.Show("So dien thoai sai!", "Thong bao");
                txtSoDienThoai.Focus();
            }
            else
            {
                KH.TenKhachHang = txtTenKhachHang.Text.Trim();
                KH.SoDienThoai = txtSoDienThoai.Text.Trim();
                if (KH.DemKhachHang == 0)
                {
                    try
                    {
                        kh.InsertKhachHang(KH.TenKhachHang, KH.SoDienThoai);
                        MessageBox.Show("Da them thanh cong");
                    }
                    catch
                    {
                        txtSoDienThoai.Text = kh.KiemTraKhachHang(KH.SoDienThoai).Rows[0]["SoDienThoai"].ToString();
                        txtTenKhachHang.Text = kh.KiemTraKhachHang(KH.SoDienThoai).Rows[0]["TenKhachHang"].ToString();
                        MessageBox.Show("Khach hang da toi tai voi ten: " + txtTenKhachHang.Text);
                    }
                }
                else
                {
                    try
                    {
                        DialogResult drl = MessageBox.Show("Ban co muon doi khach hang", "Thong bao", MessageBoxButtons.YesNo);
                        if (drl == DialogResult.Yes)
                        {
                            kh.InsertKhachHang(KH.TenKhachHang, KH.SoDienThoai);
                            MessageBox.Show("Da doi thanh cong");
                        }
                    }
                    catch
                    {
                        txtSoDienThoai.Text = kh.KiemTraKhachHang(KH.SoDienThoai).Rows[0]["SoDienThoai"].ToString();
                        txtTenKhachHang.Text = kh.KiemTraKhachHang(KH.SoDienThoai).Rows[0]["TenKhachHang"].ToString();
                        MessageBox.Show("Khach hang da toi tai voi ten: " + txtTenKhachHang.Text);
                    }
                }
                KH.DemKhachHang = 1;
                KH.MaKhachHang = Int32.Parse(kh.KiemTraKhachHang(KH.SoDienThoai).Rows[0]["MaKhachHang"].ToString());
                DateTime tg = new DateTime();
                tg = DateTime.Today;
                GD.MaGiaoDich = gd.InsertGiaoDich();
                HD.MaHoaDon = hd.InsertHoaDon(GD.MaGiaoDich, KH.MaKhachHang, DangNhap.TenTaiKhoan.ToString(), tg);
                CTHD.MaHoaDon = HD.MaHoaDon;
                CTHD.MaChiTietHoaDon = 1;
            }
        }
            
    }
}
