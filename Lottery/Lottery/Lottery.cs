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
            Assert.AreEqual(13983816, GetLotteryChances(6,49));
        }

        [TestMethod]
        public void GetFiveOfFortynine()
        {
            Assert.AreEqual(1906884, GetLotteryChances(5, 49));
        }

        [TestMethod]
        public void GetFourOfFortynine()
        {
            Assert.AreEqual(211876, GetLotteryChances(4, 49));
        }

        [TestMethod]
        public void GetFiveOfForty()
        {
            Assert.AreEqual(658008, GetLotteryChances(5, 40));
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
            return chance;
        }
    }
}
