using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class MaxSliceSum
    {
        public static int Solution(int[] A)
        {
            int max_ending = 0;
            int max_slice = int.MinValue;

            foreach (var a in A)
            {
                int sum;

                if ((max_ending + a) > int.MaxValue)
                    sum = int.MaxValue;
                else
                    sum = max_ending + a;

                max_ending = Math.Max(a, sum);
                max_slice = Math.Max(max_slice, max_ending);
            }

            return max_slice;
        }
    }
}
