using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class Anagram
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, GetNumberOfAnagrams("aaa"));
        }

        public int GetNumberOfAnagrams(string word)
        {
            int count = 1;
            for (int i = 1; i <= word.Length; i++)
                count *= i;
            return count;
        }
    }
}
