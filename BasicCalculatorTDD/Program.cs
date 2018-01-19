using System;

namespace BasicCalculatorTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello and welcome to my basic calculator developed using TDD");
                Console.WriteLine("Start by writing the two numbers you want to calculate and seperating them with \"Eneter\" ");
                Console.WriteLine("Lastly enter either a operation or the name of the operation you want to calculate with");

                InputConverter inputConverter = new InputConverter();
                Calculator calculator = new Calculator();

                double firstNr = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNr = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                string operation = Console.ReadLine();

                double result = calculator.Calculate(operation,firstNr,secondNr);

                Console.WriteLine(result);            
            }
            catch (System.Exception ex)
            {                
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
