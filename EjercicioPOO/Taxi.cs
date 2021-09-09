using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Taxi : TransportePublico
    {
        private int numeroTaxi;

        public int NumeroTaxi { get => numeroTaxi; set => numeroTaxi = value; }
        public Taxi(int pasajeros, int numeroTaxi) : base(pasajeros)
        {
        }

        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }
        public override string Descripcion()
        {
            return $"Omnibus {this.numeroTaxi}: {base.pasajeros} pasajeros";
        }
    }
}
