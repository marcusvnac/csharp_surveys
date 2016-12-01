using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.Warmup.CircularArrayRotation
{
    public class Solution
    {

        /*
        static void Main(String[] args)
        {
            
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            //RotateArray(n, k, a);

            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int pos = (m- k%n) % n;
                if (pos < 0)
                    pos = m - k % n + n;

                Console.WriteLine(a[(n - k + m) % n]);
            }
            
        }*/

        /*** Brute Force ***/
        public static void RightRotateArray(int n, int k, int[] arr)
        {
            if (n <= 1)
                return;
            else
            {
                for (int rotation = 0; rotation < k; rotation++)
                {
                    int last = arr[n-1];
                    
                    for (int i = n-1; i > 0; i--)
                    {
                        arr[i] = arr[i-1];
                    }
                    arr[0] = last;
                }
            }
        }

    }   
}
