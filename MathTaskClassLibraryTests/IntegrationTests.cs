using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab6;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void RectangleIntegrationTest()
        {
            IntegrateSimpson ig = new IntegrateSimpson();
            double S = ig.Integrate( 0, 10, new MonoEquation(1, 1).GetValue, 100);
            double expected = 60;
            Assert.AreEqual(expected, S,0.01);
        }
        [TestMethod]
        public void RectangleIntegrationAreInvalidTest1()
        {
            IntegrateSimpson ig = new IntegrateSimpson();
            double S = ig.Integrate( 0, 10, new MonoEquation(1, 1).GetValue, 100);
            double expected = 0;
            Assert.IsTrue(Math.Abs(S - expected) > 0.01);
        }
        [TestMethod]
        public void RectangleIntegrationAreInvalidTest2()
        {
            IntegrateSimpson ig = new IntegrateSimpson();

            Assert.ThrowsException<ArgumentException>(() => 
               ig.Integrate( 10, 0, new MonoEquation(1, 1).GetValue, 100),
               "Правая граница интегирования должны быть больше левой!");
        }
        [TestMethod]
        public void RectangleIntegrationAreInvalidTest3()
        {
            IntegrateSimpson ig = new IntegrateSimpson();

            Assert.ThrowsException<ArgumentException>(() =>
                ig.Integrate( 0, 10, new MonoEquation(1, 1).GetValue, -2),
                "Шаг интегрирования не может быть отрицательным или равным нулю!");
        }
    }
}