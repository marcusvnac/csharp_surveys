using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class GenomicRangeQuery
    {
        public static int[] Solution(string S, int[] P, int[] Q)
        {
            int[] result = new int[P.Length];

            for (int m = 0; m < P.Length; m++)
            {
                result[m] = int.MaxValue;
                for (int n = P[m]; n <= Q[m]; n++)
                {
                    var ch = S[n];
                    int value = 0;

                    switch (ch)
                    {
                        case'A':
                            value = 1;
                            break;
                        case 'C':
                           value = 2;
                            break;
                        case 'G':
                            value = 3;
                            break;
                        case 'T':
                            value = 4;
                            break;
                    }

                    if (value < result[m])
                        result[m] = value;

                }

            }
            return result;
        }
    }
}
