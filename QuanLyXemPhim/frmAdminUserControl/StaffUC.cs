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

namespace QuanLyXemPhim.frmAdminUserControl
{
    public partial class StaffUC : UserControl
    {
        BindingSource staffList = new BindingSource();

        public StaffUC()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            DataTable dt = StaffBUS.Instance.getListStaff();
            if (dt == null)
            {
                MessageBox.Show("Error when load data");
            }
            else
            {
                dtgvStaff.DataSource = dt;
            }
        }


        private void resetPanel()
        {
            txtStaffId.Clear();
            txtStaffName.Clear();
            txtStaffAddress.Clear();
            txtStaffINumber.Clear();
            txtStaffPhone.Clear();
            dtpNgaySinh.Refresh();

        } 
      
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffId.Text == null || txtStaffName.Text == null || txtStaffINumber.Text == null )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }

            try
            {
                String id = txtStaffId.Text;
                String name = txtStaffName.Text;
                String address = txtStaffAddress.Text;

                DateTime birth = dtpNgaySinh.Value;

                String phone = txtStaffPhone.Text;
                int identity = Int32.Parse(txtStaffINumber.Text);

                if (StaffBUS.Instance.addStaff(id, name, birth, address, phone, identity))
                {
                    LoadStaff();
                    resetPanel();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK);
                }

            }
            catch
            {
                MessageBox.Show("Kiểm tra lại dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK);

            }



        }

        
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            
            if (txtStaffId.Text == "" || txtStaffName.Text == "" || txtStaffINumber.Text == "")
            {
                MessageBox.Show("Vui lòng cung cấp đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                String id = txtStaffId.Text;
                String name = txtStaffName.Text;
                DateTime birth = dtpNgaySinh.Value;
                String address = txtStaffAddress.Text;
                String phone = txtStaffPhone.Text;
                int number = Int32.Parse(txtStaffINumber.Text);

                if (StaffBUS.Instance.updateStaffBUS(id, name, birth, address, phone, number))
                {
                    LoadStaff();
                    resetPanel();
                }
                else
                {
                      MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }


        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string staffId = (String)txtStaffId.Text;
            if (staffId == "" || staffId == null)
            {
                MessageBox.Show("Chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // thực hiện xóa
            if (StaffBUS.Instance.deleteStaffBUS(staffId))
            {
                resetPanel();
                LoadStaff();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void dtgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvStaff.SelectedRows)
            {
              txtStaffId.Text = row.Cells[0].Value.ToString();
              txtStaffName.Text = row.Cells[1].Value.ToString();
              dtpNgaySinh.Value = (DateTime)row.Cells[2].Value;
              txtStaffAddress.Text = row.Cells[3].Value.ToString();
              txtStaffPhone.Text = row.Cells[4].Value.ToString();
              txtStaffINumber.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
