using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_IsProper
    {
        /// <summary>
        /// Returns whether the mixed number is proper.
        /// </summary>
        /// <param name="mixedNum"></param>
        /// <returns></returns>
        public bool IsProper(MixedNumber mixedNum)
        {
            bool returnValue;

            if (mixedNum.numerator < mixedNum.denominator)
                returnValue = true;
            else
                returnValue = false;

            return returnValue;
        }
    }
}
