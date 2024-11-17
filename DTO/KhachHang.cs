using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private int maKH;
        private string tenKhachHang;
        private string diaChi;
        private int namSinh;
        private string soDienThoai;
        private string cmnd;
        private int diemTichLuy;

        public int MaKH { get => maKH; set => maKH = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }

        public KhachHang() { }

        public KhachHang(DataRow row) 
        {
            MaKH = (int)row["MaKH"];
            TenKhachHang = row["TenKhachHang"].ToString();
            DiaChi = row["Diachi"].ToString();
            NamSinh = (int)row["NamSinh"];
            SoDienThoai = row["SoDienThoai"].ToString();
            Cmnd = row["CMND"].ToString();
            DiemTichLuy = (int)row["DiemTichLuy "];
        }
    }
}
