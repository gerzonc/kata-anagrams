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
    }
}