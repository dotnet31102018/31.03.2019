using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3103
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDAO dao = new CustomerDAO();

            dao.CreateTable();

            Customer c = new Customer
            {
                Id = 1,
                FirstName = "Ronen",
                LastName = "Haim",
                Age = 33,
                AddressCity = "Rishon le zion",
                AddressStreet = "Hertzel",
                PhNumber = "03-9644196"
            };
            /*
            c.PhNumber = "123";
            dao.AddCustomer(c);
            c.PhNumber = "456";
            dao.AddCustomer(c);
            c.PhNumber = "789";
            dao.AddCustomer(c);
            */
            //dao.DeleteCustomer(2);

            List<Customer> customers =  dao.GetAllCustomers();
            //Customer c2 = dao.GetCustomerById(3);

            Customer c3 = dao.GetCustomerByPhoneNumber("03-9644196");

            List<Customer> customersAges = dao.GetCustomersBetweenAges(30, 35);

            List<Customer> customersCity = dao.GetCustomersLivingInCity("Rishon le zion");

            //dao.RemoveAllCustomers();

            List<Customer> customers2 = dao.GetAllCustomers();

            CustomerDAO.Close();
        }
    }
}
