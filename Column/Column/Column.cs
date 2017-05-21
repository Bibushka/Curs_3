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
            Assert.AreEqual('y', GetColumnLetters(25));
        }

        public char GetColumnLetters(int columnIndex)
        {
            return GetLastLetter(columnIndex % 27);
        }

        public char GetLastLetter(int reminder)
        {
            for (int l = 1; l <= 26; l++)
                if (reminder == l)
                    return (char)(96 + l);
            return ' ';
        }

    }
}
