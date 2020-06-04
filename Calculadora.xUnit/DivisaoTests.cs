using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TwCalc = Calculadora.Util;

namespace Calculadora.xUnit
{
    public class DivisaoTests : IDisposable
    {
        private TwCalc.Calculadora _calc;

        public DivisaoTests()
        {
            _calc = new TwCalc.Calculadora();
        }

        public void Dispose()
        {
            _calc = null;
        }

        [Fact]
        public void TestDivisao()
        {
            Assert.Equal(2, _calc.Dividir(4, 2));
        }

        [Fact]
        public void TestDivisaoPrimeiroArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Dividir(-2, 2);
            });
        }

        [Fact]
        public void TestDivisaoSegundoArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Dividir(2, -2);
            });
        }

        [Fact]
        public void TestDivisaoTodosArgumentosAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Dividir(-1, -1);
            });
        }

        [Fact]
        public void TestSegundoArgumentoZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                _calc.Dividir(2, 0);
            });
        }
    }
}
