using System;
using System.Collections.Generic;
using System.Text;
using Libraries;

namespace DailyProgrammer
{
    public class _363_IBeforeE : Challenge
    {
        private List<string> _words = null;

        //Challenge Input

        //List<string> _words = new List<string>()
        //{
        //    "a", "zombie", "transceiver", "veil", "icier", "fiery", "heirarchy", "hieroglyphic",
        //    "sleigh", "stein", "fahrenheit", "ceiling", "inconceivable", "receipt",
        //    "defies", "either", "nuclei", "reimburse", "daily", "programmer", "one", "two", "three",
        //    "ancient", "jucier", "societies"
        //};

        public override void LoadParameters<T>(IEnumerable<T> input)
        {
            _words = (List<string>) input;
        }

        public override string Solve()
        {
            var consoleOut = new StringBuilder();
            foreach (string currentWord in _words)
            {
                consoleOut.AppendLine($"Checking '{currentWord}': {Syntax.UsesIBeforeE(currentWord)}");
            }
            return consoleOut.ToString();
        }



    }
}