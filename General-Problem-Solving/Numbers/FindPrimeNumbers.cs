using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Problem_Solving.Numbers
{
    internal class FindPrimeNumbers
    {
        public bool IsPrime(int n)
        {
            return false;       
        }

        public long FindCountOfPrimeNumber()
        {
            var primeNumbers = new List<long> { 2 };

            for(long i=3; i < long.MaxValue; i += 2)
            {
                if(!primeNumbers.Any(p => (i % p) == 0))
                {
                    primeNumbers.Add(i);
                    if (primeNumbers.Count == 10001)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
