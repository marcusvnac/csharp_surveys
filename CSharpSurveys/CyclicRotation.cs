using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            int[] result = (int[])A.Clone();

            if ((K != 0) && (K <= A.Length))
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if ((j + (K - 1)) < A.Length)
                        result[j] = A[j + (K-1)];
                    else
                        result[j] = A[(j + (K - 1) - A.Length)];
                }
            } 
            return result;
        }
    }
}
