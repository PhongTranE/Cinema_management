using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;
        public static CustomerBUS Instance
        {
            get { if (instance == null) instance = new CustomerBUS(); return CustomerBUS.instance; }
            private set { CustomerBUS.instance = value; }
        }

        public DataTable getListCustomer()
        {
            return CustomerDAO.Instance.ReadAllCustomer();
        }

        public bool addCustomer(String name, int birth, String phoneNumber, int point, String address)
        {
           if ( CustomerDAO.Instance.addCustomerDAO(name, birth, phoneNumber, point, address)){
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteCustomer(int CusId)
        {
            if (CustomerDAO.Instance.deleteCustomerDAO(CusId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateCustomerBUS (int id, String name, String address, int birth, String phone, int point)
        {
            return CustomerDAO.Instance.updateCustomerDAO(id, name, address, birth, phone, point);
        }


        public byte isMember (string phoneNumber)
        {
            return CustomerDAO.Instance.isMemberDAO(phoneNumber);
        }

        public DataTable getCustomer(String phoneNumber)
        {
            return CustomerDAO.Instance.getCustomerDAO(phoneNumber);
        }

        public bool updatePointBUS(string phoneNumber, int bonus)
        {
            return CustomerDAO.Instance.updatePointDAO(phoneNumber, bonus);
        }

        public bool usePointBUS(string phoneNumber)
        {
            return CustomerDAO.Instance.usePointDAO(phoneNumber);
        }

        public void rollbackPoint(int point, string phoneNumber)
        {
            CustomerDAO.Instance.rollbackPoint(point, phoneNumber);
        }

    }
}

