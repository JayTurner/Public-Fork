using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Variable_MixedNumber
    {
        private int _wholeNumber = 0;
        private int _numerator = 0;
        private int _denominator = 0;

        public int wholeNumber
        {
            get
            {
                return _wholeNumber;
            }
            set
            {
                _wholeNumber = value;
            }
        }
        public int numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }
        public int denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                _denominator = value;
            }
        }
    }
}
