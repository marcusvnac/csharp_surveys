using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class MaxProductOfThree
    {
        public static int Solution(int[] A)
        {
            if (A.Length >= 3)
            {
                Array.Sort(A);

                int res = A[A.Length - 3] * A[A.Length - 2] * A[A.Length - 1];

                return res;
            }
            else
                return 0;
        }
    }
}
