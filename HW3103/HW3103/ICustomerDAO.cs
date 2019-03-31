using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3103
{
    public interface ICustomerDAO
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer c);
        void UpdateCustomer(int id, Customer c);
        void DeleteCustomer(int id);
        List<Customer> GetCustomersLivingInCity(string city);
        List<Customer> GetCustomersBetweenAges(int minAge, int maxAge);
        Customer GetCustomerByPhoneNumber(string ph);
        void RemoveAllCustomers();
    }
}
