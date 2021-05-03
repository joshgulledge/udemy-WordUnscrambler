using System;
using System.Collections.Generic; // this is needed to have lists?
using System.Linq; // this is needed to have count?


namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information:");
            var input = Console.ReadLine();

            while (!input.Equals(string.Empty))
            {
                Console.WriteLine("Enter information:");
                input = Console.ReadLine();
                Console.WriteLine("User Input is {0}", input);
            }

        }
    }
}
