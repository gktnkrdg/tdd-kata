using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDKatas.PrimeFactor
{
    public class PrimeFactor
    {
        public  List<int> GeneratePrimeFactors(int number)
        {
            var primeFactors = new List<int>();
            for (var factor=2;number > 1;factor++)  
            { 
                while (number % factor == 0)
                {
                    number = number / factor;
                    primeFactors.Add(factor);
                }
            }
            return primeFactors;
        }
    }
}
