using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class FifthTests
    {
        [TestMethod]
        public void SumNumbersTest()
        {
            int actual = new Fifth().Summ(" 123");
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void SumNumbersInvalidTest1()
        {
            Assert.ThrowsException<Exception>(() =>new Fifth().Summ("аываыва123"),"В строке находятся не только цифры");
        }
        [TestMethod]
        public void SumNumbersInvalidTest2()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Fifth().Summ(""),"Строка пустая");
        }
    }
}
