using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChoNgoi
    {
        private int id;
        private string hang;
        private int so;
        private string maPhong;
        private int maKhachHang;

        public int Id { get => id; set => id = value; }
        public string Hang { get => hang; set => hang = value; }
        public int So { get => so; set => so = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public int MaKhachHang { get => maKhachHang; set => maKhachHang = value; }

        public ChoNgoi () { }

        public ChoNgoi (DataRow row)
        {
            Id = (int)row["Id"];
            Hang = row["Hang"].ToString();
            So = (int)row["So"];
            MaPhong = row["MaPhong"].ToString();
            MaKhachHang = (int)row["MaKhachHang"];
        }
    }
}
