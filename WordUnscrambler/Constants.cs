using System;
namespace WordUnscrambler.Constants
{
    public class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords = "Enter scrambled word(s) manually or as a file: F-file/M-manual";
        public const string OptionsOnConinueProgram = "Would you like to continue? Y/N?";

        public const string EnterScrambledWordsViaFile = "Enter full path including the file name: ";
        public const string EnterScrabledWordsManually = "Enter word(s) manually (seperare by commas if multiple): ";
        public const string EnterScrambledWordsOptionsNotRecognized = "The optino was not recognized.";

        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error";
        public const string ErrorProgramWillBeTerminated = "The Program will be terminated";

        public const string MatchFound = "Match found for {0}: {1}";
        public const string MatchNotFound = "No Matched have been found";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string wordListFileName = "wordlist.txt";

    }
}
