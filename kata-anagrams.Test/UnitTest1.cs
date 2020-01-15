using NUnit.Framework;

namespace kata_anagrams.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Roam_And_Moro_Are_Anagram_Equals_False()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram("room", "roam");

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Empty_Space_Or_Null_String_Are_Not_Anagram_Equals_False()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram("", "");

            Assert.AreEqual(false, result);
        }

        [Test]
        public void Customers_And_Store_Scum_Are_Anagram_Equals_True()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram("customers", "store scum");

            Assert.AreEqual(true, result);
        }

        [Test]
        public void First_Word_With_Whitespace_And_Second_Without_Equals_True()
        {
            Anagrams anagrams = new Anagrams();
            var result = anagrams.IsAnagram("store scum", "customers");

            Assert.AreEqual(true, result);
        }


    }
}