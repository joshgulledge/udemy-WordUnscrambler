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

        static void Main(string[] args)
        {
            try
            {
                bool continueWordUnscramble = true;

                do
                {
                    Console.WriteLine(Constants.Constants.OptionsOnHowToEnterScrambledWords);
                    var option = Console.ReadLine() ?? string.Empty;

                    switch (option.ToUpper())
                    {
                        case Constants.Constants.File:
                            Console.Write(Constants.Constants.EnterScrambledWordsViaFile);
                            WordsInFileInput();
                            break;
                        case Constants.Constants.Manual:
                            Console.Write(Constants.Constants.EnterScrabledWordsManually);
                            WordsManualInput();
                            break;
                        default:
                            Console.Write(Constants.Constants.EnterScrambledWordsOptionsNotRecognized);
                            break;
                    }

                    var continueDecisionProcess = string.Empty;
                    do
                    {
                        Console.WriteLine(Constants.Constants.OptionsOnConinueProgram);
                        continueDecisionProcess = (Console.ReadLine() ?? string.Empty);

                    } while (
                        !continueDecisionProcess.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
                        !continueDecisionProcess.Equals("N", StringComparison.OrdinalIgnoreCase));

                    continueWordUnscramble = continueDecisionProcess.Equals("Y", StringComparison.OrdinalIgnoreCase);

                } while (continueWordUnscramble);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Constants.Constants.ErrorProgramWillBeTerminated + ex.Message);
            }
            
        }

        private static void WordsManualInput()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = manualInput.Split(',');
            DisplayMatchedUnscrambleWords(scrambledWords);
        }

        private static void DisplayMatchedUnscrambleWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(Constants.Constants.wordListFileName);

            Console.WriteLine("WordList should have words" + wordList[3]);

            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            if(matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine(Constants.Constants.MatchFound, matchedWord.ScrambledWord, matchedWord.Word);
                }
            }
            else
            {
                Console.WriteLine(Constants.Constants.MatchNotFound);
            }
        }

        private static void WordsInFileInput()
        {
            try
            {
                var filename = Console.ReadLine() ?? string.Empty;
                string[] scrambledWords = _fileReader.Read(filename);
                DisplayMatchedUnscrambleWords(scrambledWords);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Constants.Constants.ErrorScrambledWordsCannotBeLoaded + ex.Message);
            }
        }
    }
}
