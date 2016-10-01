using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class Distinct
    {
        public static int Solution(int[] A)
        {
            Array.Sort(A);

            if (A.Length > 0)
            {
                int counter = 1;
                int priorNumber = A[0];

                for (int i = 1; i < A.Length; i++)
                {
                    if (A[i] != priorNumber)
                    {
                        counter++;
                        priorNumber = A[i];
                    }
                }
                return counter;
            }
            else
                return 0;
        }
    }
}
