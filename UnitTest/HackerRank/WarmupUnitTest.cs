using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;


namespace UnitTest.HackerRank
{
    [TestClass]
    public class WarmupUnitTest
    {
        [TestMethod]
        public void VeryBigSumTestMethod1()
        {
            int[] arr = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            BigInteger result = CSharpSurveys.RackerRank.Warmup.VeryBigSum.Solution.VeryBigSum(arr, arr.Length);

            Assert.AreEqual(5000000015, result);
        }

        [TestMethod]
        public void DiagonalDifferenceTestMethod1()
        {
            int[,] arr = { { 11, 2, 4, }, { 4, 5, 6 }, { 10, 8, -12 } };

            int result = CSharpSurveys.RackerRank.Warmup.DiagonalDifference.Solution.DiagonalDifference(arr.GetLength(0), arr);

            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void StairCaseTestMethod()
        {
            CSharpSurveys.RackerRank.Warmup.StairCase.Solution.StairCase(6);
        }

        [TestMethod]
        public void TimeConversionTestMethod1()
        {
            string time = "07:05:45PM";
            string result = CSharpSurveys.RackerRank.Warmup.TimeConversion.Solution.TimeConversion(time);
            Assert.AreEqual("19:05:45", result);
        }

        [TestMethod]
        public void TimeConversionTestMethod2()
        {
            string time = "12:00:00PM";
            string result = CSharpSurveys.RackerRank.Warmup.TimeConversion.Solution.TimeConversion(time);
            Assert.AreEqual("12:00:00", result);
        }

        [TestMethod]
        public void TimeConversionTestMethod3()
        {
            string time = "12:00:00AM";
            string result = CSharpSurveys.RackerRank.Warmup.TimeConversion.Solution.TimeConversion(time);
            Assert.AreEqual("00:00:00", result);
        }

        [TestMethod]
        public void CircularArrayRotationTestMethod1()
        {
            int[] arr = { 1, 2, 3 };
            int k = 2;

            int[] expectedResult = { 2, 3, 1 };
            CSharpSurveys.RackerRank.Warmup.CircularArrayRotation.Solution.RightRotateArray(arr.Length, k, arr);

            Assert.IsTrue(expectedResult.SequenceEqual(arr));
        }

    }
}
