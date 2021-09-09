using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!\n\r" +
                "1. Agregar Taxi\n\r" +
                "2. Agregar Omnibus");
            //int cantidadPasajeros = 0;
            //int numeroTransporte = 1;
            //List<TransportePublico> trasportes = new List<TransportePublico>();
            string valorIngresado = Console.ReadLine();
            //switch(valorIngresado)
            //{
            //    case "1":
            //        trasportes.Add(new Taxi(cantidadPasajeros, numeroTransporte));
            //        numeroTransporte++;
            //        break;
            //    case "2":
            //        trasportes.Add(new Omnibus(cantidadPasajeros, numeroTransporte));
            //    break;
            //    default:
            //    break;
            //}
            List<TransportePublico> trasportes = new List<TransportePublico>
            {
                new Taxi(10,1),
                new Omnibus(10,2)
            };
            foreach (var trasporte in trasportes)
            {
                if (trasporte.GetType() == typeof(Taxi))
                {
                    Console.WriteLine(trasporte.Descripcion());
                }
                
            }

            Console.ReadKey();
        }
    }
}
