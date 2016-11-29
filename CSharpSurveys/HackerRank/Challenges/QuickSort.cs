using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.HackerRank.Challenges.QuickSort
{
    public static class Solution
    {
        static void Main(String[] args)
        {
            int _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            QuickSort(_ar, 0, _ar_size - 1);
            Console.WriteLine(string.Join(" ", _ar));
        }

        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (right <= left)
                return;

            int p = Partition(arr, left, right);
            //Console.WriteLine("p = {0}, left = {1}, right = {2}", p, left, right);
            QuickSort(arr, left, p - 1);
            //Console.WriteLine(string.Join(" ", new ArraySegment<int>(arr, left, p - 1)));
            QuickSort(arr, p + 1, right);

            //Console.WriteLine(string.Join(" ", new ArraySegment<int>(arr, left, right)));   
        }

        static int Partition(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[left];

            while (true)
            {
                while (i < arr.Length && arr[i] < pivot)
                    i++;

                while (j > 0 && pivot < arr[j])
                    j--;
                
                if (i >= j)
                    break;

                Swap(arr, i, j);
                i++;
                j--;
            }
            //Console.WriteLine("Swap - i = {0}, right = {1}, arr[i] = {2}, arr[right] = {3}", i, right, arr[i], arr[right]);
            if (i < arr.Length && arr[i] > arr[right])
                Swap(arr, i, right);
            //Console.WriteLine("arr = " + string.Join(" ", new ArraySegment<int>(arr, left, right))); 
            return i;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

    }


}
