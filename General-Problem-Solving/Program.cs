using General_Problem_Solving.Arrays;
using General_Problem_Solving.Numbers;
using General_Problem_Solving.Strings;
using General_Problem_Solving.Threads;

namespace General_Problem_Solving
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var mulitples = new Multiples();
            var reverse = new ReverseSentence();
            var findPrimeCount = new FindPrimeNumbers();
            var findEvenSum = new FibonacciNumbers();

            var multipleResult = mulitples.SumOfThreeAndFiveMultiples(1000);

            reverse.LongReverse("The Rain in Spain");

            var primeCount = findPrimeCount.FindCountOfPrimeNumber();

            var evenSum = findEvenSum.FindSumOfEvenNumbers(1, 2);

            Console.WriteLine();
            Console.WriteLine($"Sum of multipes of 3 and 5 are: {multipleResult}");
            Console.WriteLine($"Count of the 10001st prime number: {primeCount}");
            Console.WriteLine($"Even sum of numbers less than 4 million in fibo: {evenSum}");

            var sumOfEvenNumbers = (from number in Enumerable.Range(1, 4)
                                group number by number % 2 into setOfNumbers
                                select setOfNumbers.Sum()
                                ).Max();

            Console.WriteLine(sumOfEvenNumbers.ToString());

            ExecuteThreads.Execute();

            Console.ReadLine();
        }
    }
}