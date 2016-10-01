using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.Codility
{
    public static class CommonPrimeDivisors
    {
        public static int Solution(int[] A, int[] B)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    var primeDivisorsA = PrimeDivisors(CommonDivisors(A[i]));
                    var primeDivisorsB = PrimeDivisors(CommonDivisors(B[i]));

                    if ((primeDivisorsA.Count > 0) && (primeDivisorsA.SequenceEqual(primeDivisorsB)))
                        count++;
                }
                else
                {
                    var primeDivisors = PrimeDivisors(CommonDivisors(B[i]));
                    if (primeDivisors.Count > 0)
                        count++;
                }
            }

            return count;
        }

        private static List<int> CommonDivisors(int A)
        {
            List<int> result = new List<int>();

            for (int i = 2; i <= A/2; i++)
            {
                if (A % i == 0)
                    result.Add(i);
            }
            result.Add(A);

            return result;
        }

        private static List<int> PrimeDivisors(List<int> A)
        {
            List<int> result = new List<int>();

            foreach (var item in A)
            {
                if (IsPrime(item))
                    result.Add(item);
            }
            return result;
        }

        private static bool IsPrime(int number)
        {
            int i = 2;
            while (i * i <= number)
            {
                if (number % i == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
