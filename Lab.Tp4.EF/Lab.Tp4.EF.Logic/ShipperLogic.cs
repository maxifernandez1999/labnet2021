using Lab.Tp4.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp4.EF.Logic
{
    public class ShipperLogic : BaseLogic, IABMLogic<Shipper>
    {
        public List<Shipper> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Add(Shipper shipper)
        {
            context.Shippers.Add(shipper);
            context.SaveChanges();
        }
        
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shipper shipper)
        {
            var shipperUpdate = context.Shippers.First(s => s.ShipperID == shipper.ShipperID);
            shipperUpdate.CompanyName = shipper.CompanyName;
            shipperUpdate.Phone = shipper.Phone;
            context.SaveChanges();
        }
    }
}
