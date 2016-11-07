using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class Flags
    {
        public static int Solution(int[] A)
        {
            List<int> peaks = new List<int>();

            if (A.Length > 1)
            {
                int prior = A[0];
                int peakCandidate = -1;

                for (int i = 1; i < A.Length; i++)
                {
                    if (prior < A[i])
                    {
                        peakCandidate = i;
                    }
                    else if ((prior > A[i]) && (peakCandidate > -1))
                    {
                        peaks.Add(peakCandidate);
                    }
                    else
                    {
                        peakCandidate = -1;
                    }

                    prior = A[i];
                }
            }

            int flagCount = 0;
            if (peaks.Count > 0)
            {                
                int actualPeak = peaks[0];
                flagCount = 1;

                for (int i = 1; i < peaks.Count; i++)
                {
                    if ((peaks[i] - actualPeak - peaks.Count) >= 0)
                    {
                        flagCount++;
                        actualPeak = peaks[i];
                    }
                }
            }

            return flagCount;
        }
    }
}
