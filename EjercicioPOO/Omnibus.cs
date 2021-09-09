using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Omnibus : TransportePublico
    {
        private int numeroOmnibus;

        public int NumeroOmnibus { get => numeroOmnibus; set => numeroOmnibus = value; }

        public Omnibus(int pasajeros,int numeroOmnibus) : base(pasajeros)
        {
            this.pasajeros = base.pasajeros;
            this.numeroOmnibus = NumeroOmnibus;
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
            return $"Omnibus {this.NumeroOmnibus}: {base.pasajeros} pasajeros";
        }
    }
}
