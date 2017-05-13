using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class Prefix
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("aaa", GetPrefix("aaab", "aaaaam"));
        }

        public string GetPrefix(string firstString, string secondString)
        {
            string prefix = string.Empty;
            for (int i = 0; i < firstString.Length; i++)
                if (IsCharEqual(firstString[i],secondString[i]))
                    prefix += firstString[i];
            return prefix;
        }

        public bool IsCharEqual(char a, char b)
        {
            if(a == b)
                return true;
            return false;
        }
    }
}
