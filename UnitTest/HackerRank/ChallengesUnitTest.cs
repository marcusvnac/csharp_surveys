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

        [TestMethod]
        public void RadioTransmiterSubsequenceTestMethod1()
        {
            int res;
            using (StreamReader input = new StreamReader("HackerRank\\TestFiles\\RadioTransmiter-input10.txt"))
            {
                string[] tokens_n = input.ReadLine().Split(' ');
                Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] x_temp = input.ReadLine().Split(' ');
                int[] x = Array.ConvertAll(x_temp, Int32.Parse);

                res = CSharpSurveys.HackerRank.Challenges.RadioTransmiter.Solution.Transmiters(k, x);  
            }

            Assert.AreEqual(2440, res);
        }

        [TestMethod]
        public void RadioTransmiterSubsequenceTestMethod2()
        {            
            int k = 1;
            int[] x = { 1, 2, 3, 4, 5 };

            int res = CSharpSurveys.HackerRank.Challenges.RadioTransmiter.Solution.Transmiters(k, x);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void RadioTransmiterSubsequenceTestMethod3()
        {
            int res;
            using (StreamReader input = new StreamReader("HackerRank\\TestFiles\\RadioTransmiter-input06.txt"))
            {
                string[] tokens_n = input.ReadLine().Split(' ');
                Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] x_temp = input.ReadLine().Split(' ');
                int[] x = Array.ConvertAll(x_temp, Int32.Parse);

                res = CSharpSurveys.HackerRank.Challenges.RadioTransmiter.Solution.Transmiters(k, x);
            }

            Assert.AreEqual(620, res);
        }
    }
}
