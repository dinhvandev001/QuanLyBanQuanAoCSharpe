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
    public partial class QuanLyLoaiHangHoa : Form
    {
        public QuanLyLoaiHangHoa()
        {
            InitializeComponent();
        }
        LoaiHangHoa_DTO LHH = new LoaiHangHoa_DTO();
        LoaiHangHoa_BUS lhh = new LoaiHangHoa_BUS();
        private void QuanLyLoaiHangHoa_Load(object sender, EventArgs e)
        {
            //Load LoaiHangHoa
            dgvQuanLyLoaiHangHoa.DataSource = lhh.ShowLoaiHangHoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LHH.MaLoaiHangHoa = txtMaLoaiHangHoa.Text;
                LHH.TenLoaiHangHoa = txtTenLoaiHangHoa.Text;
                lhh.InsertLoaiHangHoa(LHH.MaLoaiHangHoa, LHH.TenLoaiHangHoa);
                dgvQuanLyLoaiHangHoa.DataSource = lhh.ShowLoaiHangHoa();
                MessageBox.Show("Them loai hang hoa thanh cong", "Thong bao");
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
                LHH.MaLoaiHangHoa = txtMaLoaiHangHoa.Text;
                LHH.TenLoaiHangHoa = txtTenLoaiHangHoa.Text;
                lhh.UpdateLoaiHangHoa(LHH.MaLoaiHangHoa, LHH.TenLoaiHangHoa);
                dgvQuanLyLoaiHangHoa.DataSource = lhh.ShowLoaiHangHoa();
                MessageBox.Show("Sua loai hang hoa thanh cong", "Thong bao");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                LHH.MaLoaiHangHoa = txtMaLoaiHangHoa.Text;
                lhh.DeleteLoaiHangHoa(LHH.MaLoaiHangHoa);
                dgvQuanLyLoaiHangHoa.DataSource = lhh.ShowLoaiHangHoa();
                MessageBox.Show("Xoa loai hang hoa thanh cong", "Thong bao");
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

        private void dgvQuanLyLoaiHangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaLoaiHangHoa.Text = dgvQuanLyLoaiHangHoa.Rows[dong].Cells[0].Value.ToString();
                txtTenLoaiHangHoa.Text = dgvQuanLyLoaiHangHoa.Rows[dong].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Co loi!");
            }
        }
    }
}
