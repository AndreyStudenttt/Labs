using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class FirstTests
    {
        [TestMethod]
        public void FirstPrintTest()
        {
            int N = 15;
            First f = new First();
            string actual = f.Print(N);
            string expected = "ABCDEFGHIJKLMNO";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FirstPrintInvalidTest()
        {
            int N = -2;
            First f = new First();
            Assert.ThrowsException<ArgumentException>(() => f.Print(N), "не обработан запрос вне диапазона");
        }
    }
}
