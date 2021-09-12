using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Exceptions
{
    public class CustomException : Exception
    {
        private string _message;
        public CustomException() : base("Esta es una excepcion personalizada (mensaje desde el base)!")
        {
        }
        public CustomException(string message) : base(message)
        {
            this._message = message;
        }

    }
}
