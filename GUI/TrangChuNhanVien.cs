using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChuNhanVien : Form
    {
        public TrangChuNhanVien()
        {
            InitializeComponent();
        }

        private void TrangChuNhanVien_Load(object sender, EventArgs e)
        {
            lbTenTaiKhoan.Text = "Tai khoan: " + DangNhap.TenTaiKhoan.ToString();
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BanHang();
            form.ShowDialog();
        }

        private void hoSoNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HoSoNhanVien();
            form.ShowDialog();
        }

        private void luongNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new LuongNhanVien();
            form.ShowDialog();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
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
                this.Close();
            }
        }
    }
}
