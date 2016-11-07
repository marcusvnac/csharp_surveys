using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class Dominator
    {
        public static int Solution(int[] A)
        {
            if (A.Length == 0)
                return -1;

            int[] aux = (int[])A.Clone();
            
            Array.Sort(A);
            bool found = false;
            int candidate = A[A.Length / 2];            
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == candidate)
                {
                    count++;

                    if (count > (A.Length / (double)2))
                    {
                        found = true;
                        break;
                    }
                }
            }

            int dominatorIndex = -1;
            if (found)
            {                
                for (int i = 0; i < A.Length; i++)
                {
                    if (aux[i] == candidate)
                    {
                        dominatorIndex = i;
                        break;
                    }
                }
            }
            return dominatorIndex;
        }
    }
}
