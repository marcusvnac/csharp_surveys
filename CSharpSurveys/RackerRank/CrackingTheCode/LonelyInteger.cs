using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.FindLonelyInteger
{
    class Solution
    {
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            Console.WriteLine(FindLonelyInteger(a, n));
        }
        */

        static int FindLonelyInteger(int[] a, int n)
        {
            if (n == 1)
                return a[0];
            else
            {

                int MAX_VALUE = 101;
                bool[] oddMap = new bool[MAX_VALUE];

                foreach (var val in a)
                {
                    oddMap[val] = !oddMap[val];
                }

                for (int i = 0; i < MAX_VALUE; i++)
                {
                    if (oddMap[i])
                        return i;
                }
                return -1;
            }
        }

        // Bit manipulation approach
        static int Lonely(int[] a)
        {
            int res = 0;
            foreach (var i in a)
            {
                res = res ^ i;
            }
            return res;
        }
    }
}
