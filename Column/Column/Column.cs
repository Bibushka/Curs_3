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
            Assert.AreEqual("a", GetColumnLetters(1));
        }

       /* [TestMethod]
        public void GetTwoLetterColumn()
        {
            Assert.AreEqual("zz", GetColumnLetters(728));
        }*/
        
        public string GetColumnLetters(int columnIndex)
        {
            string columnName = string.Empty;
            while (columnIndex != 0)
            {
                columnIndex--;
                columnName = columnName + GetLetter(columnIndex % 26);
                columnIndex = columnIndex / 26;
            }
            return columnName;
        }


        public char GetLetter(int reminder)
        {
            for (int l = 0; l <=25; l++)
                if (reminder == l)
                    return (char)( 'a' + l);
            return ' ';
        }

    }
}
