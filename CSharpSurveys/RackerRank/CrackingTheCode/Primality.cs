using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.Primality
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < p; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(IsPrime(n) ? "Prime" : "Not prime");
            }
        }
        */
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            int sqrt = (int)Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
