using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class NumberOfDiscIntersections
    {
        public static int Solution(int[] A)
        {
            int intersections = 0;
            if (A.Length > 1)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    int posLeft; 
                    int posRight;

                    if (A[i] == int.MaxValue)
                    {
                        posLeft = A[i];
                        posRight = A[i];
                    }
                    else
                    {
                        posLeft = i - A[i];
                        posRight = i + A[i];
                    }
                    
                    for (int j = i+1; j < A.Length; j++)
                    {
                        int actualPosLeft;
                        int actualPosRight;

                        if (A[j] == int.MaxValue)
                        {
                            actualPosLeft = A[j];
                            actualPosRight = A[j];
                        }
                        else
                        {
                            actualPosLeft = j - A[j];
                            actualPosRight = j + A[j];
                        }

                        if ((posLeft == posRight) && (actualPosLeft == actualPosRight))
                            continue;

                        if ((posLeft == posRight) && (posLeft < actualPosLeft))
                            continue;


                        if (((posLeft <= actualPosLeft) && (posRight <= actualPosRight))
                            || (((posLeft <= actualPosRight) && (posLeft >= actualPosLeft))
                            || ((posRight >= actualPosLeft) && (posRight <= actualPosRight))))
                        {
                            intersections++;
                            if (intersections >= 10000000)
                                return -1;
                        }
                    }
                }
            }
            
            return intersections;
        }
    }
}
