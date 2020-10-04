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
            var primeFactors = new List<int>();
            var factor = 2;
            while (number > 1)  
            { 
                while (number % factor == 0)
                {
                    number = number / factor;
                    primeFactors.Add(factor);
                }
                factor++;
            }
            return primeFactors;
        }
    }
}
