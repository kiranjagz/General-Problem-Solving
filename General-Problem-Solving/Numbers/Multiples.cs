using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Problem_Solving.Numbers
{
    internal class Multiples
    {
        public double SumOfThreeAndFiveMultiples(int range)
        {
            double sum = 0;

            for (int i = 0; i < range; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
