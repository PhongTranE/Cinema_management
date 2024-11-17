using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class CaChieu_PhimBUS
    {
        private static CaChieu_PhimBUS instance;
        public static CaChieu_PhimBUS Instance
        {
            get { if (instance == null) instance = new CaChieu_PhimBUS(); return CaChieu_PhimBUS.instance; }
            private set { CaChieu_PhimBUS.instance = value; }
        }

        public void hienThiDanhSachCaChieuTheoTenPhim(DataGridView dtv, string tenPhim)
        {
            dtv.DataSource = CaChieu_PhimDAO.Instance.hienThiDanhSachCaChieuTheoTenPhim(tenPhim);
            dtv.Columns["TrangThai"].Visible = false;
            //MessageBox.Show(caChieus.Count.ToString());
        }
    }
}
