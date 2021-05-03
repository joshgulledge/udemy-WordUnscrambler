using System;
using System.Collections.Generic; // this is needed to have lists?
using System.Linq; // this is needed to have count?
using System.IO;


namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            // writing to a file
            string[] lines = { "This is the first", "This is the second", "This is the third" };
            File.WriteAllLines("MyFirstFile.txt", lines);

            //// reading a file
            //string[] fileContents = File.ReadAllLines("MyFirstFile.txt");
            //Console.WriteLine(fileContents[1]);

            foreach(string line in File.ReadAllLines("MyFirstFile.txt"))
            {
                Console.WriteLine(line);
            }

        }
    }
}
