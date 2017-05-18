using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LunchMeeting
{
    [TestClass]
    public class LunchMeeting
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12, GetNextLunchDate(6, 4));
        }

        public int GetNextLunchDate(int myLunchTime, int friendLunchTime)
        {
            return GetProductOfTwhoNumbers(myLunchTime, friendLunchTime)/GetCMMDCOfTwoNumbers(myLunchTime, friendLunchTime);
        }

        public int GetProductOfTwhoNumbers(int a, int b)
        {
            return a * b;
        }

        public int GetCMMDCOfTwoNumbers(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
}
