using QuanLyXemPhim.frmAdminUserControl.FeatureViewUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXemPhim.frmAdminUserControl
{
    public partial class FeatureViewUC : UserControl
    {
        const int  Y = 110;
        public FeatureViewUC()
        {
            InitializeComponent();
            SidePanel.Hide();
        }
        private void btnCinema_Click(object sender, EventArgs e)
        {
            Cinema cinema = new Cinema();
            pnData.Controls.Clear();
            pnData.Controls.Add(cinema);
        }

        private void btnGenreUC_Click(object sender, EventArgs e)
        {
            GenreUC genreUC = new GenreUC();
            pnData.Controls.Clear();
            pnData.Controls.Add(genreUC);
        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {
            MovieUC movieUC = new MovieUC();
            pnData.Controls.Clear();
            pnData.Controls.Add(movieUC);
        }



        private void btnShowTimesUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnShowTimesUC.Height;
            SidePanel.Top = btnShowTimesUC.Top;
            pnData.Controls.Clear();
            ShowTimesUC showTimesUc = new ShowTimesUC();
            showTimesUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(showTimesUc);
        }

        private void btnTicketsUC_Click(object sender, EventArgs e)
        {   
            TicketsUC ticketsUC = new TicketsUC();
            pnData.Controls.Clear();
            pnData.Controls.Add(ticketsUC);
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
