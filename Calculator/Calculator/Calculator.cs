using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static double calculate(double doubleOne, string action, double doubleTwo)
        {
            if (action == "+")
                return (double)doubleOne + doubleTwo;

            if (action == "-")
                return (double)doubleOne - doubleTwo;

            if (action == "*")
                return (double)doubleOne * doubleTwo;

            if (action == "/")
                return (double)doubleOne / doubleTwo;

            if (action == "%")
                return (double)doubleOne % doubleTwo;

            throw new Exception("Не найдена операция!");
        }
        public double Calculate(double doubleOne, string action, double doubleTwo)
        {
            return calculate(doubleOne, action, doubleTwo);
        }
    }
}
