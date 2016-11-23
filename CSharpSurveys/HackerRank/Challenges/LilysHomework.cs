using System;
using System.Linq;

namespace CSharpSurveys.HackerRank.Challenges.LilysHomework
{
    public class Solution
    {
    /*
        static void Main(String[] args)
        {
            Console.ReadLine();
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(LilysHomework(a));
        }
    */
        public static int LilysHomework(int[] a)
        {
            if (IsSorted(a, true) || IsSorted(a, false))
                return 0;

            int swaps = 0;
            QuickSort(a, 0, a.Length - 1, ref swaps);
            //Console.WriteLine(string.Join(",", a));
            return swaps;
        }

        static bool IsSorted(int[] a, bool asc)
        {
            if (asc)
            {
                for (int i = 1; i < a.Length; i++)
                    if (a[i - 1] > a[i])
                        return false;
            }
            else
            {
                for (int i = 1; i < a.Length; i++)
                    if (a[i - 1] < a[i])
                        return false;
            }
            return true;
        }

        static void QuickSort(int[] a, int low, int high, ref int swaps)
        {
            //Console.WriteLine("QS = " + string.Join(",", a));
            if (low < high)
            {
                int p = Partition(a, low, high, ref swaps);
                //Console.WriteLine("1st - low = {0}, high = {1}", low, high);
                QuickSort(a, low, p - 1, ref swaps);
                //Console.WriteLine("2nd - low = {0}, high = {1}", low, high);
                QuickSort(a, p + 1, high, ref swaps);
            }
        }

        static int Partition(int[] a, int low, int high, ref int swaps)
        {
            int pivot = a[(low + high) / 2];
            //Console.WriteLine("pivot = {0}, low = {1}, high = {2}, swaps = {3}", pivot, low, high, swaps);

            int i = low;
            int j = high;

            while (true)
            {
                while (i < a.Length && a[i] < pivot) i++;
                while (j > 0 && pivot < a[j]) j--;

                if (i >= j)
                    break;

                Swap(a, i, j, ref swaps);
                i++;
                j--;
            }

            if (i < a.Length && a[i] > a[high])
                Swap(a, i, high, ref swaps);
            return i;
        }

        static void Swap(int[] a, int i, int j, ref int swaps)
        {
            if (i != j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                swaps++;
            }
        }
        /*
        private static int[] QuicksortSimple(int[] data, ref int swaps)
        {
            if (data.Length < 2)
            {
                return data;
            }
            int pivotIndex = data.Length / 2;
            int pivotValue = data[pivotIndex];
            int leftCount = 0;
            // Count how many are less than the pivot
            for (int i = 0; i < data.Length; ++i)
            {
                if (data[i] < pivotValue)
                    leftCount++;
            }
            swaps += leftCount;
            // Allocate the arrays and create the subsets
            int[] left = new int[leftCount];
            int[] right = new int[data.Length - leftCount - 1];
            int l = 0;
            int r = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (i == pivotIndex)
                    continue;

                int val = data[i];
                if (val < pivotValue)
                {
                    left[l++] = val;
                }
                else
                {
                    right[r++] = val;
                }
            }
            // Sort the subsets
            left = QuicksortSimple(left, ref swaps);
            right = QuicksortSimple(right, ref swaps);
            // Combine the sorted arrays and the pivot back into the original array
            Array.Copy(left, 0, data, 0, left.Length);
            data[left.Length] = pivotValue;
            Array.Copy(right, 0, data, left.Length + 1, right.Length);
            return data;
        }
        */
    }

}
