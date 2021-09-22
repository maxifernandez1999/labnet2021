using Lab.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp4.EF.Logic
{
    public class TerritoryLogic : BaseLogic, IABMLogic<Territory>
    {
        public List<Territory> GetAll()
        {
            return context.Territories.ToList();
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
