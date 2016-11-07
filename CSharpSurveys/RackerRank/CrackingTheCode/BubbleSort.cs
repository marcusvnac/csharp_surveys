using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.BubbleSort
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int numberOfSwaps = BubbleSort(n, a);
            Console.WriteLine(String.Format("Array is sorted in {0} swaps.", numberOfSwaps));
            Console.WriteLine(String.Format("First Element: {0}", a[0]));
            Console.WriteLine(String.Format("Last Element: {0}", a[n-1]));
        }
        */
        public static int BubbleSort(int n, int[] a)
        {
            int totalNumberOfSwaps = 0;
            for (int i = 0; i < n; i++)
            {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;

                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {                        
                        Swap(a, j, j + 1);
                        numberOfSwaps++;
                    }
                }
                totalNumberOfSwaps += numberOfSwaps;
                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            return totalNumberOfSwaps;
        }

        private static void Swap(int[] a, int before, int after)
        {
            int tmp = a[before];
            a[before] = a[after];
            a[after] = tmp;
        }
    }
}
