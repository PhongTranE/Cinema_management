using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhongChieuBUS
    {
        private static PhongChieuBUS instance;
        public static PhongChieuBUS Instance
        {
            get { if (instance == null) instance = new PhongChieuBUS(); return PhongChieuBUS.instance; }
            private set { PhongChieuBUS.instance = value; }
        }

        public void hienThiPhongChieu(BindingSource source)
        {
            source.DataSource = PhongChieuDAO.Instance.hienThiPhongChieu();
        }

        public void themPhongChieu(string MaPhong, string TenPhong, int SoChoNgoi, int TinhTrang, int SoHangGhe, int SoGheMotHang)
        {
            try
            {
                if ( PhongChieuDAO.Instance.themPhongChieu(MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang) > 0)
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

        public void xoaPhongChieu(string MaPhong)
        {
            try
            {
                if (PhongChieuDAO.Instance.xoaPhongChieu(MaPhong) > 0)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void capNhatPhongChieu(string MaPhong, string TenPhong, int SoChoNgoi, int TinhTrang, int SoHangGhe, int SoGheMotHang)
        {
            try
            {
                if (PhongChieuDAO.Instance.capNhatPhongChieu(MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
