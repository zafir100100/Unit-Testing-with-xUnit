using ConsoleApp1;

namespace TestProject1
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            var result = _calculator.Add(3, 2);
            Assert.Equal(5, result);  // Assert.Equal compares expected with actual result
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            var result = _calculator.Multiply(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            var result = _calculator.Divide(10, 2);
            Assert.Equal(5.0, result, 1);  // Precision to 1 decimal place
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}