using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            int result = int.MaxValue;

            for(int p = 1; p < A.Length; p++)
            {
                var firstSum = 0;
                var secondSum = 0;

                for (int i = 0; i < p; i++)
                {
                    firstSum += A[i];
                }

                for (int j = p; j < A.Length; j++)
                {
                    secondSum += A[j];
                }
                
                var absDiff = Math.Abs(firstSum - secondSum);
                if (absDiff < result)
                    result = absDiff;
            }

            return result;
        }
    }
}
