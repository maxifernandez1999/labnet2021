using Lab.Tp5.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp5.LINQ.Logic
{
    public class OrderLogic : BaseLogic, IABMLogic<Order>
    {
        public DbSet<Order> GetAll()
        {
            return this._northwindContext.Orders;
        }

        public List<Order> GetListOrders()
        {
            return (from order in this.GetAll()
                   select order).ToList();
        }


    }
}
