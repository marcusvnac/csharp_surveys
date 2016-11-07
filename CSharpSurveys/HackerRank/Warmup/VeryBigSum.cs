using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace CSharpSurveys.RackerRank.Warmup.VeryBigSum
{ 
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            
        }
        */

        public static BigInteger VeryBigSum(int[] arr, int n)
        {
            BigInteger bi = new BigInteger();

            for(int i = 0; i < n; i++)
            {
                bi += arr[i];
            }

            return bi;
        }
    }

}
