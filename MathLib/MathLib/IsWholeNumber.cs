using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_IsWholeNumber
    {
        /// <summary>
        /// Determine whether the number is a whole number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsWholeNumber(double num)
        {
            int temp = Convert.ToInt32(num);
            bool returnValue;

            if (num == temp)
                returnValue = true;
            else
                returnValue = false;

            return returnValue;
        }
    }
}
