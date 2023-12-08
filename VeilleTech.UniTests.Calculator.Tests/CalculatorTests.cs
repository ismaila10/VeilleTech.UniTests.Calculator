namespace VeilleTech.UniTests.Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void When_Add_Return_ValidResult()
        {
            // Arrange
            Calculator calculator = new Calculator();
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
            Calculator calculator = new Calculator();

            // Act
            var result = calculator.Substract(x, y); 

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
