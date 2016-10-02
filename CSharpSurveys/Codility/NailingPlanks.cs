using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class NailingPlanks
    {
        public static int Solution(int[] A, int[] B, int[] C)
        {
            Array.Sort(C);
            List<int> usedNails = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                var nailValue = C.FirstOrDefault(x => x >= A[i] && x <= B[i]);

                if (nailValue == 0)
                    return -1;

                var index = BinarySearch(nailValue, C);

                if (!usedNails.Contains(index))
                    usedNails.Add(index);                
            }

            int count = usedNails.Count == 0 ? -1 : usedNails.Count;
            return count;
        }

        private static int BinarySearch(int x, int[] V)
        {
            int e, m, d;

            e = 0;
            d = V.Length-1;

            while(e <= d)
            {
                m = (e + d) / 2;
                if (V[m] == x)
                    return m;
                if (V[m] < x)
                    e = m + 1;
                else
                    d = m - 1;
            }
            return -1;
        }
    }
}
