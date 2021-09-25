using Lab.Tp5.LINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp5.LINQ.Logic
{
    public abstract class BaseLogic
    {
        protected readonly NorthwindContext _northwindContext;

        public BaseLogic()
        {
            this._northwindContext = new NorthwindContext();
        }
    }
}
