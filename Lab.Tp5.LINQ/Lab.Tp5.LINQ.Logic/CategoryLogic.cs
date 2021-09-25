using Lab.Tp5.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp5.LINQ.Logic
{
    public class CategoryLogic : BaseLogic, IABMLogic<Category>
    {
        public List<Category> GetAll()
        {
            return this._northwindContext.Categories.ToList();
        }

        DbSet<Category> IABMLogic<Category>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
