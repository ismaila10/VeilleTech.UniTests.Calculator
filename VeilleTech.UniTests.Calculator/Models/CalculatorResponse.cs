namespace VeilleTech.UniTests.Calculator.Models
{
    public class CalculatorResponse
    {
        public decimal Result { get; set; }

        public bool IsSuccess { get; set; }

        public string? Error { get; set; }
    }
}
