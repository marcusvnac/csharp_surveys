using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class MinAvgTwoSlice
    {
        public static int Solution(int[] A)
        {
            double[] avgArr = new double[A.Length];
            double minAvg = double.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                avgArr[i] = int.MaxValue;

                var sum = A[i];
                for (int j = i+1; j < A.Length; j++)
                {
                    sum += A[j];
                    var avg = sum / (double)(j - i + 1);
                    if (avg < avgArr[i])
                        avgArr[i] = avg;
                }

                if (avgArr[i] < minAvg)
                    minAvg = avgArr[i];
            }

            int res = 0;
            for (int i = avgArr.Length-1; i >=0 ; i--)
            {
                if (avgArr[i].Equals(minAvg))
                    res = i;

            }
            return res;
        }
    }
}
