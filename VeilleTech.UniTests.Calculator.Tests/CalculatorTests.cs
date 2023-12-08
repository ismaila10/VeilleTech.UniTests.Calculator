namespace VeilleTech.UniTests.Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        // STEP 1

        [Fact]
        public void When_Add_Return_ValidResult()
        {
            // Arrange
            int x = 3; 
            int y = 5;

            // Act
            var result = _calculator.Add(x, y);

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

            // Act
            var result = _calculator.Substract(x, y); 

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void When_Divide_Return_ValidObjectResult()
        {
            // Arrange
            var a = 3; 
            var b = 6;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal((decimal)0.5, result.Result);
            Assert.Null(result.Error);
        }

        [Fact]
        public void When_Divide_Return_DivideByZero()
        {
            // Arrange
            var a = 3; 
            var b = 0;

            // Act
            var result = _calculator.Divide(a, b);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal("DivideByZero", result.Error);
            Assert.Equal(0, result.Result);
        }

        [Fact]
        public void When_DivideByZero_ThrowException()
        {
            // Arrange
            var a = 5; 
            var b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.DivideWithException(a, b));   
        }

        [Fact]
        public void When_DivideByZero_Should_Return_ValidResult()
        {
            // Arrange
            var a = 6; 
            var b = 3;

            // Act
            var result = _calculator.DivideWithException(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        // STEP 2 
        //UnitOfWork_StateUnderTest_ExpectedBehavior
        //MethodName_Params_Result

        [Theory]
        [InlineData(0, 5, 2.5)]
        [InlineData(10, 20, 15)]
        [InlineData(0, double.MaxValue, 8.988465674311579E+307)]
        public void Average_PositiveNumbersAsParam_ReturnAverage(double a, double b, double expectedresult) {
            // Act
            var result = _calculator.Average(a, b);

            // Assert
            Assert.Equal(expectedresult, result);
        }

        [Theory]
        [InlineData(-15, 20)]
        [InlineData(-30, -45)]
        [InlineData(55, -14)]
        [InlineData(-1, double.MinValue)]
        public void Average_AtLeastOneNegativeNumbersAsParam_ThrowException(double a, double b)
        {
            // AAA
            Assert.Throws<ArgumentException>(() => _calculator.Average(a, b));
        }
    }
}
