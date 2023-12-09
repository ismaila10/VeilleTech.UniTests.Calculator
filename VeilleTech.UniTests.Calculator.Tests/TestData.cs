using System.Collections;

namespace VeilleTech.UniTests.Calculator.Tests
{
    public class TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 10, 20, 15 };
            yield return new object[] { 0, 20, 10 };
            yield return new object[] { 0, 0, 0 };
            yield return new object[] { 0, double.MaxValue, 8.988465674311579E+307 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
