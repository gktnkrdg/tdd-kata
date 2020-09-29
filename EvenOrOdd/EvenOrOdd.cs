using System;
using System.Linq;

namespace EvenOrOdd
{
    public class EvenOrOdd
    {
        public  string SumIsEvenOrOdd(int[] numbers)
        {
            return numbers.Sum() % 2 == 0 ? "even" : "odd";
        }
        
    }
}
