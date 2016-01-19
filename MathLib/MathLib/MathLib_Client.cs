using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class MathLib_Client
    {
        static void Main(string[] args)
        {
            #region Functions
            //General //
            Function_GetLargerNumber _GetLargerNumber = new Function_GetLargerNumber();
            Function_GetSmallerNumber _GetSmallerNumber = new Function_GetSmallerNumber();
            Function_IsWholeNumber _IsWholeNumber = new Function_IsWholeNumber();

            // Factor //
            Function_GetCommonFactors _GetCommonFactors = new Function_GetCommonFactors();
            Function_GetFactors _GetFactors = new Function_GetFactors();
            Function_GetGreatestCommonFactor _GetGreatestCommonFactor = new Function_GetGreatestCommonFactor();
            Function_GetLeastCommonMultiple _GetLeastCommonMultiple = new Function_GetLeastCommonMultiple();
            Function_IsComposite _IsComposite = new Function_IsComposite();
            Function_IsPrime _IsPrime = new Function_IsPrime();

            // Fractions //
            Function_IsProper _IsProper = new Function_IsProper();
            Function_ToImproper _ToImproper = new Function_ToImproper();
            Function_ToProper _ToProper = new Function_ToProper();

            // Variables //
            Variable_MixedNumber _MixedNumber = new Variable_MixedNumber();
            #endregion
        }
    }
}
