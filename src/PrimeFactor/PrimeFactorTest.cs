using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDKatas.PrimeFactor
{
    public class PrimeFactorTest
    {
        [Theory]
        [InlineData(-100, new int[0])]
        [InlineData(0, new int[0])]
        [InlineData(5, new[] { 5 })]
        [InlineData(10, new[] { 2,5 })]
        [InlineData(50, new[] { 2, 5,5 })]
        [InlineData(81, new[] { 3, 3, 3, 3 })]
        [InlineData(100, new[] { 2, 2,5, 5 })]
        [InlineData(240, new[] { 2, 2, 2, 2,3,5 })]
        public void Generate_WithNumber_ReturnExpectedString    (int number,int[] expectedArray)
        {
            PrimeFactor primeFactor = new PrimeFactor();

            var primeFactors = primeFactor.GeneratePrimeFactors(number);
            
            primeFactors.Should().BeEquivalentTo(expectedArray);
       }
    }
}
