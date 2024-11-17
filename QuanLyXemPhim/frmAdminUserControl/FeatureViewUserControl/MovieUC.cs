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

namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    public partial class MovieUC : UserControl
    {
        BindingSource movieList = new BindingSource();

        public MovieUC()
        {
            InitializeComponent();
            dtgvMovie.DataSource = movieList;
            hienThiDanhSachPhim();
        }

        private void btnAddMovie_Click_1(object sender, EventArgs e)
        {
            string MaPhim = txtMovieID.Text;
            string TenPhim = txtMovieName.Text;
            string MoTa = txtMovieDesc.Text;
            double ThoiLuong = Convert.ToDouble(txtMovieLength.Text);
            DateTime NgayBatDau = dtmMovieStart.Value;
            DateTime NgayKetThuc = dtmMovieEnd.Value;
            string QuocGia = txtMovieCountry.Text;
            string DienVien = txtMovieActor.Text;
            int NamSX = Convert.ToInt32(numericUpDownPhim.Value);
            int GioiHanTuoi = Convert.ToInt32(txtMovieYearLimit.Text);

            PhimBUS.Instance.themDanhSachPhim(MaPhim, TenPhim, MoTa, ThoiLuong, NgayBatDau, NgayKetThuc,
                QuocGia, DienVien, NamSX,GioiHanTuoi);
            PhimBUS.Instance.hienThiPhim(movieList);
        }

        public void bindingMovie()
        {
            txtMovieID.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "MaPhim", true, DataSourceUpdateMode.Never));
            txtMovieName.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "TenPhim", true, DataSourceUpdateMode.Never));
            txtMovieDesc.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
            txtMovieLength.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "ThoiLuong", true, DataSourceUpdateMode.Never));
            dtmMovieStart.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "NgayKhoiChieu", true, DataSourceUpdateMode.Never));
            dtmMovieEnd.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "NgayKetThuc", true, DataSourceUpdateMode.Never));
            txtMovieCountry.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "QuocGia", true, DataSourceUpdateMode.Never));
            txtMovieActor.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "DaoDien", true, DataSourceUpdateMode.Never));
            txtMovieYearLimit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "GioiHanTuoi", true, DataSourceUpdateMode.Never));
            numericUpDownPhim.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "NamSX", true, DataSourceUpdateMode.Never));
            // them the loai vao checklist
            LoadGenreIntoCheckedList(clbMovieGenre);
        }
        
        public void hienThiDanhSachPhim()
        {
            PhimBUS.Instance.hienThiPhim(movieList);
            bindingMovie();
        }


        private void txtMovieID_TextChanged(object sender, EventArgs e)
        //Use to binding the CheckedListBox the loai phim
        {
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                clbMovieGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }
           //Demo
            List<TheLoai> listGenreOfMovie = TheLoaiDAO.layDanhSachTheLoaiBoiPhimID2(txtMovieID.Text);
            MessageBox.Show(listGenreOfMovie.ToString());
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                TheLoai theLoai = (TheLoai)clbMovieGenre.Items[i];
                foreach (TheLoai item in listGenreOfMovie)
                {
                    if (theLoai.MaLoaiPhim == item.MaLoaiPhim)
                    {
                        clbMovieGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }
            Phim movie = PhimDAO.layMaPhim(txtMovieID.Text);
            if (movie == null)
                return;

        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            string MaPhim = dtgvMovie.SelectedCells[0].OwningRow.Cells["MaPhim"].Value.ToString();
            string TenPhim = txtMovieName.Text;
            string MoTa = txtMovieDesc.Text;
            double ThoiLuong = Convert.ToDouble(txtMovieLength.Text);
            DateTime NgayBatDau = dtmMovieStart.Value;
            DateTime NgayKetThuc = dtmMovieEnd.Value;
            string QuocGia = txtMovieCountry.Text;
            string DienVien = txtMovieActor.Text;
            int NamSX = Convert.ToInt32(numericUpDownPhim.Value);
            int GioiHanTuoi = Convert.ToInt32(txtMovieYearLimit.Text);

         

            PhimBUS.Instance.suaDanhSachPhim(MaPhim, TenPhim, MoTa, ThoiLuong, NgayBatDau, NgayKetThuc,
                QuocGia, DienVien,NamSX, GioiHanTuoi);
            PhimBUS.Instance.hienThiPhim(movieList);
           
    }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            string MaPhim = dtgvMovie.SelectedCells[0].OwningRow.Cells["MaPhim"].Value.ToString();
            
            PhimBUS.Instance.xoaDanhSachPhim(MaPhim);
            PhimBUS.Instance.hienThiPhim(movieList);

        }
        void LoadGenreIntoCheckedList(CheckedListBox checkedList)
        {
            List<TheLoai> theloaiList = TheLoaiDAO.Instance.hienThiTheLoaiPhim();
            checkedList.DataSource = theloaiList;
            checkedList.DisplayMember = "TenTheLoai";
            
        }

        private void clbMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Demo
        private void dtgvMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                clbMovieGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }
            List<TheLoai> listGenreOfMovie = TheLoaiDAO.layDanhSachTheLoaiBoiPhimID2(txtMovieID.Text);
            
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                TheLoai theLoai = (TheLoai)clbMovieGenre.Items[i];
                foreach (TheLoai item in listGenreOfMovie)
                {
                    if (theLoai.MaLoaiPhim == item.MaLoaiPhim)
                    {
                        clbMovieGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }
            Phim movie = PhimDAO.layMaPhim(txtMovieID.Text);
            if (movie == null)
                return;
        }
    }
}
