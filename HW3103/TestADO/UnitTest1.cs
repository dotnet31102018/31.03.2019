﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW3103;
using System.Collections.Generic;

namespace TestADO
{
    [TestClass]
    public class UnitTest1
    {
        private ICustomerDAO Initialize()
        {
            ICustomerDAO dao = new CustomerDAO();
            dao.RemoveAllCustomers();
            return dao;
        }

        [TestMethod]
        public void TestAddCustomer()
        {
            ICustomerDAO dao = Initialize();

            Customer c = new Customer
            {
                FirstName = "Ronen",
                LastName = "Haim",
                Age = 33,
                AddressCity = "Rishon le zion",
                AddressStreet = "Hertzel",
                PhNumber = "03-9644196"
            };

            dao.AddCustomer(c);

            List<Customer> customers = dao.GetAllCustomers();

            Assert.AreEqual(1, customers.Count);
            //Assert.AreEqual(1, customers[0].Id);
            Assert.AreEqual("Ronen", customers[0].FirstName);
            Assert.AreEqual("Haim", customers[0].LastName);
            Assert.AreEqual(33, customers[0].Age);
            Assert.AreEqual("Rishon le zion", customers[0].AddressCity);
            Assert.AreEqual("Hertzel", customers[0].AddressStreet);
            Assert.AreEqual("03-9644196", customers[0].PhNumber);

            
        }

        [TestMethod]
        [ExpectedException(typeof(System.Data.SQLite.SQLiteException))]
        public void TestAddCustomerExceptionPhNumber()
        {
            ICustomerDAO dao = Initialize();

            Customer c = new Customer
            {
                FirstName = "Ronen",
                LastName = "Haim",
                Age = 33,
                AddressCity = "Rishon le zion",
                AddressStreet = "Hertzel",
                PhNumber = "03-9644196"
            };

            dao.AddCustomer(c);

            dao.AddCustomer(c);


        }
    }
}
