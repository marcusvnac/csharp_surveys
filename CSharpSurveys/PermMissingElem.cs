using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            int result = 0;
            int[] aux = new int[A.Length+1];

            for (int i = 0; i < A.Length; i++)
            {
                aux[A[i]-1] = 1;
            }

            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == 0)
                {
                    result = i + 1;
                    break;
                }
            }

            return result;
        }
    }
}
