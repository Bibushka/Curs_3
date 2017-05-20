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
            Assert.AreEqual('g', GetColumnLetters(7));
        }

        public char GetColumnLetters(int columnIndex)
        {
            for (int l = 1; l <= 26; l++)
                if (columnIndex == l)
                    return (char)(97 + l-1);
            return '\n';
        }
    }
}
