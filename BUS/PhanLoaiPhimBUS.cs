using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class PhanLoaiPhimBUS
    {
        private static PhanLoaiPhimBUS instance;
        public static PhanLoaiPhimBUS Instance
        {
            get { if (instance == null) instance = new PhanLoaiPhimBUS(); return PhanLoaiPhimBUS.instance; }
            private set { PhanLoaiPhimBUS.instance = value; }
        }
        public void xoaPhanLoaiPhim(string idMaPhim)
        {
            try
            {
                if (PhanLoaiPhimDAO.Instance.xoaPhanLoaiPhim(idMaPhim) > 0)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void themPhanLoaiPhim(string idMaPhim,string maLoaiPhim)
        {
            try
            {
                PhanLoaiPhimDAO.Instance.insertPhanLoaiPhim(idMaPhim, maLoaiPhim);
            }
            catch
            {
                MessageBox.Show("Error", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
