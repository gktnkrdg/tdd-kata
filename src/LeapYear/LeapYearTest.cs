using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDKatas.LeapYear
{
    public class LeapYearTest
    {
        [Theory]
        [InlineData(48, true)]
        [InlineData(51, false)]
        [InlineData(400, true)]
        [InlineData(401, false)]
        [InlineData(2000,true)]
        [InlineData(2001,false)]
        [InlineData(2002, false)]
        [InlineData(2003, false)]
        [InlineData(2004, true)]
       
       

        public void IsLeapYear_ShouldReturnYearIsALeapYear(int year,bool expectedResult)
        {
            LeapYear leapYear = new LeapYear();

            var isLeapYear = leapYear.IsLeapYear(year);

            isLeapYear.Should().Be(expectedResult);
        }
    }
}
