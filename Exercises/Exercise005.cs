using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercise005
    {
        //The length of pangram could not be less then length of the alphabet
        const int MIN_PANGRAM_LENGTH = 26;

        public bool IsPangram(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length < MIN_PANGRAM_LENGTH) 
            {
                return false;
            }

            //setOfInputSymbols will contain input symbols (in lower case) without spaces and duplicates
            HashSet<char> setOfInputSymbols = new HashSet<char>(input.Trim().ToLower());

            //If any letter from 'a' to 'z' is missing in input string (setOfInputSymbols) - it is not a pangram 
            for (char symbol = 'a'; symbol < 'z'; symbol++) 
            {
                if (!setOfInputSymbols.Contains(symbol)) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
