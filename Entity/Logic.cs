using Entity.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public static class Logic
    {
        public static void ThrowException()
        {
            throw new InvalidCastException();
        }
        public static void ThrowCustomException()
        {
            throw new CustomException("Este es el mensaje personalizado ingresado por parametro");
        }
    }
}
