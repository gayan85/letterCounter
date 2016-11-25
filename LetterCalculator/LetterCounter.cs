using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LetterCalculator
{
    public class LetterCounter
    {
        public int Count(string word)
        {
            var letters = GetLetters(word);
            return letters.Sum(letter => char.ToUpper(letter) - 64);
        }

        private static char[] GetLetters(string word)
        {
            word = Regex.Replace(word, @"[^A-Za-z0-9]+", string.Empty);
            var chars = word.ToCharArray();
            return chars;
        }
    }

}
