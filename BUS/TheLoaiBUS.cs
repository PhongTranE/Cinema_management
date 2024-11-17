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
    public class TheLoaiBUS
    {
        private static TheLoaiBUS instance;
        public static TheLoaiBUS Instance
        {
            get { if (instance == null) instance = new TheLoaiBUS(); return TheLoaiBUS.instance; }
            private set { TheLoaiBUS.instance = value; }
        }

        public void hienThiTheLoaiPhim(BindingSource source)
        {
            source.DataSource = TheLoaiDAO.Instance.hienThiTheLoaiPhim();
        }

        public void themTheLoai(string MaLoaiPhim, string TenTheLoai)
        {
            try
            {
                if (TheLoaiDAO.Instance.themTheLoai(MaLoaiPhim, TenTheLoai)> 0)
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

        public void xoaTheLoai(string MaLoaiPhim)
        {
            try
            {
                if (TheLoaiDAO.Instance.xoaTheLoai(MaLoaiPhim) > 0)
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

        public void suaTheLoai(string MaLoaiPhim, string TenTheLoai)
        {
            try
            {
                if (TheLoaiDAO.Instance.suaTheLoai(MaLoaiPhim, TenTheLoai) > 0)
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
