using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    public static class AdvancedMath
    {
        /// <summary>
        /// Find all int components of a factor tree
        /// </summary>
        /// <param name="numberToFactor"></param>
        /// <returns></returns>
        public static List<int> Factor(int numberToFactor)
        {
            List<int> factorTreeValues = new List<int>();
            int max = (int)Math.Sqrt(numberToFactor);  //round down
            for (int evaluatedNumber = 1; evaluatedNumber <= max; ++evaluatedNumber)
            { 
                //test from 1 to the square root, or the int below it, inclusive.
                if (numberToFactor % evaluatedNumber == 0)
                {
                    factorTreeValues.Add(evaluatedNumber);
                    if (evaluatedNumber != numberToFactor / evaluatedNumber)
                    { // Don't add the square root twice!
                        factorTreeValues.Add(numberToFactor / evaluatedNumber);
                    }
                }
            }
            factorTreeValues.Sort();
            return factorTreeValues;
        }
    }
}
