using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondLab.Models;

namespace SecondLab.Controllers
{
    public class CalcController : Controller
    {
        private readonly ILogger<CalcController> _logger;

        public CalcController(ILogger<CalcController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManualParsingInSingleAction()
        {
            return View();
        }

        public IActionResult ManualParsingInSeparateActions()
        {
            return View();
        }

        public IActionResult ModelBindingParametrs()
        {
            return View();
        }

        public IActionResult ModelBindingSeparateModel()
        {
            return View();
        }

        public IActionResult CountOne()
        {
            if (Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                int value = Convert.ToInt32(this.Request.Form["input1"]);
                int value2 = Convert.ToInt32(this.Request.Form["input2"]);
                string operation = this.Request.Form["operation"];

                double result;

                switch (operation)
                {
                    case "+":
                        result = value + value2;
                        break;
                    
                    case "-":
                        result = value - value2;
                        break;
                    
                    case "*":
                        result = value * value2;
                        break;
                    
                    case "/":
                        result = value / value2;
                        break;
                    
                    default:
                        result = 0;
                        break;
                }

                ViewBag.input1 = value;
                ViewBag.input2 = value2;
                ViewBag.operation = operation;
                ViewBag.result = result;

            }

            return View("Result");
        }

        [HttpPost]
        public IActionResult CountTwo()
        {
            if (Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                int value1 = Convert.ToInt32(this.Request.Form["input1"]);
                int value2 = Convert.ToInt32(this.Request.Form["input2"]);
                string operation = this.Request.Form["operation"];

                double result;

                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    
                    case "-":
                        result = value1 - value2;
                        break;
                    
                    case "*":
                        result = value1 * value2;
                        break;
                    
                    case "/":
                        result = value1 / value2;
                        break;
                    
                    default:
                        result = 0;
                        break;
                }

                ViewBag.input1 = value1;
                ViewBag.input2 = value2;
                ViewBag.operation = operation;
                ViewBag.result = result;

            }

            return View("Result");
        }

        [HttpPost]
        public IActionResult CountThree(int input1, int input2, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = input1 + input2;
                    break;
                
                case "-":
                    result = input1 - input2;
                    break;
                
                case "*":
                    result = input1 * input2;
                    break;
                
                case "/":
                    result = input1 / input2;
                    break;
                default:
                    result = 0;
                    break;
            }

            ViewBag.input1 = input1;
            ViewBag.input2 = input2;
            ViewBag.operation = operation;
            ViewBag.result = result;

            return View("Result");
        }


        [HttpPost]
        public IActionResult CountFour(CalcModel calcModel)
        {

            ViewBag.input1 = calcModel.value1;
            ViewBag.input2 = calcModel.value2;
            ViewBag.operation = calcModel.operation;
            ViewBag.result = calcModel.Calculate();

            return View("Result");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
