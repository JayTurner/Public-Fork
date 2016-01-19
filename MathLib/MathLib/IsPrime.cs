using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_IsPrime
    {
        public bool IsPrime(int num)
        {
            num = Math.Abs(num);
            bool returnValue;

            if (num > 1 && GetFactors(num).Length == 2)
                returnValue = true;
            else
                returnValue = false;

            return returnValue;
        }
    }
}
