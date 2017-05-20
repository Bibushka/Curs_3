using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Column
{
    [TestClass]
    public class Column
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("yep", GetColumnLetters(5));
        }

        public string GetColumnLetters(int columnIndex)
        {
            return "noup";
        }
    }
}
