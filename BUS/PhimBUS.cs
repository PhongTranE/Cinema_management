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
    public class PhimBUS
    {
        private static PhimBUS instance;
        public static PhimBUS Instance
        {
            get { if (instance == null) instance = new PhimBUS(); return PhimBUS.instance; }
            private set { PhimBUS.instance = value; }
        }
        
        public void hienThiPhim(BindingSource source)
        {
            source.DataSource = PhimDAO.Instance.hienThiPhim();
        }

        public void hienThiPhimTheoNgay (ComboBox cbb,DateTime date)
        {
            List<Phim> danhSachPhim = PhimDAO.Instance.hienThiPhimTheoNgay(date);
            List<string> danhSachTenPhim = new List<string>();

            // Fix lỗi hiện nhiều tên phim trùng nhau
            foreach (Phim tenPhim in danhSachPhim)
            {
                if(!danhSachTenPhim.Contains(tenPhim.TenPhim))
                {
                    danhSachTenPhim.Add(tenPhim.TenPhim);
                }
            }

            cbb.DataSource = null;
            cbb.DataSource = danhSachTenPhim;
        }

        public void suaDanhSachPhim(string MaPhim, string TenPhim, string MoTa, double ThoiLuong,
            DateTime NgayBatDau, DateTime NgayKetThuc, string QuocGia, string DienVien, int NamSX, int GioiHanTuoi)
        {
            try
            {
                if (PhimDAO.Instance.suaDanhSachPhim(MaPhim, TenPhim, MoTa, ThoiLuong, NgayBatDau,
                    NgayKetThuc, QuocGia, DienVien, NamSX, GioiHanTuoi) > 0)
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
        public void themDanhSachPhim(string MaPhim, string TenPhim, string MoTa, double ThoiLuong,
    DateTime NgayBatDau, DateTime NgayKetThuc, string QuocGia, string DienVien, int NamSX, int GioiHanTuoi)
        {
            try
            {
                if (PhimDAO.Instance.themDanhSachPhim(MaPhim, TenPhim, MoTa, ThoiLuong, NgayBatDau,
                    NgayKetThuc, QuocGia, DienVien, NamSX, GioiHanTuoi) > 0)
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
        public void xoaDanhSachPhim(string MaPhim)
        {
            try
            {
                if (PhimDAO.Instance.xoaDanhSachPhim(MaPhim) > 0)
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

    }
}
