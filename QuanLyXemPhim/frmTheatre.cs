using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXemPhim
{
    public partial class frmTheatre : Form
    {
        private string maCaChieu;
        private static List<Ve> maVe = new List<Ve>();
        private static float totalPrice = 0;
        private static float finalPrice = 0;
        private static int bonus = 0;


        public frmTheatre(string maCaChieu)
        {
            InitializeComponent();
            this.maCaChieu = maCaChieu;
            hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
        }

        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(this);
            frmCustomer.ShowDialog();
        }

        public void hienThiDanhSachChoNgoiTheoMaCaChieu(string maCaChieu)
        {
            int count = 0;
            List<Ve> danhSachVe = VeBUS.Instance.hienthiVe(maCaChieu);

            if (danhSachVe != null)
            {
                foreach (Ve ve in danhSachVe)
                {
                    int col = count % 10 + 1;
                    int row = (count / 10) + 65;
                    Button btn = new Button() { Width = 80, Height = 30 };
                    btn.Text = ve.MaGheNgoi;
                    btn.Font = new Font("Arial", (float)10.5);
                    btn.Click += btn_Click;
                    btn.Tag = ve;

                    if (ve.TrangThai == 0)
                    {
                        btn.BackColor = Color.LightGoldenrodYellow;
                    }
                    else
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.Gray;
                        btn.ForeColor = Color.White;
                    }

                    flpSeat.Controls.Add(btn);
                    count++;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Ve ve = (btn.Tag as Ve);


            if (ve.LoaiVe != 0)
            {
                ve.LoaiVe = 0;
            }
            else
            {
                if (rdoAdult.Checked)
                {
                    ve.LoaiVe = 1;
                    ve.TienBanVe = 1 * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoChild.Checked)
                {
                    ve.LoaiVe = 2;
                    ve.TienBanVe = 0.5f * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoStudent.Checked)
                {
                    ve.LoaiVe = 3;
                    ve.TienBanVe = 0.75f * getSingleTicketPrice(this.maCaChieu);
                }
                else if (rdoFree.Checked)
                {
                    ve.LoaiVe = 4;
                    ve.TienBanVe = 0 * getSingleTicketPrice(this.maCaChieu);
                }

            }





            if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.LightGoldenrodYellow;
                maVe.Remove(ve);
                totalPrice -= ve.TienBanVe;
                bonus--;
            }
            else
            {
                btn.BackColor = Color.Yellow;
                maVe.Add(ve);
                totalPrice += ve.TienBanVe;
                bonus++;
            }

            txtTotal.Text = totalPrice.ToString() + " VNĐ";
            finalPrice = totalPrice;
            txtPayment.Text = finalPrice.ToString() + " VNĐ";
            numBonusPoint.Value = bonus;

        }



        // lấy giá của một vé theo ca chiếu
        private float getSingleTicketPrice(string maCaChieu)
        {
            return VeBUS.Instance.getPriceOfTicketBUS(maCaChieu);
        }

        // thanh toán
        private void btnPayment_Click(object sender, EventArgs e)
        {


            if (maVe.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé");
                return;
            }

            if (VeBUS.Instance.updateListTicket(maVe))
            {
                MessageBox.Show("Đặt vé thành công");
                if (txtCustomerName.Text != "" || txtCustomerName.Text != null)
                {
                    updatePoint(frmCustomer.phoneNumber.Trim(), Convert.ToInt32(numBonusPoint.Value));
                }
            }
            else
            {
                MessageBox.Show("Đặt vé thất bại");
            }

            totalPrice = 0;
            finalPrice = 0;
            bonus = 0;
            maVe.Clear();
            flpSeat.Controls.Clear();
            hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            resetPanels();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtPoint.Text != "" && txtPoint.Text != null)
            {
                CustomerBUS.Instance.rollbackPoint(Int32.Parse(txtPoint.Text), frmCustomer.phoneNumber);
            }

            flpSeat.Controls.Clear();
            hienThiDanhSachChoNgoiTheoMaCaChieu(this.maCaChieu);
            maVe.Clear();
            totalPrice = 0;
            finalPrice = 0;
            bonus = 0;
            resetPanels();
        }

        private void resetPanels()
        {
            txtTotal.ResetText();
            txtCustomerName.ResetText();
            txtPoint.ResetText();
            numBonusPoint.Value = numBonusPoint.Minimum;
            txtDiscount.ResetText();
            txtPayment.ResetText();
            btnUsePoint.Enabled = true;
        }


        public void loadDataCustomer()
        {
            if (frmCustomer.phoneNumber != "")
            {
                DataTable customer = CustomerBUS.Instance.getCustomer(frmCustomer.phoneNumber.Trim());
                if (customer != null)
                {
                    DataRow row = customer.Rows[0];
                    txtCustomerName.Text = row["TenKhachHang"].ToString();
                    txtPoint.Text = row["DiemTichLuy"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                }
            }
        }

        private void frmTheatre_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetPanels();
            maVe.Clear();
        }

        private void updatePoint(string phoneNumber, int bonus)
        {

            if (!CustomerBUS.Instance.updatePointBUS(phoneNumber, bonus))
            {
                MessageBox.Show("Cập nhật điểm không thành công");
            }
        }

        private void btnUsePoint_Click(object sender, EventArgs e)
        {
            if (txtPoint.Text == "" || txtPoint.Text == null)
            {
                MessageBox.Show("Vui lòng điền thông tin khách hàng");
                return;
            }


            if (CustomerBUS.Instance.usePointBUS(frmCustomer.phoneNumber))
            {
                MessageBox.Show("Sử dụng vé thành công, nhân viên tiến hành đổi vé");
            }
            else
            {
                Debug.WriteLine("result is false");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void flpSeat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
