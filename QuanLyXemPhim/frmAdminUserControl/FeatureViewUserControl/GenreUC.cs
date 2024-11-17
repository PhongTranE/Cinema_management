using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;

namespace QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl
{
    public partial class GenreUC : UserControl
    {
        BindingSource genreList = new BindingSource();

        public GenreUC()
        {
            InitializeComponent();
            dtgvGenre.DataSource = genreList;
            LoadGenre();
        }

        void LoadGenre()
        {
            TheLoaiBUS.Instance.hienThiTheLoaiPhim(genreList);
            AddGenreBinding();
        }
        void LoadGenreList()
        {
           
        }
        void AddGenreBinding()
        {
            txtGenreID.DataBindings.Add(new Binding("Text", dtgvGenre.DataSource, "MaLoaiPhim", true, DataSourceUpdateMode.Never));
            txtGenreName.DataBindings.Add(new Binding("Text", dtgvGenre.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
        }

        private void btnInsertGenre_Click_1(object sender, EventArgs e)
        {
            string MaLoaiPhim = txtGenreID.Text;
            string TenTheLoai = txtGenreName.Text;
            TheLoaiBUS.Instance.themTheLoai(MaLoaiPhim, TenTheLoai);
            TheLoaiBUS.Instance.hienThiTheLoaiPhim(genreList);
        }

        private void btnDeleteGenre_Click_1(object sender, EventArgs e)
        {
            string MaLoaiPhim = dtgvGenre.SelectedCells[0].OwningRow.Cells["MaLoaiPhim"].Value.ToString();
            TheLoaiBUS.Instance.xoaTheLoai(MaLoaiPhim);
            TheLoaiBUS.Instance.hienThiTheLoaiPhim(genreList);
        }

        private void btnUpdateGenre_Click_1(object sender, EventArgs e)
        {
            string MaLoaiPhim = dtgvGenre.SelectedCells[0].OwningRow.Cells["MaLoaiPhim"].Value.ToString();
            string TenTheLoai = txtGenreName.Text;
            TheLoaiBUS.Instance.suaTheLoai(MaLoaiPhim, TenTheLoai);
            TheLoaiBUS.Instance.hienThiTheLoaiPhim(genreList);
        }

        private void txtGenreID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
