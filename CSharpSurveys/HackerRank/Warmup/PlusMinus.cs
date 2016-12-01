using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.Warmup.PlusMinus
{
    class Solution
    {
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            double[] result = PlusMinus(n, arr);

            for (int i = 0; i < 3; i++)
                Console.WriteLine(String.Format("{0:F6}", result[i]));
        }
        */

        public static double[] PlusMinus(int n, int[] arr)
        {
            double[] result = new double[3];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    result[0]++;
                else if (arr[i] < 0)
                    result[1]++;
                else
                    result[2]++;
            }

            for (int i = 0; i < 3; i++)
                result[i] /= n;

            return result;

        }
    }
}
