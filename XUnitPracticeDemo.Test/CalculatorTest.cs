using System.Collections.Generic;
using Xunit;

namespace XUnitPracticeDemo.Test
{
    public class CalculatorTest
    {
        public static IEnumerable<object[]> InputData_Property  {
            get
            {
                var driverData = new List<object[]>();
                driverData.Add(new object[] { 1, 1, 2 });
                driverData.Add(new object[] { 1, 2, 3 });
                driverData.Add(new object[] { 2, 3, 5 });
                driverData.Add(new object[] { 3, 4, 7 });
                driverData.Add(new object[] { 4, 5, 9 });
                driverData.Add(new object[] { 5, 6, 11 });
                return driverData;
            }
         }
        public static IEnumerable<object[]> InputData_Method(string flag)
        {
            var driverData = new List<object[]>();
            if (flag == "Default")
            {
                driverData.Add(new object[] { 100, 100, 200 });
                driverData.Add(new object[] { 101, 2, 103 });
                driverData.Add(new object[] { 20, 30, 50 });
            }
            else
            {
                driverData.Add(new object[] { 3, 4, 7 });
                driverData.Add(new object[] { 4, 5, 9 });
                driverData.Add(new object[] { 5, 6, 11 });
            }
            return driverData;
        }
        [Theory]
        //[InlineData(0, 1, 1)]
        //[InlineData(1, 99, 100)]
        //[InlineData(50, 50, 100)]
        //[InlineData(101, 1, 102)]
        [MemberData(nameof(InputData_Property))]
        [MemberData(nameof(InputData_Method),"Default")]
        [MemberData(nameof(CalculatorTestData.TestData), MemberType = typeof(CalculatorTestData))]
        [MemberData(nameof(CalculatorCsvData.TestData), MemberType = typeof(CalculatorCsvData))]
        public void ShouldAdd(int x, int y, int expected)
        {
            // Arrange

            var sut = new Calculator(); // system under test

            // Act
            var result = sut.Add(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        //[Fact]
        //public void ShouldAdd1()
        //{
        //    // Arrange
        //    var x = 100;
        //    var y = 1;
        //    var sut = new Calculator(); // system under test

        //    // Act
        //    var result = sut.Add(x, y);

        //    // Assert
        //    Assert.Equal(101, result);

        //}
        //[Fact]
        //public void ShouldAdd2()
        //{
        //    // Arrange
        //    var x = 50;
        //    var y = 50;
        //    var sut = new Calculator(); // system under test

        //    // Act
        //    var result = sut.Add(x, y);

        //    // Assert
        //    Assert.Equal(100, result);

        //}
        //[Fact]
        //public void ShouldAdd3()
        //{
        //    // Arrange
        //    var x = 200;
        //    var y = 100;
        //    var sut = new Calculator(); // system under test

        //    // Act
        //    var result = sut.Add(x, y);

        //    // Assert
        //    Assert.Equal(300, result);

        //}
    }
}