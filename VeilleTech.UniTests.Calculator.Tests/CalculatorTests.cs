namespace VeilleTech.UniTests.Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void When_Add_Return_ValidResult()
        {
            // Arrange
            var calculator = new Calculator();
            int x = 3; int y = 5;

            // Act
            var result = calculator.Add(x, y);

            // Assert
            Assert.Equal(8, result);
        }

        [Theory]
        [InlineData(2,5,-3)]
        [InlineData(8,5,3)]
        [InlineData(9,2,7)]
        public void When_Substract_Return_ValidResult(int x, int y, int expectedResult)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Substract(x, y); 

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void When_Divide_Return_ValidObjectResult()
        {
            // Arrange
            var calculator = new Calculator();
            var a = 3; var b = 6;

            // Act
            var result = calculator.Divide(a, b);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal("0,5", result.Result.ToString());
            Assert.Null(result.Error);
        }

        [Fact]
        public void When_Divide_Return_DivideByZero()
        {
            // Arrange
            var calculator = new Calculator();
            var a = 3; var b = 0;

            // Act
            var result = calculator.Divide(a, b);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal("DivideByZero", result.Error);
            Assert.Equal(0, result.Result);
        }
    }
}
