using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionCSharp
{
    class Program
    {
         const int N = 90;
        private static long[] fibonacciCache = new long[N+1];

        static void Main(string[] args)
        {
            long N = 40;
            for (long i = 1; i <= N; i++)
            {
                long fibonacci = fnFibonacciDinamica(i);
                Console.WriteLine(i + " => " + fibonacci);
            }
            Console.Read();
        }

        static long fnFibonacci(long n)
        {
            if (n < 0)
            {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 2)
            {
                return 1;
            }
            return fnFibonacci(n - 1) + fnFibonacci(n - 2);
        }

        static long fnFibonacciLineal(long n)
        {
            if (n < 0)
            {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 2)
            {
                return 1;
            }
            long fibonacci = 0;
            long previous = 1;
            long penultimate = 0;
            for (int i = 1; i <= n; i++)
            {
                penultimate = fibonacci;
                fibonacci = previous + fibonacci;
                previous = penultimate;
            }
            return fibonacci;
        }

        static long fnFibonacciDinamica(long n)
        {
            if (n < 0)
            {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 2)
            {
                fibonacciCache[n]= 1;
            }
            if (fibonacciCache[n] == 0)
            {
                fibonacciCache[n] = fnFibonacciDinamica(n-1) + fnFibonacciDinamica(n-2);
            }
            return fibonacciCache[n];
        }

    }
}
