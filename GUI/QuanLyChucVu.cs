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
    public partial class QuanLyChucVu : Form
    {
        public QuanLyChucVu()
        {
            InitializeComponent();
        }
        ChucVu_DTO CV = new ChucVu_DTO();
        ChucVu_BUS cv = new ChucVu_BUS();

        private void QuanLyChucVu_Load(object sender, EventArgs e)
        {
            //Load ChucVu
            dgvQuanLyChucVu.DataSource = cv.ShowChucVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CV.MaChucVu = txtMaChucVu.Text;
                CV.TenChucVu = txtTenChucVu.Text;
                cv.InsertChucVu(CV.MaChucVu, CV.TenChucVu);
                dgvQuanLyChucVu.DataSource = cv.ShowChucVu();
                MessageBox.Show("Them chuc vu thanh cong", "Thong bao");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            try
            {
                CV.MaChucVu = txtMaChucVu.Text;
                cv.DeleteChucVu(CV.MaChucVu);
                dgvQuanLyChucVu.DataSource = cv.ShowChucVu();
                MessageBox.Show("Xoa chuc vu thanh cong", "Thong bao");
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
                CV.MaChucVu = txtMaChucVu.Text;
                CV.TenChucVu = txtTenChucVu.Text;
                cv.UpdateChucVu(CV.MaChucVu, CV.TenChucVu);
                dgvQuanLyChucVu.DataSource = cv.ShowChucVu();
                MessageBox.Show("Sua chuc vu thanh cong", "Thong bao");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void dgvQuanLyChucVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaChucVu.Text = dgvQuanLyChucVu.Rows[dong].Cells[0].Value.ToString();
                txtTenChucVu.Text = dgvQuanLyChucVu.Rows[dong].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Co loi!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
