using Lab.Tp5.LINQ.Entities;
using Lab.Tp5.LINQ.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab.Tp5.LINQ.Test
{
    [TestClass]
    public class CustomersTest
    {
       

        [TestMethod]
        public void GetOneCustomerTest()
        {
            CustomerLogic customers = new CustomerLogic();
            var cus = customers.OneCustomer();

            Assert.IsInstanceOfType(cus, typeof(Customer));
        }

        [TestMethod]
        public void GetCustomersWithRegionWATest()
        {
            CustomerLogic customers = new CustomerLogic();
            var cus = customers.CustomersWithRegionWA();
        }

        [TestMethod]
        public void GetCustomersNameTest()
        {
            CustomerLogic customers = new CustomerLogic();
            var cus = customers.CustomersName();
            foreach (var customer in cus)
            {
                var cusToUpperCase = customer.ToUpper();
                var cusToLowerCase = customer.ToLower();
            }
        }

        [TestMethod]
        public void GetFirst3CustomersFromRegionWATest()
        {
            CustomerLogic customers = new CustomerLogic();
            var cus = customers.First3CustomersFromRegionWA();
        }

        [TestMethod]
        public void GetCustomersFromRegionWAAndDateGreaterThan1_1_1997Test()
        {
            CustomerLogic customers = new CustomerLogic();
            var cus = customers.CustomersFromRegionWAAndDateGreaterThan1_1_1997();
            
            
        }

        [TestMethod]
        public void GetCustomersWithCountOrders()
        {
            CustomerLogic customers = new CustomerLogic();
            var cus = customers.CustomersWithCountOrders();


        }


    }
}
