using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class CountNonDivisible
    {
        public static int[] Solution(int[] A)
        {
            int[] result = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if ((i != j) && (A[i] % A[j] != 0))
                    {
                        result[i]++;
                    }
                }
            }

            return result;
        }
    }
}
