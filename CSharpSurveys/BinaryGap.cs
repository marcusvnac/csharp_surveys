using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys
{
    public static class BinaryGap
    {
        public static int Solution(int n)
        {
            int actualCounter = 0, maxCounter = 0;
            bool gap = false;

            string binaryNumber = Convert.ToString(n, 2);

            for (int i=0; i< binaryNumber.Length; i++)
            {
                char ch = binaryNumber[i];

                if (ch == '1')
                {
                    gap = true;

                    if (actualCounter > maxCounter)
                        maxCounter = actualCounter;
                    actualCounter = 0;
                }
                else if (gap)
                    actualCounter++;

            }

            return maxCounter;
        }
    }
}
