using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string idNV;
        private string hoTen;
        private DateTime ngaySinh;
        private string diaChi;
        private string sdt;
        private int cmnd;

        public string IdNV { get => idNV; set => idNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Cmnd { get => cmnd; set => cmnd = value; }

        public NhanVien() { }

        public NhanVien(DataRow row)
        {
            IdNV = row["idNVidNV"].ToString();
            HoTen = row["HoTen"].ToString();
            NgaySinh = (DateTime)row["NgaySinh"];
            DiaChi = row["DiaChi"].ToString();
            Sdt = row["SDT"].ToString();
            Cmnd = (int)row["CMND"];
        }
    }
}
