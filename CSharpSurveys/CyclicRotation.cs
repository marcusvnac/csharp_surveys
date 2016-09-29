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
                if (A.Length == 2)
                {
                    Array.Reverse(A);
                    result = A;
                }
                else
                {
                    int index = 0;
                    for (int i = K - 1; i < A.Length; i++)
                    {
                        index = i - (K - 1);
                        result[index] = A[i];
                    }

                    for (int i = 0; i < K - 1; i++)
                    {
                        index++;
                        result[index] = A[i];
                    }
                }
            }             
            return result;
        }
    }
}
