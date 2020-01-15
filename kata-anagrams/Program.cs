using System;

namespace kata_anagrams
{
    /// <summary>
    /// TODO: Given a file containing one word per line, print out all the combinations of words that are anagrams; 
    /// each line in the output contains all the words from the input that are anagrams of each other.
    /// </summary>

    public class Program
    {
        /// <summary>
        /// Check if one word is anagram of another
        /// </summary>
        /// <param name="word">Word with which you will make the comparison</param>
        /// <param name="anagram">The word you'll like to know if it's anagram to another</param>
        public bool IsAnagram(string word, string anagram)
        {
            if(word.Length != anagram.Length) return false;

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
