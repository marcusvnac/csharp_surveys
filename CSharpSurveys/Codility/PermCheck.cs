using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class PermCheck
    {
        public static int Solution(int[] A)
        {
            int result = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A.Length)
                {
                    result = 0;
                    break;
                }
            }

            return result;
        }
    }
}
