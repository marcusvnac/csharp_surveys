using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.ProgIntervExp;

namespace UnitTest.ProgIntervExp
{
    [TestClass]
    public class RecursionUnitTest
    {
        [TestMethod]
        public void FactorialTestMethod1()
        {
            Assert.AreEqual(24, Recursion.Factorial(4));
        }

        [TestMethod]
        public void FactorialIterativeTestMethod1()
        {
            Assert.AreEqual(24, Recursion.FactorialIterative(4));
        }

        [TestMethod]
        public void AllFactorialsTestMethod1()
        {
            int[] results = { 24, 6, 2, 1 };
            Assert.IsTrue(results.SequenceEqual(Recursion.AllFactorials(4)));
        }

        [TestMethod]
        public void BinarySearchTestMethod1()
        {
            int[] array = { 1, 2, 5, 6, 24 };
            Assert.AreEqual(3, Recursion.BinarySearch(array, 6));
        }

        [TestMethod]
        public void BinarySearchIterativeTestMethod1()
        {
            int[] array = { 1, 2, 5, 6, 24 };
            Assert.AreEqual(3, Recursion.BinarySearchIterative(array, 6));
        }

        [TestMethod]
        public void PermutationsTestMethod1()
        {
            Permutations per = new Permutations("hat");
            per.Permute();
            
            Assert.AreEqual(6, per.PermutationList.Count);
        }

        [TestMethod]
        public void CombinationsTestMethod1()
        {
            Combinations comb = new Combinations("123");
            comb.Combine();

            Assert.AreEqual(7, comb.CombinationList.Count);
        }

        [TestMethod]
        public void TelephoneWordsTestMethod1()
        {
            int[] phoneNumber = { 4, 9, 7, 1, 9, 2, 7 };
            TelephoneNumber phone = new TelephoneNumber(phoneNumber);
            phone.PrintWords();

            Assert.AreEqual(729, phone.WordList.Count);
        }

        [TestMethod]
        public void TelephoneWordsIteractiveTestMethod1()
        {
            int[] phoneNumber = { 4, 9, 7, 1, 9, 2, 7 };
            TelephoneNumber phone = new TelephoneNumber(phoneNumber);
            phone.PrintWordsIteractive();

            Assert.AreEqual(729, phone.WordList.Count);
        }


    }
}
