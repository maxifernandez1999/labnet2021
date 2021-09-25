using Lab.Tp5.LINQ.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab.Tp5.LINQ.Test
{
    [TestClass]
    public class OrdersTest
    {
        [TestMethod]
        public void GetOrdersTest()
        {
            OrderLogic orders = new OrderLogic();
            var list = orders.GetAll();
        }
    }
}
