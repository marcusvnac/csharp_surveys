namespace CSharpSurveys
{
    public static class CountDiv
    {
        public static int Solution(int A, int B, int K)
        {
            // Ninja solution
            if (A % K == 0)
                return ((B - A) / K) + 1;
            else
                return (B-(A- A%K))/ K;

            /*
             * // CS Guy Solution
            int count = 0;
            
            if (A < K)
                return count;

            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    count++;            
                }
            }

            return count;
            */
        }
    }
}
