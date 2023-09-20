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
    public partial class QuanLyHangTrongKho : Form
    {
        public QuanLyHangTrongKho()
        {
            InitializeComponent();
        }
        HangHoa_DTO HH = new HangHoa_DTO();
        HangHoa_BUS hh = new HangHoa_BUS();
        private void QuanLyHangTrongKho_Load(object sender, EventArgs e)
        {
            dgvQuanLyHangHoa.DataSource = hh.ShowHangHoa();
        }

        private void dgvQuanLyHangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaHangHoa.Text = dgvQuanLyHangHoa.Rows[dong].Cells[0].Value.ToString();
            txtKichThuoc.Text = dgvQuanLyHangHoa.Rows[dong].Cells[1].Value.ToString();
            txtGiaNhap.Text = dgvQuanLyHangHoa.Rows[dong].Cells[2].Value.ToString();
            txtTenHangHoa.Text = dgvQuanLyHangHoa.Rows[dong].Cells[3].Value.ToString();
            txtMaLoaiHangHoa.Text = dgvQuanLyHangHoa.Rows[dong].Cells[4].Value.ToString();
            txtGiaBan.Text = dgvQuanLyHangHoa.Rows[dong].Cells[5].Value.ToString();
            txtSoLuong.Text = dgvQuanLyHangHoa.Rows[dong].Cells[6].Value.ToString();
            txtGhiChu.Text = dgvQuanLyHangHoa.Rows[dong].Cells[7].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HH.MaHangHoa = txtMaHangHoa.Text;
            HH.KichThuoc = Int32.Parse(txtKichThuoc.Text);
            HH.GiaNhap = float.Parse(txtGiaNhap.Text);
            HH.TenHangHoa = txtTenHangHoa.Text;
            HH.GiaBan = float.Parse(txtGiaBan.Text);
            HH.GhiChu = txtGhiChu.Text;
            hh.UpdateHangHoa(HH.MaHangHoa, HH.KichThuoc, HH.GiaNhap, HH.TenHangHoa, HH.GiaBan, HH.GhiChu);
            MessageBox.Show("Da sua thanh cong", "Thong bao");
            dgvQuanLyHangHoa.DataSource = hh.ShowHangHoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
