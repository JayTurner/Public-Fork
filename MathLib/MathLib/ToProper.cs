using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_ToProper : MathLib_Client
    {
        /// <summary>
        /// Returns the proper mixed number equivalent to the improper fraction.
        /// </summary>
        /// <param name="mixedNum"></param>
        /// <returns></returns>

        public bool MixedNumber ToProper(MixedNumber mixedNum)
        {
            MixedNumber returnValue = new MixedNumber();

            if (mixedNum.wholeNumber == -1)
            {
                returnValue.wholeNumber = -1 * (mixedNum.numerator / mixedNum.denominator);
                returnValue.numerator = mixedNum.numerator % mixedNum.denominator;
                returnValue.denominator = mixedNum.denominator;
            }
            else if (mixedNum.wholeNumber == 0)
            {
                returnValue.wholeNumber = mixedNum.numerator / mixedNum.denominator;
                returnValue.numerator = mixedNum.numerator % mixedNum.denominator;
                returnValue.denominator = mixedNum.denominator;
            }
            else
            {
                /////////////////////
                // Add Error code. //
                /////////////////////
            }

            return returnValue;
        }
    }
}
