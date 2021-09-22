using Lab.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp4.EF.Logic
{
    public class CategoryLogic : BaseLogic, IABMLogic<Category>
    {
        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();

        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
