using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;
using DAL;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        Data data = new Data();
        TaiKhoan_DTO TaiKhoan = new TaiKhoan_DTO();
        public int DoiMatKhau(string ttk, string mkc, string mkm, string xnmk)
        {
            string sql = "select * from NhanVien WHERE MaNhanVien = '" + ttk + "' AND MatKhau = '" + mkc + "'";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);
            int KiemTra = dt.Rows.Count;
            if (KiemTra == 0)
            {
                MessageBox.Show("Mat khau cu sai!", "Thong bao");
                return 0;
            }
            else if (KiemTra == 1)
            {
                if (mkm == xnmk)
                {
                    string sql2 = "UPDATE NhanVien SET MatKhau = '" + mkm + "' WHERE MaNhanVien = '" + ttk + "' AND MatKhau = '" + mkc + "'";
                    data.ExcuteNonQuery(sql2);
                    MessageBox.Show("Doi mat khau thanh cong", "Thong bao");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Xac nhan mat khau sai!", "Thong bao");
                    return 2;
                }
            }
            else
            {
                MessageBox.Show("Loi!");
                return 0;
            }
        }   
    }
}
