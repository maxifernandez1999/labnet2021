using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp5.LINQ.Entities.Extensions
{
    public static class StringExtension
    {
        public static bool IsInteger(this string number)
        {
            return Convert.ToInt32(number) != 0 ? true : false;
        }
    }
}
