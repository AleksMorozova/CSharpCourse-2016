using System;
using NUnit.Framework;
using TDDTask;

namespace NUnitTestProject
{
    [TestFixture]
    public class TDDTaskTest
    {
        [Test]
        public void SumTest()
        {
            Calculator calc = new Calculator();
            double result = calc.Sum(10, -15);
            double expected = -5;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SubtractTest()
        {
            Calculator calc = new Calculator();
            double result = calc.Subtract(10, -15);
            double expected = 25;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            double result = calc.Multiply(10, -15);
            double expected = -150;

            Assert.AreEqual(expected, result);
        }
    }
}