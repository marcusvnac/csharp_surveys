using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest.HackerRank
{
    [TestClass]
    public class ChallengesUnitTest
    {
        [TestMethod]
        public void LongestIncreasingSubsequenceTestMethod1()
        {
            int[] arr = { 15, 27, 14, 38, 26, 55, 46, 65, 85 };
            int res = CSharpSurveys.HackerRank.Challenges.LongestIncreasingSubsequence.Solution.LongestSubseq(arr, arr.Length);

            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void LongestIncreasingSubsequenceTestMethod2()
        {
            int[] arr = { 2, 7, 4, 3, 8 };
            int res = CSharpSurveys.HackerRank.Challenges.LongestIncreasingSubsequence.Solution.LongestSubseq(arr, arr.Length);

            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void LongestIncreasingSubsequenceTestMethod3()
        {
            int[] arr; 
            using (StreamReader input = new StreamReader("HackerRank\\TestFiles\\LongestIncreasingSubsequence-input05.txt"))
            {
                int n = int.Parse(input.ReadLine());
                arr = new int[n];
                for (int i = 0; i < n; i++)
                    arr[i] = int.Parse(input.ReadLine());
            }
                
            int res = CSharpSurveys.HackerRank.Challenges.LongestIncreasingSubsequence.Solution.LongestSubseq(arr, arr.Length);

            Assert.AreEqual(1966, res);
        }


    }
}
