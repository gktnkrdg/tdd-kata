using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDKatas.PrimeFactor
{
    public class PrimeFactor
    {
        public static List<int> GeneratePrimeFactors(int number)
        {
            int[] primeNumbers = { 2, 3, 5, 7, 11 };
            var primeFactors = new List<int>();
            if (number < 2)
                return new List<int>();
            for(int i = 0; i < primeNumbers.Count(); i++)
            {
                while (number % primeNumbers[i] == 0)
                {
                    number = number / primeNumbers[i];
                    primeFactors.Add(primeNumbers[i]);
                }
            }
            return primeFactors;
        }
    }
}
