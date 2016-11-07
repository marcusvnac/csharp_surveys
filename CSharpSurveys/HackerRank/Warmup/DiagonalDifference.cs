using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace CSharpSurveys.RackerRank.Warmup.DiagonalDifference
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                for (int c = 0; c < n; c++)
                    a[r, c] = Int32.Parse(a_temp[c]);
            }
            Console.WriteLine(DiagonalDifference(n, a));
        }
        */
        public static int DiagonalDifference(int n, int[,] matrix)
        {
            int sumMainDiagonal = 0, sumSecDiagonal = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        sumMainDiagonal += matrix[i, j];
                    if (i + j == n - 1)
                        sumSecDiagonal += matrix[i, j];
                }

            int result = Math.Abs(sumMainDiagonal - sumSecDiagonal);
            return result;

        }

    }
}