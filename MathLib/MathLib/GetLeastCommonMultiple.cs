using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_GetLeastCommonMultiple
    {
        /// <summary>
        /// Returns the least common multiple of the two numbers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int GetLeastCommonMultiple(double num1, double num2)
        {
            int returnValue = 0;

            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);

            for (int i = 1; i <= (num1 * num2); i++)
            {
                if (IsWholeNumber(i / num1) == true && IsWholeNumber(i / num2) == true)
                {
                    returnValue = i;
                    break;
                }
            }
            return returnValue;
        }
    }
}
