using System;
using System.Collections.Generic; // this is needed to have lists?
using System.Linq; // this is needed to have count?
using WordUnscrambler.Workers;
using WordUnscrambler.Data;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        private const string wordListFileName = "wordlist.txt";

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

                } while (
                    !continueDecisionProcess.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
                    !continueDecisionProcess.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueDecisionProcess.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void WordsManualInput()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = manualInput.Split(',');
            DisplayMatchedUnscrambleWords(scrambledWords);
        }

        private static void DisplayMatchedUnscrambleWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(wordListFileName);

            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            if(matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine("Match found for {0}: {1}", matchedWord.ScrambledWord, matchedWord.Word);
                }
            }
            else
            {
                Console.WriteLine("No matches have been found");
            }
        }

        private static void WordsInFileInput()
        {
            var filename = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambleWords(scrambledWords);
        }
    }
}
