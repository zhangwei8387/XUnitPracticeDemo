using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XUnitPracticeDemo.Test
{
    public class CalculatorCsvData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                string[] csvLines = File.ReadAllLines("TestData.csv");
                var testCases = new List<object[]>();
                foreach (var csvLine in csvLines)
                {
                    IEnumerable<int> values = csvLine.Split(',').Select(int.Parse);
                    object[] testCase = values.Cast<object>().ToArray();
                    testCases.Add(testCase);

                }
                return testCases;
            }
        }
    }
}
