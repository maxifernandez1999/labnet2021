using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public abstract class TransportePublico
    {
        public int pasajeros { get; set; }

        protected TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();

        public abstract string Descripcion();
    }
}
