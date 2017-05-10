using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess
{
    [TestClass]
    public class Chess
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, GetNumberOfSquares(2));
        }

        public int GetNumberOfSquares(int boardLength)
        {
            return 0;
        }
    }
}
