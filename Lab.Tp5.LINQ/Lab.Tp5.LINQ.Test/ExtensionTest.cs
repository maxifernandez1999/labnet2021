using Lab.Tp5.LINQ.Entities.Extensions;
using Lab.Tp5.LINQ.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab.Tp5.LINQ.Test
{
    [TestClass]
    public class ExtensionTest
    {
        [TestMethod]
        public void ExtensionMethodTest()
        {
            string number = "32";
            bool isInteger = number.IsInteger();

            Assert.IsTrue(isInteger);

        }
    }
}
