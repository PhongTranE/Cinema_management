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
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get { if (instance == null) instance = new TaiKhoanBUS(); return TaiKhoanBUS.instance; }
            private set { TaiKhoanBUS.instance = value; }
        }
        public TaiKhoan xuLyDangNhap(string userName, string password)
        {
            return (TaiKhoanDAO.Instance.xuLyDangNhap(userName, password));
              
        }
        public void themDanhSachTaiKhoan(string UserName, string Pass, int LoaiTK, string idNV)
        {
            //try
            //{
            //    if (TaiKhoanDAO.Instance.themDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV) > 0)
            //    {
            //        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //}
            if (TaiKhoanDAO.Instance.themDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV) > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        public void suaDanhSachTaiKhoan(string UserName, string Pass, int LoaiTK, string idNV)
        {
            try
            {
                if (TaiKhoanDAO.Instance.suaDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV) > 0)
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

        public void hienThiTaiKhoan(BindingSource accountList)
        {
            accountList.DataSource = TaiKhoanDAO.Instance.hienThiTaiKhoan();
        }

        public void xoaDanhSachTaiKhoan(string idNV)
        {
            try
            {
                if (TaiKhoanDAO.Instance.xoaDanhSachTaiKhoan(idNV) > 0)
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
