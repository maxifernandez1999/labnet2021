using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.tp7.EF.Logic.Extensions
{
    public static class PhoneExtension
    {
        public static bool IsValidPhoneExtension(this string phone)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            string[] arrayPhone = phone.Split(' ','-');
            if(arrayPhone.Length != 3)
            {
                return false;
            }
            bool isCharacter = arrayPhone[0].Contains("(") || arrayPhone[0].Contains(")");
            bool isNumericFirst = int.TryParse(arrayPhone[1], out firstNumber) && arrayPhone[1].Length == 3;
            bool isNumericSecond = int.TryParse(arrayPhone[2], out secondNumber) && arrayPhone[2].Length == 4;
            if (isCharacter && isNumericFirst && isNumericSecond)
            {
                return true;
            }

            return false;
        }
    }
}
