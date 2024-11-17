using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    public partial class Cinema : UserControl
    {
        BindingSource cinemaList = new BindingSource();
        public Cinema()
        {
            InitializeComponent();
            dtgvCinema.DataSource = cinemaList;
            hienThiPhongChieu();
        }

        void hienThiPhongChieu()
        {
            PhongChieuBUS.Instance.hienThiPhongChieu(cinemaList);
            AddCinemaBinding();
        }

        void AddCinemaBinding()
        {
            txtCinemaID.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            txtCinemaName.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "TenPhong", true, DataSourceUpdateMode.Never));
            txtCinemaSeats.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "SoChoNgoi", true, DataSourceUpdateMode.Never));
            txtCinemaStatus.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            txtNumberOfRows.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "SoHangGhe", true, DataSourceUpdateMode.Never));
            txtSeatsPerRow.DataBindings.Add(new Binding("Text", dtgvCinema.DataSource, "SoGheMotHang", true, DataSourceUpdateMode.Never));
        }
        void LoadScreenTypeIntoComboBox(ComboBox cbo)
        {
            
        }
        private void txtCinemaID_TextChanged(object sender, EventArgs e)
        //Use this to bind data between dtgv and cbo because cbo can't be applied DataBindings normally
        {
            
        }

        private void btnInsertCinema_Click_1(object sender, EventArgs e)
        {
            string MaPhong = txtCinemaID.Text;
            string TenPhong = txtCinemaName.Text;
            int SoChoNgoi = Convert.ToInt32(txtCinemaSeats.Text);
            int TinhTrang = Convert.ToInt32(txtCinemaStatus.Text);
            int SoHangGhe = Convert.ToInt32(txtNumberOfRows.Text);
            int SoGheMotHang = Convert.ToInt32(txtNumberOfRows.Text);
            PhongChieuBUS.Instance.themPhongChieu(MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang);
            PhongChieuBUS.Instance.hienThiPhongChieu(cinemaList);
        }

        private void btnDeleteCinema_Click(object sender, EventArgs e)
        {
            string MaPhong = dtgvCinema.SelectedCells[0].OwningRow.Cells["MaPhong"].Value.ToString();
            PhongChieuBUS.Instance.xoaPhongChieu(MaPhong);
            PhongChieuBUS.Instance.hienThiPhongChieu(cinemaList);
        }

        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            string MaPhong = dtgvCinema.SelectedCells[0].OwningRow.Cells["MaPhong"].Value.ToString();
            string TenPhong = txtCinemaName.Text;
            int SoChoNgoi = Convert.ToInt32(txtCinemaSeats.Text);
            int TinhTrang = Convert.ToInt32(txtCinemaStatus.Text);
            int SoHangGhe = Convert.ToInt32(txtNumberOfRows.Text);
            int SoGheMotHang = Convert.ToInt32(txtNumberOfRows.Text);
            PhongChieuBUS.Instance.capNhatPhongChieu(MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang);
            PhongChieuBUS.Instance.hienThiPhongChieu(cinemaList);
        }

        private void dtgvCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCinemaName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
