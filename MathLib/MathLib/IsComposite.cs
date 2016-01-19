using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_IsComposite
    {
        /// <summary>
        /// Determines whether the number is composite.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsComposite(int num)
        {
            num = Math.Abs(num);
            bool returnValue;

            if (GetFactors(num).Length > 2)
                returnValue = true;
            else
                returnValue = false;

            return returnValue;
        }
    }
}
