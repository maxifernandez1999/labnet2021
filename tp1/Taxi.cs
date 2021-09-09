using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros,string driverName,int maxCapacity) : base(pasajeros,driverName,maxCapacity)
        {
            this.Pasajeros = pasajeros;
            this.DriverName = driverName;
            this.MaxCapacity = maxCapacity;
        }


        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }

        public override bool OnlyLetters(string name)
        {
            if (name == "")
            {
                return false;
            }
            foreach (var letter in name)
            {
                if (!char.IsLetter(letter))
                {
                    return false;
                }
            }
            return true;
            
        }

        //public void SetData(Taxi taxi)
        //{
        //    base.PublicTransport.Add(taxi);
        //}

        //public List<TransportePublico> GetData()
        //{
        //    return PublicTransport;
        //}
    }
}
