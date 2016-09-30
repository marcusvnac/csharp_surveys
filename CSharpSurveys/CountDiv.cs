using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class CountDiv
    {
        public static int Solution(int A, int B, int K)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    count++;
                    i++;
                }
            }

            return count;
        }
    }
}
