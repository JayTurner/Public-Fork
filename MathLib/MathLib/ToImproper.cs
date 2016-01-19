using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_ToImproper
    {
        /// <summary>
        /// Returns the improper fraction equivalent tothe proper fraction.
        /// </summary>
        /// <param name="mixedNum"></param>
        /// <returns></returns>
        public MixedNumber ToImproper(MixedNumber mixedNum)
        {
            MixedNumber returnValue = new MixedNumber();

            returnValue.numerator = mixedNum.denominator * Math.Abs(mixedNum.wholeNumber) + mixedNum.numerator;
            returnValue.denominator = mixedNum.denominator;

            if (mixedNum.wholeNumber < 0)
                returnValue.numerator *= -1;

            return returnValue;
        }
    }
}
