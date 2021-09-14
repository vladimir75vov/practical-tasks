using System;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Первое число: ");
            double doubleOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Действие %, *, /, +, - : ");
            string action = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Второе число: ");
            double doubleTwo = Convert.ToDouble(Console.ReadLine());

            Calculator calculator = new Calculator();

            Console.WriteLine($"Результат: {calculator.Calculate(doubleOne, action, doubleTwo)}");
        }
    }
}

