using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemCalculator;

namespace SystemCalcTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calc74in10to2()
        {
            var calc = new SystemCalc(10, 2, 74);
            var result = calc.Calculate();
            Assert.AreEqual("1001010", result);
        }

        [TestMethod]
        public void Calc74in10to7()
        {
            var calc = new SystemCalc(10, 7, 74);
            var result = calc.Calculate();
            Assert.AreEqual("134", result);
        }

        [TestMethod]
        public void Calc74in10to16()
        {
            var calc = new SystemCalc(10, 16, 74);
            var result = calc.Calculate();
            Assert.AreEqual("4A", result);
        }
    }
}
