using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lottery
{
    [TestClass]
    public class Lottery
    {
        [TestMethod]
        public void GetSixOfFortynine()
        {
            Assert.AreEqual(0.0000000715, GetLotteryChances(6,49),1000000000);
        }

        [TestMethod]
        public void GetFiveOfFortynine()
        {
            Assert.AreEqual(0.0000184, GetLotteryChances(5, 49), 1000000);
        }

        [TestMethod]
        public void GetFourOfFortynine()
        {
            Assert.AreEqual(0.000969, GetLotteryChances(4, 49), 100000);
        }

        [TestMethod]
        public void GetFiveOfForty()
        {
            Assert.AreEqual(0.000151, GetLotteryChances(5, 40), 100000);
        }

        public double GetLotteryChances(int numberOfBalls, int totalNumberOfBalls)
        {
            double chance=1;
            while (numberOfBalls != 0)
            {
                chance = chance * totalNumberOfBalls / numberOfBalls;
                totalNumberOfBalls--;
                numberOfBalls--;
            }
            return 1/chance;
        }
    }
}
