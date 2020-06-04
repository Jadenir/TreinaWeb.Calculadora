using Calculadora.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwCalc = Calculadora.Util;

namespace Calculadora.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        // GET: Calculadora
        public ActionResult Index(CalculadoraModel model = null)
        {
            if (model != null)
            {
                TwCalc.Calculadora calculadora = new TwCalc.Calculadora();
                switch (model.Operacao)
                {
                    case 0:
                        model.Resultado = calculadora.Somar(model.PrimeiroNumero, model.SegundoNumero);
                        break;
                    case 1:
                        model.Resultado = calculadora.Subtrair(model.PrimeiroNumero, model.SegundoNumero);
                        break;
                    case 2:
                        model.Resultado = calculadora.Multiplicar(model.PrimeiroNumero, model.SegundoNumero);
                        break;
                    case 3:
                        model.Resultado = calculadora.Dividir(model.PrimeiroNumero, model.SegundoNumero);
                        break;
                }    
            }
            else
            {
                model = new CalculadoraModel();
            }
            return View(model);
        }
    }
}