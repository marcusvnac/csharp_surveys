using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.CoinChange
{
    class Solution
    {
        /*
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] coins_temp = Console.ReadLine().Split(' ');
            int[] coins = Array.ConvertAll(coins_temp, Int32.Parse);

            long result = CoinChange(coins, n, m);
            Console.WriteLine(result);
        }
        */
        static long CoinChange(int[] coins, int n, int m)
        {
            long[] changes = new long[n + 1];
            changes[0] = 1;

            foreach (var coin in coins)
            {
                for (int i = coin; i <= n; i++)
                {
                    /* Console.WriteLine(String.Format("i = {0}, coin = {1}, changes = {2}, changes i = {3}", i, coin, changes[i-coin], changes[i]));*/
                    changes[i] += (i - coin >= 0 ? changes[i - coin] : 0);
                }
            }
            return changes[n];

        }

    }
}
