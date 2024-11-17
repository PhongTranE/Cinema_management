using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;

namespace QuanLyXemPhim
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
            hienThiPhimTheoNgay();
            //loadDataToComboboxShowTime();
        }
  
        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            hienThiPhimTheoNgay();
            //loadDataToComboboxShowTime();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Load lại form để cập nhật cơ sở dữ liệu
            this.OnLoad(null);
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cboFilmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienThiDanhSachCaChieuTheoTenPhim();
        }

        private void btn_ChonVe_Click(object sender, EventArgs e)
        {
            string maCaChieu = dtv_CaChieu.SelectedCells[0].OwningRow.Cells["MaCaChieu"].Value.ToString();
            frmTheatre frmTheatre = new frmTheatre(maCaChieu);
            frmTheatre.ShowDialog();
        }
        // Hiện thị danh sách các phim thỏa điều kiện ngày được người dùng chọn từ Datetimepicker
        public void hienThiPhimTheoNgay()
        {
            DateTime date = dtpThoiGian.Value;
            PhimBUS.Instance.hienThiPhimTheoNgay(cboFilmName, date);
        }


        public void hienThiDanhSachCaChieuTheoTenPhim()
        {
            string tenPhim = cboFilmName.Text;
            CaChieu_PhimBUS.Instance.hienThiDanhSachCaChieuTheoTenPhim(dtv_CaChieu,tenPhim);
        }

        private void dtv_CaChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
