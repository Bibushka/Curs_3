using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class Panagram
    {
        [TestMethod]
        public void IsTruePanagram()
        {
            Assert.AreEqual(true, IsPanagram("The quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void IsNotPanagram()
        {
            Assert.AreEqual(false, IsPanagram("the quick brown fox jumps over the lzy dog"));
        }

        public bool IsPanagram(string fraze)
        {
            string alphanbet = "abcdefghijklmnopqrstuvwxyz";
            int counter=0;
            for (int i = 0; i < alphanbet.Length; i++)
                if (IsLetterInFraze(alphanbet[i], fraze)==1)
                    counter++;
            if (counter == 26)
                return true;
            return false;
        }

        public int IsLetterInFraze(char letter, string fraze)
        {
            for (int i = 0; i < fraze.Length; i++)
                if (letter == fraze[i])
                    return 1;
            return 0;
        }
    }
}
