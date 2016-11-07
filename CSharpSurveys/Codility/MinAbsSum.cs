using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class MinAbsSum
    {
        public static int Solution(int[] A)
        {
            int[] S = new int[A.Length];

            int sVal = -1;
            for (int i = 0; i < S.Length; i++)
            {
                S[i] = sVal;
                sVal *= -1;
            }



            return 0;
        }
    }
}
