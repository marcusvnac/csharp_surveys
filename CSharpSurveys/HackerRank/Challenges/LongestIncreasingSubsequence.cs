using System;
using System.Linq;

namespace CSharpSurveys.HackerRank.Challenges.LongestIncreasingSubsequence
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(LongestSubseq(arr, n));
        }
        */
        // Add boundary case, when array n is zero
        // Depend on smart pointers
        public static int LongestSubseq(int[] arr, int n)
        {
            int[] tailIndices = Enumerable.Repeat(0, n).ToArray();
            int[] prevIndices = Enumerable.Repeat(-1, n).ToArray();

            int len = 1;    // it will always point to empty location
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[tailIndices[0]])
                {   // new smallest value
                    tailIndices[0] = i;
                }
                else if (arr[i] > arr[tailIndices[len - 1]])
                {   // arr[i] wants to extend largest subsequence
                    prevIndices[i] = tailIndices[len - 1];
                    tailIndices[len] = i;
                    len++;
                }
                else
                {
                    /* arr[i] wants to be a potential condidate of future subsequence
                        It will replace ceil value in tailIndices */
                    int pos = GetCeilIndex(arr, tailIndices, -1, len - 1, arr[i]);
                    if (pos >= 1)
                    {
                        prevIndices[i] = tailIndices[pos - 1];
                        tailIndices[pos] = i;
                    }
                }
            }

            // LIS of given input
            /*
            for (int i = tailIndices[len - 1]; i >= 0; i = prevIndices[i])
                Console.WriteLine(arr[i] + " ");
                */
            return len;
        }


        // Binary search
        private static int GetCeilIndex(int[] arr, int[] tail, int l, int r, int key)
        {
            while (r - l > 1)
            {
                int m = l + (r - l) / 2;
                if (m >= 0 && arr[tail[m]] >= key)
                    r = m;
                else
                    l = m;
            }
            return r;
        }
    }
}
