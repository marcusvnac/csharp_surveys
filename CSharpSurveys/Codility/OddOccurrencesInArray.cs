using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class OddOccurrencesInArray
    {
        public static int Solution(int[] A)
        {
            int result;
            List<int> unpaired = new List<int>();

            for(int i = 0; i < A.Length; i++)
            {
                if (unpaired.Contains(A[i]))
                    unpaired.Remove(A[i]);
                else
                    unpaired.Add(A[i]);
            }

            if (unpaired.Count == 1)
                result = unpaired[0];
            else
                result = -1;

            return result;
        }
    }
}
