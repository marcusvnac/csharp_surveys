using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

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

        [TestMethod]
        public void LilysHomeworkTestMethod1()
        {
            int res;
            using (StreamReader input = new StreamReader("HackerRank\\TestFiles\\LilysHomework-input09.txt"))
            {
                input.ReadLine();
                int[] a = Array.ConvertAll(input.ReadLine().Split(' '), int.Parse);

                res = CSharpSurveys.HackerRank.Challenges.LilysHomework.Solution.LilysHomework(a);
            }

            Assert.AreEqual(100, res);
        }


        [TestMethod]
        public void LilysHomeworkTestMethod2()
        {
            int[] a = { 2, 5, 3, 1 };

            int res = CSharpSurveys.HackerRank.Challenges.LilysHomework.Solution.LilysHomework(a);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void QuickSortTestMethod()
        {
            int[] a = { 5, 8, 1, 3, 7, 9, 2 };
            int[] res = { 1, 2, 3, 5, 7, 8, 9 };

            CSharpSurveys.HackerRank.Challenges.QuickSort.Solution.QuickSort(a);

            Assert.IsTrue(a.SequenceEqual(res));
        }
    }
}
