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


        // Fibonacci by Dynamic Programation without cache
        public static long Fibonacci_DP_Ultimate(int n)
        {
            int i;  // counter
            long back2 = 0, back1 = 1; // last two values of f[n]
            long next; /* placeholder for sum */
            if (n == 0) return (0);
            for (i = 2; i < n; i++)
            {
                next = back1 + back2;
                back2 = back1;
                back1 = next;
            }
            return (back1 + back2);
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