using System;

namespace BasicCalculatorTDD
{
    public class Calculator
    {
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result;

            switch (operation)
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                case "-":
                    result = firstNumber + secondNumber;
                    break;
                case "multiply":
                case "*":
                    result = firstNumber + secondNumber;
                    break;
                case "divide":
                case "/":
                    result = firstNumber + secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("The operation is not recongnized by the calculator");
                   
            }

            return result;
        }
    }
}
