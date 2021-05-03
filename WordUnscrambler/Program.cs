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
            bool continueWordUnscramble = true;

            do
            {
                Console.WriteLine("Please enter F for file and M for manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled word file name: ");
                        WordsInFileInput();
                        break;
                    case "M":
                        Console.Write("Enter scrambled word manually: ");
                        WordsManualInput();
                        break;
                    default:
                        Console.Write("option not recognized ");
                        break;
                }

                var continueDecisionProcess = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to coninue? Y/N");
                    continueDecisionProcess = (Console.ReadLine() ?? string.Empty);

                } while (!continueDecisionProcess.Equals("Y", StringComparison.OrdinalIgnoreCase)
                    && !continueDecisionProcess.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueDecisionProcess.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void WordsManualInput()
        {
        }

        private static void WordsInFileInput()
        {
        }
    }
}
