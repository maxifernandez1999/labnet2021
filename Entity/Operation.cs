using Entity.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Operation : IOperation
    {
        private float _dividend;
        private float _divider;

        public Operation(float dividend)
        {
            this.Dividend = dividend;
        }
        public Operation(float dividend, float divider)
        {
            this.Dividend = dividend;
            this.Divider = divider;
        }

        public float Dividend { get => _dividend; set => _dividend = value; }
        public float Divider { get => _divider; set => _divider = value; }

        public float DivideByZero()
        {
            return (int)this.Dividend / 0;
        }
        public float Divide()
        {
            if (!(this.Divider.IsZero()))
            {
                return this.Dividend / this.Divider;
            }
            else
            {
                return (int)this.Dividend / (int)this.Divider;
            }
            
        }
       
    }
}
