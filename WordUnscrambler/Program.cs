using System;
using System.Collections.Generic; // this is needed to have lists?
using System.Linq; // this is needed to have count?


namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 7, 9, 10 };

            foreach(var element in array)
            {
                Console.WriteLine("The item is {0}", element);
            }

            for (int i=0; i < array.Length; i++)
            {
                Console.WriteLine("The item is {0}", array[i]);
            }

            int index = 0;
            while (index < array.Length)
            {
                Console.WriteLine("The item is {0}", array[index]);
                index++;
            }
        }
    }
}
