using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

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

        [TestMethod]
        public void RansomNoteTestMethod1()
        {
            string[] magazine = { "give", "me", "one", "grand", "today", "night" },
                     ransom = { "give",  "one", "grand", "today" };
            
            Assert.IsTrue(CSharpSurveys.RackerRank.CrackingTheCode.RansomNote.Solution.CanBuildRansonNote(magazine, ransom));
        }


        [TestMethod]
        public void BalancedBracketsTestMethod1()
        {
            string brackets1 = "{[()]}", brackets2 = "{[(])}", brackets3 = "{{[[(())]]}}";


            Assert.IsTrue(CSharpSurveys.RackerRank.CrackingTheCode.BalancedBrackets.Solution.IsBracketBalanced(brackets1));
            Assert.IsFalse(CSharpSurveys.RackerRank.CrackingTheCode.BalancedBrackets.Solution.IsBracketBalanced(brackets2));
            Assert.IsTrue(CSharpSurveys.RackerRank.CrackingTheCode.BalancedBrackets.Solution.IsBracketBalanced(brackets3));
        }

        [TestMethod]
        public void BalancedBracketsTestMethod2()
        {

            using (StreamReader fs = new StreamReader("HackerRank\\BalancedBrackets-input10.txt"))
            {
                int nLines = int.Parse(fs.ReadLine());
                using (StreamReader outPut = new StreamReader("HackerRank\\BalancedBrackets-output10.txt"))
                {
                    string expectedResult = outPut.ReadLine();

                    string brackets;
                    while (nLines > 0 && (brackets = fs.ReadLine()) != null)
                    {
                        string result = CSharpSurveys.RackerRank.CrackingTheCode.BalancedBrackets.Solution.IsBracketBalanced(brackets) ? "YES" : "NO";
                        Assert.AreEqual(expectedResult, result);

                        nLines--;
                    }
                }
            }                
        }

        [TestMethod]
        public void QueueUsingTwoStacksTestMethod1()
        {

        }
    }
}
