using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class CaChieuBUS
    {
        private static CaChieuBUS instance;
        public static CaChieuBUS Instance
        {
            get { if (instance == null) instance = new CaChieuBUS(); return CaChieuBUS.instance; }
            private set { CaChieuBUS.instance = value; }
        }

        public void hienThiCaChieu(BindingSource source)
        {
            source.DataSource = CaChieuDAO.Instance.hienThiCaChieu();
        }

        public void hienThiThongTinChiTietLichChieu(int index, string tenPhim, ListView lv)
        {
           
        }
        public void GetCaChieu(BindingSource source)
        {
            source.DataSource = CaChieuDAO.Instance.GetCaChieu();
        }
        public void themCaChieu(string MaCaChieu, DateTime ThoiGianChieu, DateTime ThoiGianKetThuc, string MaPhong, string MaPhim, float GiaVe)
        {
            try
            {
                if (CaChieuDAO.Instance.themCaChieu(MaCaChieu, ThoiGianChieu, ThoiGianKetThuc, MaPhong, MaPhim, GiaVe) > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public void xoaCaChieu(string MaCaChieu)
        {
            try
            {
                if (CaChieuDAO.Instance.xoaCaChieu(MaCaChieu) > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public void suaCaChieu(string MaCaChieu, DateTime ThoiGianChieu, DateTime ThoiGianKetThuc, string MaPhong, string MaPhim, float GiaVe)
        {
            try
            {
                if (CaChieuDAO.Instance.suaCaChieu(MaCaChieu, ThoiGianChieu, ThoiGianKetThuc, MaPhong, MaPhim, GiaVe) > 0)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
