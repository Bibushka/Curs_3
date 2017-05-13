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
            Assert.AreEqual("yep", GetPrefix("i", "n"));
        }

        public string GetPrefix(string firstString, string secondString)
        {
            return "noup";
        }
    }
}
