using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class PassingCars
    {
        public static int Solution(int[] A)
        {
            int west = 0;
            int pass_cars = 0;

            for (int i = A.Length-1; i > -1; i--)
            {
                if (A[i] == 0)
                {
                    pass_cars += west;

                    if (pass_cars > 1000000000)
                        return -1;
                }
                else
                {
                    west += 1;
                }
            }
            return pass_cars;
            
            /*
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == 1)
                            count++;
                    }
                }
            }

            if (count > 1000000000)
                return -1;
            else
                return count;
                */
        }
    }
}
