using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class Triangle
    {
        public static int Solution(int[] A)
        {
            if (A.Length >= 3)
            {
                Array.Sort(A);

                for (int i = 0; i < A.Length - 2; i++)
                {
                    int P = i, Q = i + 1, R = i + 2;

                    if ((A[P] == 0) || (A[Q] == 0) || (A[R] == 0))
                        continue;

                    if (((int.MaxValue == A[P]) || (int.MaxValue == A[Q]) || (int.MaxValue == A[R]))
                        && ((A[P] > 0) || (A[Q] > 0) || (A[R] > 0)))
                        return 1;

                    if (((int.MinValue == A[P]) || (int.MinValue == A[Q]) || (int.MinValue == A[R]))
                        && ((A[P] < 0) || (A[Q] < 0) || (A[R] < 0)))
                        continue;


                    if ((A[P] + A[Q] > A[R]) 
                        && (A[Q] + A[R] > A[P]
                        && (A[R] + A[P] > A[Q])))
                        return 1;
                }
                return 0;
            }
            else
                return 0;
        }
    }
}
