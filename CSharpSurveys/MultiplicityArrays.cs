using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurvey
{
    public class MultiplicityArrays
    {

        public int solution(int[] A, int[] B)
        {
            int N = A.Length;
            double[] C = new double[N];

            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + (Double)B[i] / 1000000;
            }

            int multPairsCount = 0;
            for (int p = 0; p < N; p++)
            {
                for (int q = p + 1; q < N; q++)
                {
                    if (C[p] * C[q] >= C[p] + C[q])
                        multPairsCount++;
                }
            }

            return multPairsCount;
        }


    }
}
