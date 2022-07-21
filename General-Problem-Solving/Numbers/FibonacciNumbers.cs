using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Problem_Solving.Numbers
{
    internal class FibonacciNumbers
    {
        public int FindSumOfEvenNumbers(int num1, int num2)
        {
            int sum = 0;
            int evenSum = 0;

            while (true)
            {
                sum = num1 + num2;

                num1 = num2;
                num2 = sum;

                if (sum > 4000000)
                    break;

                if (sum % 2 == 0)
                {
                    evenSum += sum;
                }
            }

            return evenSum;
        }
    }
}
