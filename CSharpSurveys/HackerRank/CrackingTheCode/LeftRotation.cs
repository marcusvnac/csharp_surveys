using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.LeftRotation
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            LeftRotateArray(n, k, a);
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }        
        */

        /*** Brute Force ***/
        public static void LeftRotateArray_BruteForce(int n, int k, int[] arr)
        {
            if (n <= 1)
                return;
            else
            {
                for (int rotation = 0; rotation < k; rotation++)
                {
                    int first = arr[0];

                    for (int i = 1; i < n; i++)
                    {
                        arr[i-1] = arr[i];
                    }
                    arr[n-1] = first;
                }
            }
        }

        /*** Copying array ***/
        public static int[] LeftRotateArray(int n, int k, int[] arr)
        {
            if (n <= 1)
                return arr;
            else
            {
                int[] rotated = new int[n];
                Array.Copy(arr, k, rotated, 0, n - k);
                Array.Copy(arr, 0, rotated, n - k, k);

                return rotated;
            }
        }
    }
}
