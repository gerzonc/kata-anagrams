using System;
using System.IO;
using System.Linq;

namespace kata_anagrams
{
    /// <summary>
    /// TODO: Given a file containing one word per line, print out all the combinations of words that are anagrams; 
    /// each line in the output contains all the words from the input that are anagrams of each other.
    /// </summary>

    class Program
    {
        
        static void Main(string[] args)
        {
            var anagram = new Anagrams();
            var words = File.ReadAllLines("wordlist.txt").ToList();
            var result = anagram.SolveKata(words);

            foreach(var word in result)
                Console.WriteLine(word);
        }
    }
}
