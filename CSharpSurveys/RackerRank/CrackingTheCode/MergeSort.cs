using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.MergeSort
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                Console.WriteLine(MergeSort(arr));
            }
        }
        */
        public static long MergeSort(int[] arr)
        {
            int[] helper = new int[arr.Length];
            long swaps = MergeSort(arr, helper, 0, arr.Length - 1);
            return swaps;
        }

        private static long MergeSort(int[] arr, int[] helper, int low, int high)
        {
            long swaps = 0;
            if (low < high)
            {
                int middle = (low + high) / 2;
                swaps += MergeSort(arr, helper, low, middle); // sort left half
                swaps += MergeSort(arr, helper, middle + 1, high); // sort right half
                swaps += Merge(arr, helper, low, middle, high);  // merge them
            }
            return swaps;
        }

        private static long Merge(int[] arr, int[] helper, int low, int middle, int high)
        {
            long swaps = 0;
            // Copy both halves into a helper array
            for (int i = low; i <= high; i++)
            {
                helper[i] = arr[i];
            }

            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;

            /* Iterate through helper array. Compare the left and right half, copying back
             * the smaller element from the two halves into the original array. */
            while(helperLeft <= middle && helperRight <= high)
            {
                if(helper[helperLeft] <= helper[helperRight])
                {
                    if (arr[current] != helper[helperLeft])
                    {                        
                        arr[current] = helper[helperLeft];
                    }
                    helperLeft++;
                }
                else // if the right element is smaller than left element
                {
                    if (arr[current] != helper[helperRight])
                    {
                        arr[current] = helper[helperRight];
                    }
                    swaps += middle - helperLeft + 1;
                    helperRight++;                    
                }
                current++;
            }
            
            // Copy the rest of the left side of the array into the target array
            int remaing = middle - helperLeft;
            for (int i = 0; i <= remaing; i++)
            {
                arr[current + i] = helper[helperLeft + i];
            }
            return swaps;
        }
    }
}
