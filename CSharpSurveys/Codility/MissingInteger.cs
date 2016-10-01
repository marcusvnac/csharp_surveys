using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class MissingInteger
    {
        public static int Solution(int[] A)
        {
            int maxNumber = 1;

            bool[] numberMap = new bool[A.Length+1];

            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] < A.Length))
                    numberMap[A[i]] = true;

                if (A[i] > maxNumber)
                    maxNumber = A[i];
            }


            for (int i = 1; i < maxNumber; i++)
            {
                if (!numberMap[i])
                    return i;
            }

            return maxNumber+1;
        }
    }
}
