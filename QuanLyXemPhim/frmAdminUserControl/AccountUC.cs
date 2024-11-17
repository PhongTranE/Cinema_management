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

namespace QuanLyXemPhim.frmAdminUserControl
{
    public partial class AccountUC : UserControl
    {
        BindingSource accountList = new BindingSource();

        public AccountUC()
        {
            InitializeComponent();
            dtgvAccount.DataSource = accountList;
            LoadAccount();
        }
        void LoadAccount()
        {
            TaiKhoanBUS.Instance.hienThiTaiKhoan(accountList);
            bindingTaiKhoang();
        }
        void LoadAccountList()
        {
            
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }
        public void bindingTaiKhoang()
        {
            txtUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txt_Pass.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Pass", true, DataSourceUpdateMode.Never));
            nudAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
            txt_idNV.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "idNV", true, DataSourceUpdateMode.Never));
        }
        private void btnInsertAccount_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Pass = txt_Pass.Text;
            int LoaiTK = Convert.ToInt32(nudAccountType.Text);
            string idNV = txt_idNV.Text;            
            TaiKhoanBUS.Instance.themDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV);
            TaiKhoanBUS.Instance.hienThiTaiKhoan(accountList);
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Pass = txt_Pass.Text;
            int LoaiTK = Convert.ToInt32(nudAccountType.Text);
            string idNV = txt_idNV.Text;
            TaiKhoanBUS.Instance.suaDanhSachTaiKhoan(UserName, Pass, LoaiTK, idNV);
            TaiKhoanBUS.Instance.hienThiTaiKhoan(accountList);
        }

        
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string idNV = dtgvAccount.SelectedCells[0].OwningRow.Cells["idNV"].Value.ToString();
            TaiKhoanBUS.Instance.xoaDanhSachTaiKhoan(idNV);
            TaiKhoanBUS.Instance.hienThiTaiKhoan(accountList);
        }

        private void Show_MK_CheckedChanged(object sender, EventArgs e)
        {
            if(Show_MK.Checked)
            {
                txt_Pass.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
        }
    }
}
