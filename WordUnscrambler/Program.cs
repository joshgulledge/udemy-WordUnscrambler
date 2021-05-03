using System;
using System.Collections.Generic; // this is needed to have lists?
using System.Linq; // this is needed to have count?


namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            do
            {
                Console.WriteLine("Enter information:");
                input = Console.ReadLine();
                Console.WriteLine("User input is {0}", input);

            } while (!input.Equals(string.Empty));

        }
    }
}
