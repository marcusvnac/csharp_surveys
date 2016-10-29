using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.FibonacciNumbers
{
    public class Solution
    {

        private static int Fibonacci(int n, int[] cache)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            if (cache[n] > -1)
                return cache[n];
            else
            {
                cache[n] = Fibonacci(n - 1, cache) + Fibonacci(n - 2, cache);
                return cache[n];
            }
        }

        public static int Fibonacci(int n)
        {
            int[] cache = Enumerable.Repeat(-1, n + 1).ToArray();
            return Fibonacci(n, cache);
        }
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
        */
    }

}