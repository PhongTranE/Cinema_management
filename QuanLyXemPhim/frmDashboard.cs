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

namespace QuanLyXemPhim
{
    public partial class frmDashboard : Form
    {
        private TaiKhoan taiKhoan;
        public frmDashboard(TaiKhoan taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            InitializeComponent();

            handleAccessPermissions(this.taiKhoan);
        }

        public void handleAccessPermissions(TaiKhoan taiKhoan)
        {
            lblAccountInfo.Text += taiKhoan.UserName;
            if (taiKhoan.LoaiTK != 1) // Admin
            {
                btnAdmin.Enabled = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin(); 
            frmAdmin.ShowDialog();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            frmStaff frmStaff = new frmStaff();
            frmStaff.ShowDialog();
        }
    }
}
