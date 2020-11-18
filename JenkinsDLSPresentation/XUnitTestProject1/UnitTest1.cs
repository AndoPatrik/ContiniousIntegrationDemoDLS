using JenkinsDLSPresentation;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5,10)]
        [InlineData(20,10)]
        [InlineData(50,10)]
        public void CalculatorAdd_ShouldAdd2Numbers(int x, int y)
        {
            Calculator calculator = new Calculator();
            int actual = calculator.Add(x,y);
            int expected = x + y;
            Assert.Equal(expected, actual);
            
        }
        [Theory]
        [InlineData(50, 10)]
        [InlineData(100, 10)]
        [InlineData(80, 10)]
        public void CalculatorSubstact_ShouldSubstract2Numbers(int x, int y)
        {
            Calculator calculator = new Calculator();
            int actual = calculator.Substract(x, y);
            int expected = x - y;
            Assert.Equal(expected, actual);
        }
    }
}
