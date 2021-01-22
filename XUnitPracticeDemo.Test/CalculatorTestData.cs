using System.Collections.Generic;

namespace XUnitPracticeDemo.Test
{
    public class CalculatorTestData
    {
        private static readonly List<object[]> Data = new List<object[]>
        {
            new object[] {0, 100, 100},
            new object[] {1, 99, 100},
            new object[] {50, 50, 100},
            new object[] {101, 1, 102}
        };

        public static IEnumerable<object[]> TestData => Data;
    }
}