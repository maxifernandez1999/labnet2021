using Lab.Tp7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp7.Logic
{
    public class ShipperLogic : BaseLogic, IABMLogic<Shipper>
    {
        public List<Shipper> GetAll()
        {
            try
            {
                return context.Shippers.ToList();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            
        }

        public void Add(Shipper shipper)
        {
            try
            {
                context.Shippers.Add(shipper);
                context.SaveChanges();

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        
        public void Delete(int id)
        {
            try
            {
                var entity = context.Shippers.First(i => i.ShipperID == id);
                context.Shippers.Remove(entity);
                context.SaveChanges();

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void Update(Shipper shipper)
        {
            try
            {
                var shipperUpdate = context.Shippers.First(s => s.ShipperID == shipper.ShipperID);
                shipperUpdate.CompanyName = shipper.CompanyName;
                shipperUpdate.Phone = shipper.Phone;
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
