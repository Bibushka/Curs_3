using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class Cube
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, GetCubeNumber(1));
        }

        public double GetCubeNumber(int k)
        {
            return 0;
        }
    }
}
