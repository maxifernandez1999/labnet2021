using Lab.Tp7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp7.Logic
{
    public class EmployeeTerritoryLogic : BaseLogic, IABMLogic<EmployeeTerritory>
    {
        public List<EmployeeTerritory> GetAll()
        {
            try
            {
                return context.EmployeeTerritories.ToList();
            }
            catch(Exception)
            {
                throw new Exception();
            }
            
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
            try
            {
                var entity = context.EmployeeTerritories.First(i => i.TerritoryID == newID);
                context.EmployeeTerritories.Remove(entity);
                context.SaveChanges();

            }
            catch (Exception)
            {
                throw new Exception();
            }
            
        }

        public void Update(EmployeeTerritory employeeTerritory)
        {
            throw new NotImplementedException();
        }
    }
}
