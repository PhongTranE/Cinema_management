using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CaChieu_PhimDAO
    {
        private static CaChieu_PhimDAO instance;
        public static CaChieu_PhimDAO Instance
        {
            get { if (instance == null) instance = new CaChieu_PhimDAO(); return CaChieu_PhimDAO.instance; }
            private set { CaChieu_PhimDAO.instance = value; }
        }
        public static List<CaChieu_Phim> GetCaChieuByTicket()
        {
            List<CaChieu_Phim> listcachieu = new List<CaChieu_Phim>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_layCaChieuTheoVe");
            foreach (DataRow row in data.Rows)
            {
                CaChieu_Phim showTimes = new CaChieu_Phim(row);
                listcachieu.Add(showTimes);
            }
            return listcachieu;
        }

        public List<CaChieu_Phim> hienThiDanhSachCaChieuTheoTenPhim(string tenPhim)
        {
            List<CaChieu_Phim> caChieus = new List<CaChieu_Phim>();
            string query = @"SELECT * FROM dbo.FUNC_layCaChieuTheoTenPhim( @TenPhim )";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { tenPhim });

            foreach (DataRow row in table.Rows)
            {
                CaChieu_Phim caChieu = new CaChieu_Phim(row);
                caChieus.Add(caChieu);
            }

            return caChieus;
        }
    }
}
