using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaChieu_Phim
    {
        public CaChieu_Phim (string maCaChieu,string tenPhim, DateTime thoigianchieu,string maphong, int trangthai)
        {
            this.MaCaChieu = maCaChieu;
            this.TenPhim = tenPhim;
            this.ThoiGianChieu = thoigianchieu;
            this.TrangThai = trangthai;
            this.MaPhong = maphong;
        }

        public CaChieu_Phim(DataRow row)
        {
            MaCaChieu = row["MaCaChieu"].ToString();
            TenPhim = row["TenPhim"].ToString();
            ThoiGianChieu = (DateTime)row["ThoiGianChieu"];
            TrangThai = (int)row["TrangThai"];
            MaPhong = row["MaPhong"].ToString();
        }
        public string MaCaChieu { get; set; }
        public string TenPhim { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public int TrangThai { get; set; }
        public string MaPhong { get; set; }

    }
}
