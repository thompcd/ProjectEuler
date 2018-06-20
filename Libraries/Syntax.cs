using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    public static class Syntax
    {
        /// <summary>
        /// Determine if input implements 'i' before 'e' except after 'c'.
        /// Does not perform any input validation
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool UsesIBeforeE(string input)
        {
            bool anythingFollowsRule = true;
            var inputArray = input.ToCharArray();

            for (var i = 1; i < input.Length - 1; i++)
            {
                //e before i
                if (inputArray[i].Equals('e') && inputArray[i + 1].Equals('i'))
                {
                    //"c e i" example case
                    //found at least one instance of following the rule
                    // does not continue to check if other instances in the same word do not use rule
                    if (inputArray[i - 1].Equals('c'))
                    {
                        anythingFollowsRule = true;
                        break;
                    }
                    //e is before i, but does not have a c
                    else
                    {
                        anythingFollowsRule = false; ;
                    }
                }
                //i before e
                else if (inputArray[i].Equals('i') && inputArray[i + 1].Equals('e'))
                {
                    //"icier" example case
                    // fail specifically if c leads and "ie"
                    if (inputArray[i - 1].Equals('c'))
                    {
                        anythingFollowsRule = false;
                        continue;
                    }
                }
            }
            return anythingFollowsRule;
        }
    }
}
