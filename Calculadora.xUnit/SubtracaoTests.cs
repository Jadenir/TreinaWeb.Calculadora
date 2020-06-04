using System;
using Xunit;
using TwCalc = Calculadora.Util;

namespace Calculadora.xUnit
{
    public class SubtracaoTests : IDisposable
    {
        private TwCalc.Calculadora _calc;

        public SubtracaoTests()
        {
            _calc = new TwCalc.Calculadora();
        }

        public void Dispose()
        {
            _calc = null;
        }

        [Fact]
        public void TestSubtrairNumerosPositivos()
        {
            Assert.Equal(0, _calc.Subtrair(2, 2));
        }

        [Fact]
        public void TestSubtrairAbaixoDoLimitePrimeiroArgumento()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Subtrair(-1, 0);
            });
        }

        [Fact]
        public void TestSubtrairAbaixoDoLimiteSegundoArgumento()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Subtrair(0, -1);
            });
        }

        
    }
}
