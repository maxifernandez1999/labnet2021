using Lab.Tp7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp7.Logic
{
    public class TerritoryLogic : BaseLogic, IABMLogic<Territory>
    {
        public List<Territory> GetAll()
        {
            try
            {
                return context.Territories.ToList();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            
        }

        public void Add(Territory territory)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {

            throw new NotImplementedException();
        }

        public void Update(Territory territory)
        {
            throw new NotImplementedException();
        }
    }
}
