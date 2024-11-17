using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhanLoaiPhimDAO
    {
        private static PhanLoaiPhimDAO instance;
        public static PhanLoaiPhimDAO Instance
        {
            get { if (instance == null) instance = new PhanLoaiPhimDAO(); return PhanLoaiPhimDAO.instance; }
            private set { PhanLoaiPhimDAO.instance = value; }
        }
        public int xoaPhanLoaiPhim(string idPhim)
        {
            try
            {
                string query = @"xoaPhanLoaiPhim @maPhim";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idPhim });
                return kq;
            }
            catch
            {
                return 0;
            }
        }


        public int insertPhanLoaiPhim(string idPhim,string maLoaiPhim)
        {
            try
            {
                string query = @"insertPhanLoaiPhim @maPhim, @maLoaiPhim";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idPhim , maLoaiPhim});
                return kq;
            }
            catch
            {
                return 0;
            }
        }

    }
}
