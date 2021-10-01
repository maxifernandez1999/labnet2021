using Lab.tp7.EF.Logic.Extensions;
using Lab.Tp7.Entities;
using Lab.Tp7.Logic;
using Lab.Tp7.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace Lab.tp7.Test
{
    [TestClass]
    public class EFTest
    {
        [TestMethod]
        public void TestAddShipper()
        {
            ShipperLogic shipperLogic = new ShipperLogic();
            shipperLogic.Add(new Shipper
            {
                CompanyName = "NewCompanyMaster",
                Phone = "(555) 345-3453"

            });

            Assert.IsInstanceOfType(shipperLogic, typeof(ShipperLogic));
           
                
        }

        [TestMethod]
        public void TestUpdateShipper()
        {
            ShipperLogic shipperLogic = new ShipperLogic();
            shipperLogic.Update(new Shipper
            {
                ShipperID = 1,
                CompanyName = "NewCompanyMaster2",
                Phone = "(555) 345-3455"

            });
            Assert.IsInstanceOfType(shipperLogic, typeof(ShipperLogic));


        }

        [TestMethod]
        public void TestExtensionMethod()
        {
            string phone = "(232) 233-2332";
            bool valid = phone.IsValidPhoneExtension();
            Assert.IsTrue(valid);

        }
    }
}
