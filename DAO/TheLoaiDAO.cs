using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiDAO
    {
        private static TheLoaiDAO instance;
        public static TheLoaiDAO Instance
        {
            get { if (instance == null) instance = new TheLoaiDAO(); return TheLoaiDAO.instance; }
            private set { TheLoaiDAO.instance = value; }
        }

        public List<TheLoai> hienThiTheLoaiPhim()
        {
            List<TheLoai> theLoais = new List<TheLoai>();
            string query = @"USP_hienThiTheLoaiPhim";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                TheLoai theLoai = new TheLoai(row);
                theLoais.Add(theLoai);
            }

            return theLoais;
        }


        public int themTheLoai(string MaLoaiPhim, string TenTheLoai)
        {
            try
            {
                string query = @"USP_themTheLoaiPhim @MaLoaiPhim , @TenTheLoai ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLoaiPhim, TenTheLoai });
                return kq;
            }
            catch
            {
                return 0;
            }
        }

        public int xoaTheLoai(string MaLoaiPhim)
        {
            try
            {
                string query = @"USP_xoaTheLoaiPhim @MaLoaiPhim ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLoaiPhim});
                return kq;
            }
            catch
            {
                return 0;
            }
        }

        public int suaTheLoai(string MaLoaiPhim, string TenTheLoai)
        {
            try
            {
                string query = @"USP_suaTheLoaiPhim @MaLoaiPhim , @TenTheLoai ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaLoaiPhim, TenTheLoai });
                return kq;
            }
            catch
            {
                return 0;
            }
        }
        //// hien thi the loai boi phim id
        public static List<TheLoai> layDanhSachTheLoaiBoiPhimID(string MaPhim)
        {
            List<TheLoai> theloaiList = new List<TheLoai>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_layTheLoaiBoiPhim @MaPhim", new object[] { MaPhim });
            foreach (DataRow item in data.Rows)
            {
                TheLoai genre = new TheLoai(item);
                theloaiList.Add(genre);
            }
            return theloaiList;
        }

        //Demo
        public static List<TheLoai> layDanhSachTheLoaiBoiPhimID2(string MaPhim)
        {
            List<TheLoai> theloaiList = new List<TheLoai>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC layTheLoai @MaPhim", new object[] { MaPhim  });
            foreach (DataRow item in data.Rows)
            {
                TheLoai genre = new TheLoai(item);
                theloaiList.Add(genre);
            }
            return theloaiList;
        }
    }
}
