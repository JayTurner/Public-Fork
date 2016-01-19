using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_GetGreatestCommonFactor
    {
        /// <summary>
        /// Returns the greatest common factor of the two numbers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int GetGreatestCommonFactor(int num1, int num2)
        {
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
            
            int[] factorArray = GetCommonFactors(num1, num2);
            int returnValue = factorArray[factorArray.Length - 1];
            return returnValue;
        }
    }
}
