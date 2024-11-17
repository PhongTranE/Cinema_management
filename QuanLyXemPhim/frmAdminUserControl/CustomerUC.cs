using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;

namespace QuanLyXemPhim.frmAdminUserControl
{
    public partial class CustomerUC : UserControl
    {
        BindingSource customerList = new BindingSource();
        public CustomerUC()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {

            DataTable dt = CustomerBUS.Instance.getListCustomer();
            if (dt == null)
            {
                MessageBox.Show("Error when load data");
            }
            else
            {
                dtgvCustomer.DataSource = dt;
            }
           
        }
  
        
        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {

            if (txtCusName.Text == "" || txtCusPhone.Text=="" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }
            
            String name = txtCusName.Text;
            int birth = Convert.ToInt32(numericUpDownNamSinh.Value);
            String phoneNumber = txtCusPhone.Text;
            int point = (int)nudPoint.Value;
            String address = txtAddress.Text;

            if (CustomerBUS.Instance.addCustomer(name, birth, phoneNumber, point, address))
            {
                LoadCustomer();
                clearCustomerInfoPanel();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }


        private void clearCustomerInfoPanel()
        {
            txtCusName.Clear();
            txtAddress.Clear();
          
            txtCusPhone.Clear();
            nudPoint.Value = 0;
            txtCusId.Clear();
        }
        private void dtgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            
            foreach(DataGridViewRow row in dtgvCustomer.SelectedRows)
            {                 
                txtCusId.Text = row.Cells[0].Value.ToString();
                txtCusName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                numericUpDownNamSinh.Text = row.Cells[3].Value.ToString();
                txtCusPhone.Text = row.Cells[4].Value.ToString();
                nudPoint.Value = (int)row.Cells[5].Value;
            }
           
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            String MaKH = txtCusId.Text;
            if (MaKH == "")
            {
                MessageBox.Show("Chọn người cần xóa", "Thông báo", MessageBoxButtons.OKCancel);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Bạn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (CustomerBUS.Instance.deleteCustomer(Int32.Parse(MaKH)))
                    {
                        LoadCustomer();
                        clearCustomerInfoPanel();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel);
                    }
                }
                else
                {
                    clearCustomerInfoPanel();
                }
            }
                
        }

        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text == "" || txtCusPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }

            int id = Int32.Parse(txtCusId.Text);
            String name = txtCusName.Text;
            String address = txtAddress.Text;
            int birth = Convert.ToInt32(numericUpDownNamSinh.Value);
            String phoneNumber = txtCusPhone.Text;
            int point = (int)nudPoint.Value;

            if (CustomerBUS.Instance.updateCustomerBUS(id,name, address, birth, phoneNumber, point))
            {
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OKCancel);
            }
            
        }
    }
}
