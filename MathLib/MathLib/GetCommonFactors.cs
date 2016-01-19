using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Function_GetCommonFactors
    {
        /// <summary>
        /// Returns an array of all the common factors of the two numbers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int[] GetCommonFactors(int num1, int num2)
        {
            int count = 0;
            int index = 0;
            int smallerNum;
            int largerNum;
            int[] returnValue;

            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);


            smallerNum = GetSmallerNumber(num1, num2);
            largerNum = GetLargerNumber(num1, num2);

            if (num1 >= 1 && num2 >= 1)
            {
                //Get the number of common factors
                for (int i = 1; i <= smallerNum; i++)
                    if (num1 % i == 0 && num2 % i == 0)
                        count++;

                returnValue = new int[count];

                //Sets the common factors to the array.
                for (int j = 1; j <= smallerNum; j++)
                {
                    if (smallerNum % j == 0 && largerNum % j == 0)
                    {
                        returnValue[index] = j;
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
