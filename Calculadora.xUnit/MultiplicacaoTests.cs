using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TwCalc = Calculadora.Util;

namespace Calculadora.xUnit
{
    public class MultiplicacaoTests : IDisposable
    {
        private TwCalc.Calculadora _calc;

        public MultiplicacaoTests()
        {
            _calc = new TwCalc.Calculadora(2);
        }
        
        public void Dispose()
        {
            _calc = null;
        }

        [Fact]
        public void TestMultiplicacao()
        {
            Assert.Equal(9, _calc.Multiplicar(3, 3));
        }

        [Fact]
        public void TestMuliplicacaoPrimeiroArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Multiplicar(1, 3);
            });
        }

        [Fact]
        public void TestMuliplicacaoSegundoArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Multiplicar(3, 1);
            });
        }

        [Fact]
        public void TestMuliplicacaoTodosArgumentosAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Multiplicar(1, 1);
            });
        }
    }
}
