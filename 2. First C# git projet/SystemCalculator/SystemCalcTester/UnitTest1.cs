using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemCalculator;

namespace SystemCalcTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calc74in10to2system1001010()
        {
            var calc = new SystemCalc(10.ToString(), 2, 74.ToString());
            var result = calc.Calculate();
            Assert.AreEqual("1001010", result);
        }

        [TestMethod]
        public void Calc74in10to7systemIs134()
        {
            var calc = new SystemCalc(10.ToString(), 7, 74.ToString());
            var result = calc.Calculate();
            Assert.AreEqual("134", result);
        }

        [TestMethod]
        public void Calc74in10to16systemIs4A()
        {
            var calc = new SystemCalc(10.ToString(), 16, 74.ToString());
            var result = calc.Calculate();
            Assert.AreEqual("4A", result);
        }
    }
}
