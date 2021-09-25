using Lab.Tp5.LINQ.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab.Tp5.LINQ.Test
{
    [TestClass]
    public class CategoriesTest
    {
        [TestMethod]
        public void GetCategoriesTest()
        {
            CategoryLogic categories = new CategoryLogic();
            var list = categories.GetAll();
        }
    }
}
