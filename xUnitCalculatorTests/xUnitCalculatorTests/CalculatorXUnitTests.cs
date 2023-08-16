using CSharpCalculator;

namespace xUnitCalculatorTests
{
    public class CalculatorXUnitTests
    {
        private Calculator _calculator;

        public CalculatorXUnitTests() 
        {
        _calculator = new Calculator();
        }

        [Theory]
        [InlineData(25, 64, 89)]
        [InlineData(-56, -6.25, -62.25)]
        public void AditionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = _calculator.Add(firstArgument, secondArgument);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(5, 8, 40)]
        [InlineData(23, 0, 0)]
        public void MultiplicationTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = _calculator.Multiply(firstArgument, secondArgument);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(-6, 23, -29)]
        public void SubtractionTest(double firstArgument, double secondArgument, double expectedResult)
        {
            double actualResult = _calculator.Sub(firstArgument, secondArgument);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData('a', "23")]
        [InlineData("test", 23)]
        public void SubExceptionTest(object numberToConvert, object subtrahendValue)
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Sub(numberToConvert, subtrahendValue));
        }

        [Theory]
        [InlineData("test", 2)]
        public void PowExceptionTest(object numberToConvert, object Value)
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Pow(numberToConvert, Value));
        }

        [Theory]
        [InlineData('g')]
        [InlineData("TEST")]
        public void AbsExceptionTest(object valueToConvert)
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Abs(valueToConvert));
        }

        [Theory]
        [InlineData("test")]
        public void SinExceptionTest(object valueToConvert)
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Sin(valueToConvert));
        }

        [Theory]
        [InlineData("cos")]
        [InlineData('g')]
        public void CosExceptionTest(object valueToConvert)
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Cos(valueToConvert));
        }

        [Theory]
        [InlineData("negative")]
        public void IsPositiveExceptionTest(object valueToConvert)
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.isPositive(valueToConvert));
        }

        [Theory]
        [InlineData("Positive")]
        public void IsNegativeExceptionTest(object valueToConvert)
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.isNegative(valueToConvert));
        }
    }
}