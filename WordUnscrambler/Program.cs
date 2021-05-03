using System;
using System.Collections.Generic; // this is needed to have lists?
using System.Linq; // this is needed to have count?


namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myFirstList = new List<int>();
            // var myFirstList = new List<int>();   both mean the same

            Console.WriteLine(myFirstList.Count());

            myFirstList.Add(10);
            myFirstList.Add(5);
            myFirstList.Add(9);
            //myFirstList.Add("hello"); this wont work

            Console.WriteLine(myFirstList.Count());
        }
    }
}
