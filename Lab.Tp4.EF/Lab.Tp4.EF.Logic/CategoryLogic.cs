using Lab.Tp7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp7.Logic
{
    public class CategoryLogic : BaseLogic, IABMLogic<Category>
    {
        public List<Category> GetAll()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception)
            {

                throw new Exception();
            }
            
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
