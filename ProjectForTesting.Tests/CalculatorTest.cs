using Xunit;

namespace ProjectForTesting.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(20, 20)]
        [InlineData(40, 40)]
        [InlineData(33, 33)]
        public void CalculatorSubtractShouldEqualToResult(int a, int b)
        {
            var calculator = new Calculator();

            var result = calculator.Subtract(a, b);
            var expected = 0;

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(24, 3)]
        [InlineData(32, 4)]
        [InlineData(40, 5)]
        public void CalculatorDivideShouldEqualToResult(int a, int b)
        {
            var calculator = new Calculator();

            var result = calculator.Divide(a, b);
            var expected = 8;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculatorAddShouldEqualToResult()
        {
            var calculator = new Calculator();

            var result = calculator.Add(15, 10);
            var expected = 25;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculatorMultiplyShouldEqualToResult()
        {
            var calculator = new Calculator();

            var result = calculator.Multiply(5, 20);
            var expected = 100;

            Assert.Equal(expected, result);
        }
    }
}