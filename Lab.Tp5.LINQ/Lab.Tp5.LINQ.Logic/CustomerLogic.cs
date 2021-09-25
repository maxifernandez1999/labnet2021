using Lab.Tp5.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp5.LINQ.Logic
{
    public class CustomerLogic : BaseLogic, IABMLogic<Customer>
    {
        public DbSet<Customer> GetAll()
        {
            return this._northwindContext.Customers;
        }

        public Customer OneCustomer()
        {
            return this._northwindContext.Customers.First();
        }
        public List<Customer> CustomersWithRegionWA()
        {
            return (from customer in this.GetAll()
                   where customer.Region == "WA"
                   select customer).ToList();

        }

        public IEnumerable<string> CustomersName()
        {
            return from customer in this.GetAll()
                   select customer.ContactName;

        }

        public List<Customer> First3CustomersFromRegionWA()
        {
            return this.GetAll()
                       .Where(c => c.Region == "WA")
                       .Take(3)
                       .ToList();

        }

        public List<CustomerOrder> CustomersWithCountOrders()
        {
            OrderLogic orderLogic = new OrderLogic();

            return (from customer in this.GetAll().ToList()
                    join order in orderLogic.GetListOrders()
                    on customer.CustomerID equals order.CustomerID
                    select new CustomerOrder
                    {
                        CustomerID = customer.CustomerID,
                        CompanyName = customer.CompanyName,
                        CountOrder = orderLogic.GetAll().Where(o => o.CustomerID == customer.CustomerID).Count()
                    }).ToList();

        }
        public List<CustomerOrder> CustomersFromRegionWAAndDateGreaterThan1_1_1997()
        {
            OrderLogic orderLogic = new OrderLogic();           

            DateTime date = new DateTime(1997,01,01);
            return ( from customer in this.GetAll().ToList()
                     join order in orderLogic.GetListOrders()
                     on customer.CustomerID equals order.CustomerID
                     where customer.Region == "WA" && order.OrderDate > date
                     select new CustomerOrder
                     {
                        CustomerID = customer.CustomerID,
                        CompanyName = customer.CompanyName,
                        ContactName = customer.ContactName,
                        ContactTitle = customer.ContactTitle,
                        Address = customer.Address,
                        City = customer.City,
                        Region = customer.Region,

                        PostalCode = customer.PostalCode,
                        Country = customer.Country,
                        Phone = customer.Phone,
                        Fax = customer.Fax,
                        OrderID = order.OrderID,
                        EmployeeID = order.OrderID,
                        OrderDate = order.OrderDate,
                        RequiredDate = order.RequiredDate,
                        ShippedDate = order.ShippedDate,
                        ShipVia = order.ShipVia,
                        Freight = order.Freight,
                        ShipName = order.ShipName,
                        ShipAddress = order.ShipAddress,
                        ShipCity = order.ShipCity,
                        ShipRegion = order.ShipRegion,
                        ShipPostalCode = order.ShipPostalCode,
                        ShipCountry = order.ShipCountry

                    }).ToList();
        }


    }
}
