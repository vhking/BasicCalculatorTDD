using System;

namespace BasicCalculatorTDD
{
    public class Calculator
    {
        public double Calculate(string operation, double firstNr, double secondNr)
        {
            double result;

            switch (operation)
            {
                case "add":
                case "+":
                    result = firstNr + secondNr;
                    break;
                case "subtract":
                case "-":
                    result = firstNr + secondNr;
                    break;
                case "multiply":
                case "*":
                    result = firstNr + secondNr;
                    break;
                case "divide":
                case "/":
                    result = firstNr + secondNr;
                    break;
                default:
                    throw new InvalidOperationException("The operation is not recongnized by the calculator");
                   
            }

            return result;
        }
    }
}
