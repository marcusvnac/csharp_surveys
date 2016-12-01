using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.RecursiveStaircase
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int s = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < s; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(DaviStaircase(n));
            }
        }
        */

        public static int DaviStaircase(int n)
        {
            int[] cache = Enumerable.Repeat(-1, n+1).ToArray();
            return DaviStaircase(n, cache);
        }

        public static int DaviStaircase(int n, int[] cache)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return 0;
            else if (cache[n] > -1)
                return cache[n];
            else
            {
                cache[n] = DaviStaircase(n - 1, cache) + DaviStaircase(n - 2, cache) + DaviStaircase(n - 3, cache);
                return cache[n];
            }
        }
    }
}
