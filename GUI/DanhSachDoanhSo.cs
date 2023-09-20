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
    public partial class DanhSachDoanhSo : Form
    {
        public DanhSachDoanhSo()
        {
            InitializeComponent();
        }
        DoanhSo_DTO DS = new DoanhSo_DTO();
        DoanhSo_BUS ds = new DoanhSo_BUS();
        private void DanhSachDoanhSo_Load(object sender, EventArgs e)
        {
            try
            {
                //Load DoanhSo
                dgvDanhSachDoanhSo.DataSource = ds.ShowDoanhSo();
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
