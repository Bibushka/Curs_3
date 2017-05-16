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
            Assert.IsTrue(IsPanagram("The quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void IsNotPanagram()
        {
            Assert.IsFalse(IsPanagram("the quick brown fox jumps over the lzy dog"));
        }

        public bool IsPanagram(string phrase)
        {
            string alphanbet = "abcdefghijklmnopqrstuvwxyz";
            int counter=0;
            for (int i = 0; i < alphanbet.Length; i++)
                if (IsLetterInPhrase(alphanbet[i], phrase))
                    counter++;
            return counter == 26;
        }

        public bool IsLetterInPhrase(char letter, string phrase)
        {
            for (int i = 0; i < phrase.Length; i++)
                if (letter == phrase[i])
                    return true;
            return false;
        }
    }
}
