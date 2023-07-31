using CSharpCalculator;

namespace NUnitCalculatorTests
{
    public class CalculatorNUnitTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }
                                              
        [TestCase(-21, 21)]
        [TestCase(25, 25)]
        public void absTest(double numberToTest, double expectedResult)
        {
            var absResult = _calculator.Abs(numberToTest);
            Assert.That(expectedResult, Is.EqualTo(absResult)); 
        }
                                                 
        [TestCase(225, 15)]
        [TestCase(400, 20)]
        public void sqrtTest(double numberToTest, double expectedResult) 
        {
            var sqrtResult = _calculator.Sqrt(numberToTest);
            Assert.That(expectedResult, Is.EqualTo(sqrtResult));
        }

        [TestCase(2, 2, 4)]
        [TestCase(3, -4, -64)]
        public void powTest(double numberToTest, int powerToTest, double expectedResult)
        {
            var powResult = _calculator.Pow(powerToTest, numberToTest);
            Assert.That(expectedResult, Is.EqualTo(powResult));
        }

        [TestCase(93, 3, 31)]
        [TestCase(-400, -20, 20)]
        public void divisionTest(double numerator, double denominator, double expectedResult)
        {
            var devideResult = _calculator.Divide(numerator, denominator);
            Assert.AreEqual(expectedResult, devideResult);
        }

        [TestCase(-400, true)]
        public void isNegativeTest(double number, bool expectedResult)
        {
            var actualResult = _calculator.isNegative(number);
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [TestCase(200, true)]
        public void isPositiveTest(double number, bool expectedResult)
        {
            var actualResult = _calculator.isPositive(number);
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [TestCase(90)]
        public void sinTest(double angleValueInDegrees)
        {
            double expectedResult = Math.Sin(angleValueInDegrees);
            var actualResult = _calculator.Sin(angleValueInDegrees);
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [TestCase(150)]
        public void cosTest(double angleValueInDegrees)
        {
            double expectedResult = Math.Cos(angleValueInDegrees);
            var actualResult = _calculator.Cos(angleValueInDegrees);
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [TestCase(-400)]
        public void sqrtNegativeValueTest(double number)
        {
            var result = _calculator.Sqrt(number);
            Assert.IsNaN(result);
        }

        [TestCase(22, 0.0)]
        public void divideByZeroExeptionTest(double numerator, double denominator)
        {
            //Assert.Throws<DivideByZeroException>(() => _calculator.Divide(numerator, denominator));
            Assert.That(() => _calculator.Divide(numerator, denominator), Throws.TypeOf<Exception>());
        }
    }
}