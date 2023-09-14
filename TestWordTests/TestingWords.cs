using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestWordTests
{
    [TestClass]
    public class TestingWords
    {
        [TestMethod]
        public void MostShortlyWordInTheLine_2words_The()
        {
            string a = "Hi World!", expected = "Hi";

            TestWord.Methods methods = new TestWord.Methods();
            string b = methods.MostShortlyWorldInTheLine(a);

            StringAssert.StartsWith(b, expected);
        }

        [TestMethod]
        public void CountWordsInLine_6words_6()
        {
            string a = "Hi World!"; int expected = 2;

            TestWord.Methods methods = new TestWord.Methods();
            int b = methods.CountWordsInLine(a);

            Assert.AreEqual(b, expected);
        }
        
        [TestMethod]
        public void CountSimbInLine_6simb_6()
        {
            string a = "World!"; int expected = 6;

            TestWord.Methods methods = new TestWord.Methods();
            int b = methods.CountSimbInLine(a);

            Assert.AreEqual(b, expected);
        }
        
        [TestMethod]
        public void Find9SimbInLine_6simb_6()
        {
            string a = "World! Su", expected = "u";

            TestWord.Methods methods = new TestWord.Methods();
            string b = methods.Find9SimbInLine(a);

            Assert.AreEqual(b, expected);
        }
        
        [TestMethod]
        public void FindNumsInLine_4nums_4()
        {
            string a = "World! Su1234"; int expected = 4;

            TestWord.Methods methods = new TestWord.Methods();
            int b = methods.FindNumsInLine(a);

            Assert.AreEqual(b, expected);
        }
        
        [TestMethod]
        public void FindRowNumsInLine_4nums_4()
        {
            string a = "World! Su1234"; int expected = 4;

            TestWord.Methods methods = new TestWord.Methods();
            int b = methods.FindRowNumsInLine(a);

            Assert.AreEqual(b, expected);
        }
        
        [TestMethod]
        public void FindAMInLine_1AM_1()
        {
            string a = "AM AM"; int expected = 2;

            TestWord.Methods methods = new TestWord.Methods();
            int b = methods.FindAMInLine(a, "AM");

            Assert.AreEqual(b, expected);
        }
    }
}
