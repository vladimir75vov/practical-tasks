using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        bool StringIsDigits(string s)
        {
            double num;
            if (double.TryParse(s, out num))
            {
                return true;
            }
            return false;
        }

        [TestMethod()]
        public void CheckOperationAddition()
        {
            double doubleOne = 12.1;
            string action = "+";
            double doubleTwo = 12.3;

            bool expected = true;

            bool actual = StringIsDigits(Calculator.calculate(doubleOne, action, doubleTwo).ToString());
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckOperationSubtraction()
        {
            double doubleOne = 12.1;
            string action = "-";
            double doubleTwo = 12.3;

            bool expected = true;

            bool actual = StringIsDigits(Calculator.calculate(doubleOne, action, doubleTwo).ToString());
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckOperationMultiplication()
        {
            double doubleOne = 12.1;
            string action = "*";
            double doubleTwo = 12.3;

            bool expected = true;

            bool actual = StringIsDigits(Calculator.calculate(doubleOne, action, doubleTwo).ToString());
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckOperationDivision()
        {
            double doubleOne = 12.1;
            string action = "/";
            double doubleTwo = 12.3;

            bool expected = true;

            bool actual = StringIsDigits(Calculator.calculate(doubleOne, action, doubleTwo).ToString());
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckOperationPercent()
        {
            double doubleOne = 12.1;
            string action = "%";
            double doubleTwo = 12.3;

            bool expected = true;

            bool actual = StringIsDigits(Calculator.calculate(doubleOne, action, doubleTwo).ToString());
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckOperationEror()
        {
            double doubleOne = 12.1;
            string action = "^";
            double doubleTwo = 12.3;

            bool expected = true;

            bool actual = StringIsDigits(Calculator.calculate(doubleOne, action, doubleTwo).ToString());
            // Assert
            Assert.IsFalse(actual);
        }
    }
}