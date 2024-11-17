using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    public partial class ShowTimesUC : UserControl
    {
        BindingSource showtimeList = new BindingSource();
        public ShowTimesUC()
        {
            InitializeComponent();
            dtgvShowtime.DataSource = showtimeList;
            LoadCaChieu();
        }
        void LoadCaChieu()
        {
            CaChieuBUS.Instance.GetCaChieu(showtimeList);
            LoadmovieNameIntoComboBox();
            AddShowtimeBinding();
            
        }

        //add Binding 
        void AddShowtimeBinding()
        {
            txtShowtimeID.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "MaCaChieu", true, DataSourceUpdateMode.Never));
            dtmShowtimeDate.DataBindings.Add(new Binding("Value", dtgvShowtime.DataSource, "ThoiGianChieu", true, DataSourceUpdateMode.Never));
            dtmShowtimeTime.DataBindings.Add(new Binding("Value", dtgvShowtime.DataSource, "ThoiGianChieu", true, DataSourceUpdateMode.Never));
            dateTimeDay.DataBindings.Add(new Binding("Value", dtgvShowtime.DataSource, "ThoiGianKetThuc", true, DataSourceUpdateMode.Never));
            dateTimetimes.DataBindings.Add(new Binding("Value", dtgvShowtime.DataSource, "ThoiGianKetThuc", true, DataSourceUpdateMode.Never));
            txtTicketPrice_Showtime.DataBindings.Add(new Binding("Text", dtgvShowtime.DataSource, "GiaVe", true, DataSourceUpdateMode.Never));
        }
        void LoadmovieNameIntoComboBox()
        {
            cboMovieName_Showtime.DataSource = PhimDAO.GetPhim();
            cboMovieName_Showtime.DisplayMember = "MaPhim";
        }
        private void dtgvShowtime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboMovieName_Showtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMovieName_Showtime.SelectedIndex != -1)
            {
                Phim MovieSelecting = (Phim)cboMovieName_Showtime.SelectedItem;
                txtMovieName_Showtime.Text = MovieSelecting.TenPhim;
                cboCinemaID_Showtime.DataSource = null;
                cboCinemaID_Showtime.DataSource = PhongChieuDAO.Instance.hienThiPhongChieu();
                cboCinemaID_Showtime.DisplayMember = "TenPhong";
            }
        }

        private void btnInsertShowtime_Click(object sender, EventArgs e)
        {
            string maCaChieu = txtShowtimeID.Text;
            string maPhongChieu = ((PhongChieu)cboCinemaID_Showtime.SelectedItem).MaPhong;
            string maPhim = ((Phim)cboMovieName_Showtime.SelectedItem).MaPhim;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            DateTime time2 = new DateTime(dateTimeDay.Value.Year, dateTimeDay.Value.Month, dateTimeDay.Value.Day, dateTimetimes.Value.Hour, dateTimetimes.Value.Minute, dateTimetimes.Value.Second);
            float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            CaChieuBUS.Instance.themCaChieu(maCaChieu, time, time2, maPhongChieu, maPhim, ticketPrice);
            //Thêm vé
            CaChieuBUS.Instance.GetCaChieu(showtimeList);
            //LoadCaChieu();
        }

        private void btnDeleteShowtime_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            CaChieuBUS.Instance.xoaCaChieu(showtimeID);
            CaChieuBUS.Instance.GetCaChieu(showtimeList);
        }

        private void btnUpdateShowtime_Click(object sender, EventArgs e)
        {
            string maCaChieu = txtShowtimeID.Text;
            string maPhongChieu = ((PhongChieu)cboCinemaID_Showtime.SelectedItem).MaPhong;
            string maPhim = ((Phim)cboMovieName_Showtime.SelectedItem).MaPhim;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            DateTime time2 = new DateTime(dateTimeDay.Value.Year, dateTimeDay.Value.Month, dateTimeDay.Value.Day, dateTimetimes.Value.Hour, dateTimetimes.Value.Minute, dateTimetimes.Value.Second);
            float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            CaChieuBUS.Instance.suaCaChieu(maCaChieu, time, time2, maPhongChieu, maPhim, ticketPrice);
            CaChieuBUS.Instance.GetCaChieu(showtimeList);

        }
    }
}
