using FluentAssertions;
using System;
using Xunit;

namespace EvenOrOdd.Test
{
    public class GetEventOrOdd
    {
        [Theory]
        [InlineData(new int[0],"even")]
        [InlineData(new[] { 1,3 }, "even")]
        [InlineData(new[] { -1,5,6 }, "even")]
        [InlineData(new[] { 10000,18,22,43,1,66 }, "even")]
        [InlineData(new[] { 1 },"odd")]
        [InlineData(new[] { -1, 5, 6, 11 },"odd")]
        [InlineData(new[] { 10000, 18, 22, 43, 1, 67 },"odd")]
        public void GetEventOrOdd_ReturnString_SumOfElementsEven(int[] numbers,string expectedResult)
        {
            string result = "";

            result.Should().Be(expectedResult);
        }
    }
}
