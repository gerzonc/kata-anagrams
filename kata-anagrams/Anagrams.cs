using System;
using System.Collections.Generic;
using System.Text;

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
            if (word.Length != anagram.Length) 
                return false;

            if(!word.Contains(anagram))
                return false;

            return true;
        }
    }
}
