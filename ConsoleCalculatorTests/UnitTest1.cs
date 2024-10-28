using ConsoleCalculator;
using Xunit;

namespace ConsoleCalculatorTests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ReturnsSum_WhenTwoNumbersAreGiven()
        {

            double x = 5;
            double y = 3;


            double result = _calculator.Add(x, y);


            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ReturnsDifference_WhenTwoNumbersAreGiven()
        {
            double x = 5;
            double y = 3;

            double result = _calculator.Subtract(x, y);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ReturnsProduct_WhenTwoNumbersAreGiven()
        {
            double x = 5;
            double y = 3;

            double result = _calculator.Multiply(x, y);

            Assert.Equal(15, result);
        }

        [Fact]
        public void Divide_ReturnsQuotient_WhenTwoNumbersAreGiven()
        {
            double x = 6;
            double y = 3;

            double result = _calculator.Divide(x, y);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ThrowsDivideByZeroException_WhenDividedByZero()
        {
            double x = 5;
            double y = 0;

            var exception = Assert.Throws<DivideByZeroException>(() => _calculator.Divide(x, y));
            Assert.Equal("Cannot be zero", exception.Message);
        }

        [Fact]
        public void Add_ReturnsNegativeSum_WhenAddingNegativeNumbers()
        {
            double x = -5;
            double y = -3;

            double result = _calculator.Add(x, y);

            Assert.Equal(-8, result);
        }

        [Fact]
        public void Subtract_ReturnsNegativeDifference_WhenResultIsNegative()
        {
            double x = 3;
            double y = 5;

            double result = _calculator.Subtract(x, y);

            Assert.Equal(-2, result);
        }

        [Fact]
        public void Multiply_ReturnsZero_WhenMultiplyingByZero()
        {
            double x = 5;
            double y = 0;

            double result = _calculator.Multiply(x, y);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient_WhenDividingNegativeByPositive()
        {
            double x = -6;
            double y = 3;

            double result = _calculator.Divide(x, y);

            Assert.Equal(-2, result);
        }

        [Fact]
        public void Add_ReturnsCorrectSum_WhenAddingLargeNumbers()
        {
            double x = 1e10;
            double y = 1e10;

            double result = _calculator.Add(x, y);

            Assert.Equal(2e10, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference_WhenSubtractingFromZero()
        {
            double x = 0;
            double y = 5;

            double result = _calculator.Subtract(x, y);

            Assert.Equal(-5, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct_WhenMultiplyingLargeNumbers()
        {
            double x = 1e10;
            double y = 2;

            double result = _calculator.Multiply(x, y);

            Assert.Equal(2e10, result);
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient_WhenDividingNegativeByNegative()
        {
            double x = -6;
            double y = -3;

            double result = _calculator.Divide(x, y);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_ReturnsSum_WhenAddingFloats()
        {
            double x = 1.5;
            double y = 2.5;

            double result = _calculator.Add(x, y);

            Assert.Equal(4.0, result);
        }


    }
}
