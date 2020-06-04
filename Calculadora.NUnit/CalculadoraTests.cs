using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwCalc = Calculadora.Util;

namespace Calculadora.NUnit
{
    [TestFixture]
    public class CalculadoraTests
    {
        private TwCalc.Calculadora  _calc;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _calc = new TwCalc.Calculadora();
        }

        [Test]
        public void TestSomar()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [Test]
        public void TestSubtrair()
        {
            Assert.IsTrue(_calc.Subtrair(2, 2) == 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestException()
        {
            TwCalc.Calculadora calc = new TwCalc.Calculadora(limiteMinimo: 2);
            calc.Somar(1, 1);
        }

        [Test]
        [Ignore("Teste ainda não foi implementado")]
        public void TestMultiplicar()
        {
            
        }

        [Test]
        [Ignore("Teste ainda não foi implementado")]
        public void TestDividir()
        {
            
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            _calc = null;
        }
    }
}
