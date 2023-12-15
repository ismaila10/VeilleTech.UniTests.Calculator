

using VeilleTech.UniTests.Calculator.Models;

namespace VeilleTech.UniTests.Calculator
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }

        public CalculatorResponse Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return new CalculatorResponse
                {
                    IsSuccess = false,
                    Error = "DivideByZero"
                };
            }

            return new CalculatorResponse {
                IsSuccess = true,
                Result = dividend / divisor
            };
        }

        public decimal DivideWithException(decimal dividend, decimal divisor)
        {
            return (divisor != 0 ? dividend / divisor :
                throw new DivideByZeroException());
        }

        public double Average(double a, double b)
        {
            return (a >= 0 && b >= 0 ? (a + b) / 2 :
                throw new ArgumentException("All argument values must be greater than or equal to 0"));           
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double MarksAverage(Student student)
        {
            if(student.Marks != null && student.Marks.Any())
            {
                return student.Marks.Average();
            }
            throw new ArgumentException("Marks cannot be null or empty");
        }
    }
}
