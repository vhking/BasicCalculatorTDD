using System;

namespace BasicCalculatorTDD
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string input)
        {
            double convertedInput;
            if (!double.TryParse(input, out convertedInput)) throw new ArgumentException("Expected a numeric value.");
            {
                return convertedInput;    
            }
        }
    }
}