using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace kata_anagrams
{
    public class Anagrams
    {
        /// <summary>
        /// Check if one word is anagram of another
        /// </summary>
        /// <param name="word">Word with which you will make the comparison</param>
        /// <param name="anagram">The word you'll like to know if it's anagram to another</param>
        public bool IsAnagram(string word, string anagram)
        {
            if (string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(word) || !HasWordLetters(word, anagram)) 
                return false;

            return true;
        }

        public bool HasWordLetters(string word, string anagram)
        {
            anagram = Regex.Replace(anagram, @"\s", string.Empty);
            foreach(var i in anagram)
            {

                if (!word.Contains(i))
                   return false;
            }

            return true;
        }
    }
}
