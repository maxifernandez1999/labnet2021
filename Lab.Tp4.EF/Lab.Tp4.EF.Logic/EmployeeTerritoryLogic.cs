using Lab.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp4.EF.Logic
{
    public class EmployeeTerritoryLogic : BaseLogic, IABMLogic<EmployeeTerritory>
    {
        public List<EmployeeTerritory> GetAll()
        {
            return context.EmployeeTerritories.ToList();
        }

        public void Add(EmployeeTerritory employeeTerritory)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            string newID = id.ToString();
            if (newID.Length == 4)
            {
                newID = $"0{id.ToString()}";
            }
            var entity = context.EmployeeTerritories.First(i => i.TerritoryID == newID);
            context.EmployeeTerritories.Remove(entity);
            context.SaveChanges();
            
        }

        public void Update(EmployeeTerritory employeeTerritory)
        {
            throw new NotImplementedException();
        }
    }
}
