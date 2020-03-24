using NUnit.Framework;
using System.Collections.Generic;

namespace kata_anagrams.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Roam_And_Moro_Are_Anagram_EqualsFalse()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram("room", "roam");

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Empty_Space_String_Are_Not_Anagram_Equals_False()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram("", "");

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Null_Strings_Are_Not_Anagram_Equals_False()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram(null, null);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Customers_And_Store_Scum_Are_Anagram_Equals_True()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram("store scum", "customers");

            Assert.AreEqual(true, result);
        }

        [Test]
        public void First_Word_With_Whitespace_And_Second_Without_Equals_True()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram("store scum", "customers");

            Assert.AreEqual(true, result);
        }

        [Test]
        public void List_Of_Words_With_Anagrams_In_The_Same_Line()
        {
            List<string> words = new List<string>() { "restful", "cuneral", "adultery", "customers", "forty five",
                "fluster", "real fun", "true lady", "store scum", "over fifty"};
            Anagrams anagrams = new Anagrams();
            var result = anagrams.SolveKata(words);

            var expected = new List<string>() { "restful fluster", "cuneral real cun", "adultery true lady", "customers store scum",
                "forty five over fifty"};
            Assert.AreEqual(expected, result);
        }


    }
}