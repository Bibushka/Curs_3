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

        [TestMethod]
        public void GetChessBoardSquares()
        {
            Assert.AreEqual(204, GetNumberOfSquares(8));
        }
    
        public int GetNumberOfSquares(int boardLength)
        {
            int numberOfSquares = 0;
            for (int i = 1; i <= boardLength; i++)
                numberOfSquares += i * i;
            return numberOfSquares;
        }
        
    }
}