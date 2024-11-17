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
using DTO;

namespace QuanLyXemPhim
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void Re_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int birth = Int32.Parse(txtBirth.Text);
            string phoneNumber = txtPhoneNumber.Text.Trim();
            int point = 0;
            string address = txtAddress.Text;
            if (CustomerBUS.Instance.addCustomer(name, birth, phoneNumber, point, address))
            {
                MessageBox.Show("Thêm thành viên thành công");
            }
        }
    }
}
