using Lab.Tp5.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp5.LINQ.Logic
{
    public class ProductLogic : BaseLogic, IABMLogic<Product>
    {
        public DbSet<Product> GetAll()
        {
            return this._northwindContext.Products;
        }

        public List<Product> ProductsWithOutStock()
        {
            return (from product in this.GetAll()
                   where product.UnitsInStock == 0
                   select product).ToList();

        }

        public List<Product> ProductsWithStockAndUnitPriceGreaterThan3()
        {
            return (from product in this.GetAll().ToList()
                   where product.UnitsInStock > 0 &&
                   product.UnitPrice > 3              
                   select product).ToList();

        }

        public Product ProductsWithIDEquals789()
        {
            return this.GetAll().FirstOrDefault(x => x.ProductID == 789);

        }

        public List<Product> ProductsOrderByName()
        {
            return this.GetAll().OrderBy(n => n.ProductName).ToList();

        }

        public List<Product> ProductsOrderByUnitsInStock()
        {
            return this.GetAll().OrderByDescending(n => n.UnitsInStock).ToList();

        }

        public List<Product> ProductsDistinctsCategories()
        {
            return (from product in this.GetAll()
                      select product)
                      .Distinct().ToList();

        }
        public Product FirstProduct()
        {
            return this.GetAll().First();

        }


    }
}
