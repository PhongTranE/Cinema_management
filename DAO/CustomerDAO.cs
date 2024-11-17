using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }


        public DataTable ReadAllCustomer()
        {
            String query = @"USP_layTatCaKhachHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return dt;
        }

        public bool addCustomerDAO(String name, int birth, String phoneNumber, int point, String address)
        {

            String query = "dbo.USP_themKhachHang @TenKhachHang ,  @DiaChi , @NamSinh , @SoDienThoai ,  @Diem ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, address, birth, phoneNumber, point });
                return true;
            }
            catch
            {
                return false;
            }
               
        }

        public bool deleteCustomerDAO (int CustomerID)
        {
            String query = "dbo.USP_xoaKhachHang @CustomerId ";
            
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { CustomerID });
                return true;
           
        }

        public bool updateCustomerDAO(int id, String name, String address, int birth, String phone, int point)
        {
            String query = "USP_capNhatKhachHang @CusId , @name , @address , @birth , @phone , @point ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] {id, name, address, birth, phone, point });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public byte isMemberDAO(string phoneNumber)
        {
            string query = "Select dbo.FUNC_laThanhVien ( @phone )";
            byte kq;
            try
            {
                kq = Convert.ToByte(DataProvider.Instance.ExecuteScalar(query, new object[] { phoneNumber }));
            }
            catch
            {
                // error
                kq = 2;
            }
            return kq;
        }

        public DataTable getCustomerDAO(string phoneNumber)
        {
            string query = "USP_layThongTinKhachHang @Sdt ";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { phoneNumber });
            }
            catch 
            {
                return null;
            }
        }

        public bool updatePointDAO(string phoneNumber, int bonus)
        {
            string query = "USP_congDiemTichLuy @Sdt , @bonus ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { phoneNumber, bonus });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool usePointDAO (string phoneNumber)
        {
            string query = "USP_suDungDiemTichLuy @Sdt ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { phoneNumber });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void rollbackPoint (int point, string phoneNumber)
        {
            string query = "USP_capNhatDiem @Diem , @Sdt ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { point, phoneNumber });
            }
            catch
            {
                Debug.WriteLine("Error");
            }

        }
    }
}
