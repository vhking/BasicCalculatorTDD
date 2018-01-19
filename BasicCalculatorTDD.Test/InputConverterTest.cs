using NUnit.Framework;

namespace BasicCalculatorTDD.Test
{    
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();  
              
        [Test]
        public void ConvertInputToNumeric_ConvertsValidInputIntoDouble_ReturnsTrue()
        {
            string input = "10";
            double convertedInput = _inputConverter.ConvertInputToNumeric(input);
            Assert.That(10,Is.EqualTo(convertedInput) );
        }
        
    }
}