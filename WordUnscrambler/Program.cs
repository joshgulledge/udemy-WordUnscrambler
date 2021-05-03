using System;
using System.Collections.Generic; // this is needed to have lists?
using System.Linq; // this is needed to have count?


namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myFirstArray = new int[10]; // give it a size
            myFirstArray[9] = 9;

            var mySecondList = new List<int>();
            mySecondList.Add(5);

            Console.WriteLine(myFirstArray[7]);
            Console.WriteLine(mySecondList[0]);

        }
    }
}
