using NUnit.Framework;

namespace BasicCalculatorTDD
{
    public class CalculatorTest
    {
        private Calculator _calculator;

        // The Calculator is instantiated in the SetUp, to be used in the test methods
        // This way the same instance will be used inn all the tests
        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        // Test the calculate method with a non-symbol operation
        [Test]
        public void Calculate_AddsTwoNumbersWithNonSymbolOperation_Returns3()
        {
            var _calculator = new Calculator();
            int nr1 = 1;
            int nr2 = 2;
            double result = _calculator.Calculate("add", nr1, nr2);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}