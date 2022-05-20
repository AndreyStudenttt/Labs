using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class ThirdTests
    {
        [TestMethod]
        public void YearTest()
        {
            Assert.AreEqual(DateTime.IsLeapYear(2022), Third.Year(2022)==366);
            Assert.AreEqual(DateTime.IsLeapYear(2020), Third.Year(2020)==366);
            Assert.AreEqual(DateTime.IsLeapYear(300), Third.Year(300)== 366);
            Assert.AreEqual(DateTime.IsLeapYear(1200), Third.Year(1200)== 366);
            Assert.AreEqual(DateTime.IsLeapYear(4), Third.Year(4)==366);
        }
        [TestMethod]
        public void Zero()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Third.Year(0), "Отрицательный год");

        }
    }
}
