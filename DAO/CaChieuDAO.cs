using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class CaChieuDAO
    {
        private static CaChieuDAO instance;
        public static CaChieuDAO Instance
        {
            get { if (instance == null) instance = new CaChieuDAO(); return CaChieuDAO.instance; }
            private set { CaChieuDAO.instance = value; }
        }

        public List<CaChieu> hienThiCaChieu()
        {
            List<CaChieu> caChieus = new List<CaChieu>();
            string query = @"USP_layDanhSachCaChieu";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                CaChieu caChieu = new CaChieu(row);
                caChieus.Add(caChieu);
            }

            return caChieus;
        }

        public DataTable GetCaChieu()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_layDanhSachCaChieu");
        }
        public int themCaChieu(string MaCaChieu, DateTime ThoiGianChieu, DateTime ThoiGianKetThuc, string MaPhong, string MaPhim, float GiaVe)
        {
            try
            {
                string query = @"USP_themCaChieu @MaCaChieu , @ThoiGianChieu , @ThoiGianKetThuc , @MaPhong , @MaPhim , @GiaVe ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu, ThoiGianChieu, ThoiGianKetThuc, MaPhong, MaPhim, GiaVe });
                return kq;
            }
            catch
            {
                return 0;
            }

        }
        public int xoaCaChieu(string MaCaChieu)
        {
            try
            {
                string query = @"USP_xoaCaChieu @MaCaChieu ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu });
                return kq;
            }
            catch
            {
                return 0;
            }
        }

        public int suaCaChieu(string MaCaChieu, DateTime ThoiGianChieu, DateTime ThoiGianKetThuc, string MaPhong, string MaPhim, float GiaVe)
        {
            try
            {
                string query = @"USP_capNhatCaChieu @MaCaChieu , @ThoiGianChieu , @ThoiGianKetThuc , @MaPhong , @MaPhim , @GiaVe ";
                int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu, ThoiGianChieu, ThoiGianKetThuc, MaPhong, MaPhim, GiaVe });
                return kq;
            }
            catch
            {
                return 0;
            }
        }
        public static int updateTinhTrangCaChieu(string MaCaChieu, int TinhTrang)
        {
            string query = "USP_capNhatTinhTrangCaChieu @MaCaChieu , @TinhTrang";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaCaChieu, TinhTrang });
        }
    }
}
