using Lab.Tp5.LINQ.Entities;
using Lab.Tp5.LINQ.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab.Tp5.LINQ.Test
{
    [TestClass]
    public class ProductsTest
    {

        [TestMethod]
        public void GetProductsWithOutStockTest()
        {
            ProductLogic products = new ProductLogic();
            var list = products.ProductsWithOutStock();

        }

        [TestMethod]
        public void GetProductsWithStockAndPriceGreaterThan3Test()
        {
            ProductLogic products = new ProductLogic();
            var list = products.ProductsWithStockAndUnitPriceGreaterThan3();

        }

        [TestMethod]
        public void GetProductsWithIDEquals789Test()
        {
            ProductLogic products = new ProductLogic();
            var list = products.ProductsWithIDEquals789();

            Assert.IsNull(list);
        }

        [TestMethod]
        public void GetProductsOrderByNameTest()
        {
            ProductLogic products = new ProductLogic();
            var list = products.ProductsOrderByName();

        }

        [TestMethod]
        public void GetProductsOrderByUnitsInStockTest()
        {
            ProductLogic products = new ProductLogic();
            var list = products.ProductsOrderByUnitsInStock();

        }

        [TestMethod]
        public void GetProductsDistinctsCategoriesTest()
        {
            ProductLogic products = new ProductLogic();
            var list = products.ProductsDistinctsCategories();

        }

        [TestMethod]
        public void GetFirstProductTest()
        {
            ProductLogic products = new ProductLogic();
            var prod = products.FirstProduct();

            Assert.IsInstanceOfType(prod, typeof(Product));
        }
    }
}
