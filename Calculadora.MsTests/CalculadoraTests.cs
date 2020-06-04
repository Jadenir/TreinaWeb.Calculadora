using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TwCalc = Calculadora.Util;
namespace Calculadora.MsTests
{
    [TestClass]
    public class CalculadoraTests
    {
        private TwCalc.Calculadora _calc;

        [TestInitialize]
        public void SetUp()
        {
            _calc = new TwCalc.Calculadora();
        }

        [TestMethod]
        public void TestSomar()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SomarComException()
        {
            TwCalc.Calculadora _calc2 = new TwCalc.Calculadora(limiteMinimo: 2);
            _calc2.Somar(1, 1);
        }

        [TestMethod]
        public void TestSubtrair()
        {
            Assert.AreEqual(0, _calc.Subtrair(2, 2));
        }

        [TestMethod]
        [Ignore]
        public void TestMultiplicar()
        {

        }

        [TestMethod]
        [Ignore]
        public void TestDividir()
        {

        }

        [TestCleanup]
        public void CleanUp()
        {
            _calc = null;
        }
    }
}
