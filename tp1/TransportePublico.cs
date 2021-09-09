using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public abstract class TransportePublico
    {
        private int pasajeros;
        private string driverName;
        private int maxCapacity;
        public TransportePublico(int pasajeros, string driverName,int maxCapacity)
        {
            this.Pasajeros = pasajeros;
            this.driverName = driverName;
            this.MaxCapacity = maxCapacity;
        }

        public int Pasajeros
        {
            get
            {
                return pasajeros;
            }
            set
            {
                if (value.GetType() == typeof(int))
                {
                    pasajeros = value;
                }
                else
                {
                    pasajeros = 0;
                }
            }
        }
        public abstract bool OnlyLetters(string name);
        public string DriverName
        {
            get
            {
                if ( this.OnlyLetters(this.driverName) )
                {
                    return driverName;
                }
                else
                {
                    return "error";
                }
            }
            set
            {
                if (this.OnlyLetters(value))
                {
                    driverName = value;
                }
                else
                {
                    driverName = "error";
                }
            }
        }

        public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}
