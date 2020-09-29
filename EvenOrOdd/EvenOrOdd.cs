using System;

namespace EvenOrOdd
{
    public class EvenOrOdd
    {
        public  string SumIsEvenOrOdd(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            if (sum % 2 == 0)
                return "even";
            return "odd";

        }
        
    }
}
