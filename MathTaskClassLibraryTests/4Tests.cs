using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class FourthTests
    {
        [TestMethod]
        public void MailTest()
        {
            bool actual = new Fourth().Mail("hello@world.ru");
            Assert.IsTrue(actual);
        }
        

        [TestMethod]
        public void InvalidMailTest1()
        {
            Fourth actual = new Fourth();
            Assert.IsFalse(actual.Mail("absssssssssssss"));
        }
        [TestMethod]
        public void InvalidMailTest2()
        {
            Fourth actual = new Fourth();
            Assert.ThrowsException<ArgumentNullException>(() => actual.Mail(null), "пустая строка");

            Assert.IsFalse(actual.Mail(String.Empty));
        }
      
    }
}
