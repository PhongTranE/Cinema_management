using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }

        public List<TaiKhoan> hienThiTaiKhoan()
        {
            List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();
            string query = @"USP_hienDanhSachTaiKhoan";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
               TaiKhoan taikhoan = new TaiKhoan(row);
                danhSachTaiKhoan.Add(taikhoan);
            }
            return danhSachTaiKhoan;
            //DataTable data = DataProvider.Instance.ExecuteQuery(query);
            //return new TaiKhoan(table.Rows[0]);

        }

        public TaiKhoan xuLyDangNhap(string userName, string password)
        {
            string query = @"USP_dangNhap @userName , @pass ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password });
            if (table.Rows.Count > 0)
            {
                TaiKhoan taiKhoan = new TaiKhoan(table.Rows[0]);
                return taiKhoan;
            }
            return null;
        }
        public int themDanhSachTaiKhoan(string UserName, string Pass, int LoaiTK, string idNV)
        {
            //try
            //{
            //    string query = @"USP_themDanhSachTaiKhoan @UserName , @Pass , @LoaiTK , @idNV ";
            //    //USP_Add_Account @UserName , @Pass , @LoaiTK , @idNV
            //    int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { UserName, Pass, LoaiTK, idNV });
            //    return kq;
            //}
            //catch
            //{
            //    return 0;
            //}
            string query = @"USP_themDanhSachTaiKhoan @UserName , @Pass , @LoaiTK , @idNV ";
            //USP_Add_Account @UserName , @Pass , @LoaiTK , @idNV
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { UserName, Pass, LoaiTK, idNV });
            return kq;
        }
        public int suaDanhSachTaiKhoan(string UserName, string Pass, int LoaiTK, string idNV)
        {
            try
            {
                string query = @"USP_suaDanhSachTaiKhoan @UserName , @Pass , @LoaiTK , @idNV ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { UserName, Pass, LoaiTK, idNV });
                return kq;
            }
            catch
            {
                return 0;
            }
        }
        public int xoaDanhSachTaiKhoan(string idNV)
        {
            try
            {
                string query = @"USP_xoaDanhSachTaiKhoan @idNV ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idNV });
                return kq;
            }
            catch
            {
                return 0;
            }
        }
        

    }
}
