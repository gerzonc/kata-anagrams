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
        /// <param name="anagram">The word you'll like to know if it's anagram to the other</param>
        public bool IsAnagram(string word, string anagram)
        {
            return string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(anagram) || !HasWordLetters(word, anagram) 
                ? false 
                : true;
        }

        /// <summary>
        /// Check if one string contains every character of the other
        /// </summary>
        /// <param name="word">Word with which you will make the comparison</param>
        /// <param name="anagram">The word you'll like to know if it's anagram to the other</param>
        /// <returns></returns>
        public bool HasWordLetters(string word, string anagram)
        {
            anagram = Regex.Replace(anagram, @"\s", string.Empty);
            word = Regex.Replace(word, @"\s", string.Empty);

            foreach (var i in anagram)
                if (!word.Contains(i))
                    return false;

            return true;
        }

        public List<string> SolveKata(List<string> words)
        {
            List<string> anagrams = new List<string>();
            
            for(int i = 0; i < words.Count; i++)
            {
                bool isAnagram = false;
                for (int j = i + 1; j < words.Count; j++)
                {
                    if(IsAnagram(words[i], words[j]))
                    {
                        isAnagram = true;
                        words[i] += $" {words[j]}";
                        words.RemoveAt(j);
                    }
                }
                if(isAnagram)
                    anagrams.Add(words[i]);
            }
            return anagrams;
        }
    }
}
