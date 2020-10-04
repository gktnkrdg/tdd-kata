using FluentAssertions;
using System;
using Xunit;

namespace TDDKatas.EvenOrOdd
{
    public class EvenOrOddTest
    {
        [Theory]
        [InlineData(new int[0],"even")]
        [InlineData(new[] { 1,3 }, "even")]
        [InlineData(new[] { -1,5,6 }, "even")]
        [InlineData(new[] { 10000,18,22,43,1,66 }, "even")]
        [InlineData(new[] { 1 },"odd")]
        [InlineData(new[] { -1, 5, 6, 11 },"odd")]
        [InlineData(new[] { 10000, 18, 22, 43, 1, 67 },"odd")]
        public void GetEventOrOdd_SumOfElements_ReturnString(int[] numbers,string expectedResult)
        {
            EvenOrOdd evenOrOdd = new EvenOrOdd();


            evenOrOdd.SumIsEvenOrOdd(numbers).ToLower().Should().Be(expectedResult.ToLower());
        }
    }
}
