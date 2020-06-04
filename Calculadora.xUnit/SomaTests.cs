using Moq;
using System;
using Xunit;
using TwCalc = Calculadora.Util;

namespace Calculadora.xUnit
{
    public class SomaTests
    {
        private TwCalc.ICalculadora _calc;
        private Mock<TwCalc.ICalculadora> _mockCalc;

        public SomaTests()
        {
            _mockCalc = new Mock<TwCalc.ICalculadora>();
            _mockCalc.Setup(m => m.Somar(It.IsAny<int>(), It.IsAny<int>())).Returns(4);
            _mockCalc.Setup(m => m.Somar(It.IsAny<int>(), -1)).Throws<ArgumentOutOfRangeException>();
            _mockCalc.Setup(m => m.Somar(-1, It.IsAny<int>())).Throws<ArgumentOutOfRangeException>();
            _calc = _mockCalc.Object;
        }

        [Fact]
        public void TestSomaNumerosPositivos()
        {
            Assert.Equal(4, _calc.Somar(2, 2));
            _mockCalc.Verify(m => m.Somar(2, 2));
        }

        [Fact]
        public void Test()  
        {
            Assert.Equal(4, _calc.Somar(50, 50));
        }

        [Fact]
        public void TestSomaAbaixoDoLimitePrimeiroArgumento()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Somar(-1, 0);
            });
        }

        [Fact]
        public void TestSomaAbaixoDoLimiteSegundoArgumento()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Somar(0, -1);
            });
        }
    }
}
