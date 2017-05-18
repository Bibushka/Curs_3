using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void TestForKOne()
        {
            Assert.AreEqual(192, GetCubeNumber(1));
        }

        public int GetCubeNumber(int k)
        {
            int kCount = 0;
            for (int i = 0; i < 1000; i++)
                if (i * i * i % 1000 == 888)
                {
                    kCount++;
                    if (kCount == k)
                        return i;
                }
            return 0;
        }
    }
}
