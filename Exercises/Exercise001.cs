using System;
using System.Collections.Generic;
using Exercises.Models;
using System.Linq;


namespace Exercises
{
    public class Exercise001
    {
        const int MATH_ROUND_PRICE_DIGITS = 2;
        const double PERCENT = 0.01;
        const string LINUX = "Linux";

        public string CapitalizeWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return word;
            }
            
            // Capitalize first letter in string and add the rest of string
            return $"{char.ToUpper(word[0])}{word.Substring(1)}";

        }

        public string GenerateInitials(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                return string.Empty;
            }

            // Returns first letters of firstName and lastName, sepatated by point
            return $"{firstName[0]}.{lastName[0]}";
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            //For advanced challenge
            if (originalPrice < 0) throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            if (vatRate < 0) throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");

            //Returns originalPrice increased on certain percent(vatRate)
            return Math.Round((originalPrice * vatRate * PERCENT + originalPrice), MATH_ROUND_PRICE_DIGITS);
        }

        public string Reverse(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return sentence;
            }

            char[] chars = sentence.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public int CountLinuxUsers(List<User> users)
        {
            if (users == null)
            {
                return 0;
            }

            // Will count and return number of users satisfying the condition
            return users.Where(user => user.Type == LINUX).Count();
        }
    }
}
