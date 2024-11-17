using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanLoaiPhim
    {
        private string idPhim;
        private string idTheLoaiPhim;

        public string IdPhim { get => idPhim; set => idPhim = value; }
        public string IdTheLoaiPhim { get => idTheLoaiPhim; set => idTheLoaiPhim = value; }

        public PhanLoaiPhim() { }

        public PhanLoaiPhim(DataRow row)
        {
            IdPhim = row["idPhim"].ToString();
            IdTheLoaiPhim = row["idTheLoai"].ToString();
        }


    }
}
