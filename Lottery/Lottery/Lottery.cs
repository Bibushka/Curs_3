using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lottery
{
    [TestClass]
    public class Lottery
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, GetLotteryChances(6));
        }

        public double GetLotteryChances(int numberOfBalls)
        {
            return 0;
        }
    }
}
