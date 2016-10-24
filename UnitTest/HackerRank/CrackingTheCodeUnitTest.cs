using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.HackerRank
{
    [TestClass]
    public class CrackingTheCodeUnitTest
    {
        [TestMethod]
        public void LeftRotationTestMethod1()
        {
            int[] a = { 1, 2, 3, 4, 5 }, expected = { 5, 1, 2, 3, 4 };
            
            int [] result = CSharpSurveys.RackerRank.CrackingTheCode.LeftRotation.Solution.LeftRotateArray(a.Length, 4, a);
            Assert.IsTrue(expected.SequenceEqual(result));
        }


        [TestMethod]
        public void MakingAnagramsTestMethod1()
        {
            string a = "cde", b = "abc";
            
            int result = CSharpSurveys.RackerRank.CrackingTheCode.MakingAnagrams.Solution.CharsToDeleteToMakeAnagram(a, b);
            Assert.AreEqual(4, result); 
        }
        
    }
}
