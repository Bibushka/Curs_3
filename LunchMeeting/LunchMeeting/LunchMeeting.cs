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
            int multiplier = myLunchTime * friendLunchTime;
            while (myLunchTime != friendLunchTime)
            {
                if (myLunchTime > friendLunchTime)
                    myLunchTime -= friendLunchTime;
                else
                    friendLunchTime -= myLunchTime;
            }
            return multiplier / myLunchTime;
        }
    }
}
