using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            bool[] leavesPosition = new bool[X];


            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= X)
                    leavesPosition[A[i]-1] = true;

                if (!leavesPosition.Any(t => t.Equals(false)))
                    return i;
            }

            return -1;
        }
    }
}
