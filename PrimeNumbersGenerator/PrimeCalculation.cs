using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumbersGenerator
{
    public class PrimeCalculation
    {
        public static PrimeNumber NextPrime(long number)
        {
            Stopwatch calculationsWatch = Stopwatch.StartNew();
            bool isPrime;
            while (true)
            {
                isPrime = true;
                number++;
                for (int i = 2; i < Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    return new PrimeNumber(number, calculationsWatch.ElapsedMilliseconds);
                }
            }
        }
    }

    public class PrimeNumber
    {
        public long Number { get; }
        public long CalculationTime { get; }

        public PrimeNumber(long number, long calculationTime)
        {
            Number = number;
            CalculationTime = calculationTime;
        }
    }
}
