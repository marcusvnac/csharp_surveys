using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.Warmup.StairCase
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
        }
        */
        public static void StairCase(int n)
        {
            for (int i = 1; i <= n; i++)
            {                
                for (int j = 1; j <= n; j++)
                {
                    if ((i + j) > n)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }                                    
                Console.WriteLine();
            }
        }
    }
}
