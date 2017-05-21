using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Column
{
    [TestClass]
    public class Column
    {
        [TestMethod]
        public void GetOneLetterColumn()
        {
            Assert.AreEqual("z", GetColumnLetters(26));
        }

        [TestMethod]
        public void GetTwoLetterColumn()
        {
            Assert.AreEqual("bz", GetColumnLetters(80));
        }

        public string GetColumnLetters(int columnIndex)
        {
            string columnName = string.Empty;
            if(columnIndex/27==0)
                return columnName + GetLastLetter(columnIndex % 27);
            if (columnIndex / 27 <= 26)
                return columnName + GetLastLetter(columnIndex / 27) + GetLastLetter(columnIndex % 27);
            return columnName;
        }

        public char GetLastLetter(int reminder)
        {
            for (int l = 1; l <= 26; l++)
                if (reminder == l)
                    return (char)(96 + l);
            return ' ';
        }

    }
}
