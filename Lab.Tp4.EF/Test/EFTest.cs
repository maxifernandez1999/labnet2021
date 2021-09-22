using Lab.Tp4.EF.Entities;
using Lab.Tp4.EF.Logic;
using Lab.Tp4.EF.Logic.Extensions;
using Lab.Tp4.EF.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace Lab.Tp4.EF.Test
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
           
                
        }

        [TestMethod]
        public void TestUpdateShipper()
        {
            ShipperLogic shipperLogic = new ShipperLogic();
            shipperLogic.Update(new Shipper
            {
                ShipperID = 15,
                CompanyName = "NewCompanyMaster2",
                Phone = "(555) 345-3455"

            });


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
