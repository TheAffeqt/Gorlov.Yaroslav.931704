using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondLab.Models
{
    public class CalcModel
    {
        public double value1 { get; set; }
        public double value2 { get; set; }
        public string operation { get; set; }

        public CalcModel()
        {

        }

        public CalcModel(double firstValue, double secondValue, string Operation)
        {
            value1 = firstValue;
            value2 = secondValue;
            operation = Operation;
        }

        public double Calculate()
        {
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

            return result;
        }
    }
}
