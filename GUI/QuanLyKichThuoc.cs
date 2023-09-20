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
    public partial class QuanLyKichThuoc : Form
    {
        public QuanLyKichThuoc()
        {
            InitializeComponent();
        }
        KichThuoc_DTO KT = new KichThuoc_DTO();
        KichThuoc_BUS kt = new KichThuoc_BUS();
        private void QuanLyKichThuoc_Load(object sender, EventArgs e)
        {
            //Load KichThuoc
            dgvQuanLyKichThuoc.DataSource = kt.ShowKichThuoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KT.KichThuoc = Int32.Parse(txtKichThuoc.Text);
                kt.InsertKichThuoc(KT.KichThuoc);
                dgvQuanLyKichThuoc.DataSource = kt.ShowKichThuoc();
                MessageBox.Show("Them kich thuoc thanh cong", "Thong bao");
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
                KT.KichThuoc = Int32.Parse(txtKichThuoc.Text);
                kt.DeleteKichThuoc(KT.KichThuoc);
                dgvQuanLyKichThuoc.DataSource = kt.ShowKichThuoc();
                MessageBox.Show("Xoa kich thuoc thanh cong", "Thong bao");
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

        private void dgvQuanLyKichThuoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtKichThuoc.Text = dgvQuanLyKichThuoc.Rows[dong].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Co loi!");
            }
        }
    }
}
