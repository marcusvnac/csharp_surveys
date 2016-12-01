using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.HackerRank.Challenges.Mandragora
{
    public static class Solution
    {
        static void Main(String[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int.Parse(Console.ReadLine());
                int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Console.WriteLine(MaxXP(h));
            }
        }

        public static long MaxXP(int[] h)
        {
            long s = 1;
            long sum = 0;
            foreach (var n in h)
                sum += n;
            long p = sum;

            Array.Sort(h);
            
            for (int i = 0; i < h.Length; i++)
            {
                s++;
                sum -= h[i];
                long tmp = sum * s;

                if (tmp > p)
                    p = tmp;
            }

            return p;
        }
    }
}
