using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculadora.xUnit
{
    public class ChromeTests : IDisposable
    {
        private IWebDriver _driver;

        public ChromeTests()
        {
            _driver = new ChromeDriver();
        }

        public void Dispose()
        {
            if (_driver != null)
            {
                _driver.Close();
            }
        }

        [Fact]
        public void TestSomarNumeros()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/Calculadora/Index");
            IWebElement textBoxPrimeiroNumero = _driver.FindElement(By.Name("PrimeiroNumero"));
            textBoxPrimeiroNumero.SendKeys("2");
            IWebElement textBoxSegundoNumero = _driver.FindElement(By.Name("SegundoNumero"));
            textBoxSegundoNumero.SendKeys("2");
            List<IWebElement> options = _driver.FindElements(By.TagName("option")).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals("Adição"))
                {
                    element.Click();
                    break;
                }
            }
            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();
            Assert.Equal("4", _driver.FindElement(By.Name("Resultado")).GetAttribute("value").ToString());
        }

        [Fact]
        public void TestSubtrairNumeros()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/Calculadora/Index");
            IWebElement textBoxPrimeiroNumero = _driver.FindElement(By.Name("PrimeiroNumero"));
            textBoxPrimeiroNumero.SendKeys("5");
            IWebElement textBoxSegundoNumero = _driver.FindElement(By.Name("SegundoNumero"));
            textBoxSegundoNumero.SendKeys("2");
            List<IWebElement> options = _driver.FindElements(By.TagName("option")).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals("Subtração"))
                {
                    element.Click();
                    break;
                }
            }
            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();
            Assert.Equal("2", _driver.FindElement(By.Name("Resultado")).GetAttribute("value").ToString());
        }

        [Fact]
        public void TestMultiplicarNumeros()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/Calculadora/Index");
            IWebElement textBoxPrimeiroNumero = _driver.FindElement(By.Name("PrimeiroNumero"));
            textBoxPrimeiroNumero.SendKeys("5");
            IWebElement textBoxSegundoNumero = _driver.FindElement(By.Name("SegundoNumero"));
            textBoxSegundoNumero.SendKeys("2");
            List<IWebElement> options = _driver.FindElements(By.TagName("option")).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals("Multiplicação"))
                {
                    element.Click();
                    break;
                }
            }
            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();
            Assert.Equal("10", _driver.FindElement(By.Name("Resultado")).GetAttribute("value").ToString());
        }

        [Fact]
        public void TestDividirNumeros()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/Calculadora/Index");
            IWebElement textBoxPrimeiroNumero = _driver.FindElement(By.Name("PrimeiroNumero"));
            textBoxPrimeiroNumero.SendKeys("6");
            IWebElement textBoxSegundoNumero = _driver.FindElement(By.Name("SegundoNumero"));
            textBoxSegundoNumero.SendKeys("2");
            List<IWebElement> options = _driver.FindElements(By.TagName("option")).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals("Divisão"))
                {
                    element.Click();
                    break;
                }
            }
            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();
            Assert.Equal("3", _driver.FindElement(By.Name("Resultado")).GetAttribute("value").ToString());
        }
    }
}
