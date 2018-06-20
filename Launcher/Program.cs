using System;
using System.Collections.Generic;
using DailyProgrammer;


namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "EbAAdbBEaBaaBBdAccbeebaec";

            var test = new _361_TallyProgram();

            test.LoadParameters(input);
            
            Console.WriteLine(test.Solve());
            Console.ReadKey();
        }
    }
}
