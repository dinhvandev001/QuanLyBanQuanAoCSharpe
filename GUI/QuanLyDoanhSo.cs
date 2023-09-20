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
    public partial class QuanLyDoanhSo : Form
    {
        public QuanLyDoanhSo()
        {
            InitializeComponent();
        }
        DoanhSo_DTO DS = new DoanhSo_DTO();
        DoanhSo_BUS ds = new DoanhSo_BUS();
        GiaoDich_DTO GD = new GiaoDich_DTO();
        GiaoDich_BUS gd = new GiaoDich_BUS();
        private void QuanLyDoanhSo_Load(object sender, EventArgs e)
        {
            try
            {
                DS.MaGiaoDich = Int32.Parse(ds.TimDoanhSoGanNhat().Rows[0]["MaGiaoDich"].ToString());
                DS.VonBanDau = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["VonBanDau"].ToString());
                DS.VonHienTai = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["VonHienTai"].ToString());
                DS.DoanhSo = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["DoanhSo"].ToString());
                txtVonBanDau.Text = string.Format("{0:0,0}", decimal.Parse(DS.VonBanDau.ToString()));
                txtVonHienTai.Text = string.Format("{0:0,0}", decimal.Parse(DS.VonHienTai.ToString()));
                txtDoanhSo.Text = string.Format("{0:0,0}", decimal.Parse(DS.DoanhSo.ToString()));
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnThemVonBanDau_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Ban co chac muon them von khong!", "Thong bao", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    DS.VonBanDau = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["VonBanDau"].ToString());
                    DS.VonHienTai = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["VonHienTai"].ToString());
                    DS.DoanhSo = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["DoanhSo"].ToString());
                    float stt = float.Parse(txtSoTienThem.Text);
                    DS.VonBanDau = DS.VonBanDau + stt;
                    DS.VonHienTai = DS.VonHienTai + stt;
                    DS.MaGiaoDich = gd.InsertGiaoDich();
                    ds.InsertDoanhSo(DS.MaGiaoDich, DS.VonBanDau, DS.VonHienTai);
                    string noiDung = "Them von ban dau";
                    gd.UpdateGiaoDich(DS.MaGiaoDich, stt, noiDung);
                    MessageBox.Show("Them von thanh cong", "Thong bao");
                    QuanLyDoanhSo_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Loi!");
                }
            }
        }

        private void btnRutVonHienTai_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Ban co chac muon rut von khong!", "Thong bao", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    DS.VonBanDau = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["VonBanDau"].ToString());
                    DS.VonHienTai = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["VonHienTai"].ToString());
                    DS.DoanhSo = float.Parse(ds.TimDoanhSoGanNhat().Rows[0]["DoanhSo"].ToString());
                    float str = float.Parse(txtSoTienRut.Text);
                    DS.VonHienTai = DS.VonHienTai - str;
                    DS.MaGiaoDich = gd.InsertGiaoDich();
                    ds.InsertDoanhSo(DS.MaGiaoDich, DS.VonBanDau, DS.VonHienTai);
                    string noiDung = "Rut von hien tai";
                    gd.UpdateGiaoDich(DS.MaGiaoDich, str, noiDung);
                    MessageBox.Show("Rut von thanh cong", "Thong bao");
                    QuanLyDoanhSo_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Loi!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
