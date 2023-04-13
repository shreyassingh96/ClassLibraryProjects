using System;
using UtilityLibraries;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, World!";
            bool startsWithUpper = input.StartsWithUpper();
            Console.WriteLine($"The input starts with an uppercase letter: {startsWithUpper}");
        }

    }
}
