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
            Assert.AreEqual(1, GetNumberOfAnagrams("aaa"));
        }

        public int GetNumberOfAnagrams(string word)
        {
            return 0;
        }
    }
}
