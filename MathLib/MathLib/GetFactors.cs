using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_GetFactors
    {
        /// <summary>
        /// Returns an array of all the factors of the number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int[] GetFactors(int num)
        {
            int count = 0;
            int index = 0;
            int[] returnValue;

            num = Math.Abs(num);

            if (num >= 1)
            {
                //Gets the number of factors.
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        count++;
                }

                returnValue = new int[count];

                //Sets the factors to the array.
                for (int j = num; j >= 1; j--)
                {
                    if (num % j == 0)
                    {
                        returnValue[index] = num / j;
                        index++;
                    }
                }
                return returnValue;
            }
            else
            {
                returnValue = null;
                return returnValue;
            }
        }
    }
}