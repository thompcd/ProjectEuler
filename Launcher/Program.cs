using System;
using System.Collections.Generic;
using DailyProgrammer;


namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var test = new _384_CreateADiceRoller();
                Console.WriteLine(test.Solve());
                Console.ReadKey();
            }

        }
    }
}
