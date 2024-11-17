using BUS;
using DAO;
using DTO;
using QuanLyXemPhim.frmAdminUserControl;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            DBSQLServerUtils con = new DBSQLServerUtils(userName, password);
            TaiKhoan taiKhoan = TaiKhoanBUS.Instance.xuLyDangNhap(userName, password);
            if (taiKhoan != null)
            {

                frmDashboard dashboard = new frmDashboard(taiKhoan);
                dashboard.ShowDialog();
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
