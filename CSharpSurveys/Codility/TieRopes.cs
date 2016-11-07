using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class TieRopes
    {
        public static int Solution(int K, int[] A)
        {
            int length = 0;
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                length += A[i];

                if (length >= K)
                {
                    count++;
                    length = 0;
                }
            }
            return count;
        }
    }
}
