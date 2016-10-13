using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.ProgIntervExp;

namespace UnitTest.ProgIntervExp
{
    [TestClass]
    public class BinarySeachTreeUnitTest
    {
        private Node root = new Node(null, null, 5);

        [TestInitialize]
        public void InitializeTree()
        {            
            BinarySearchTree.AddNote(root, new Node(3));
            BinarySearchTree.AddNote(root, new Node(10));
            BinarySearchTree.AddNote(root, new Node(1));
            BinarySearchTree.AddNote(root, new Node(4));
            BinarySearchTree.AddNote(root, new Node(7));
            BinarySearchTree.AddNote(root, new Node(12));
        }

        [TestMethod]
        public void PreorderTraversalTestMethod1()
        {            
            string result = BinarySearchTree.PreorderTraversal(root);

            Assert.AreEqual("5 3 1 4 10 7 12", result.Trim());
        }

        [TestMethod]
        public void PreorderTraversalTestMethod2()
        {
            string result = BinarySearchTree.PreorderTraversalIterative(root);

            Assert.AreEqual("5 3 1 4 10 7 12", result.Trim());
        }

        [TestMethod]
        public void PostorderTraversalTestMethod1()
        {
            string result = BinarySearchTree.PostorderTraversal(root);

            Assert.AreEqual("1 4 3 7 12 10 5", result.Trim());
        }


        [TestMethod]
        public void InorderTraversalTestMethod1()
        {
            string result = BinarySearchTree.InorderTraversal(root);

            Assert.AreEqual("1 3 4 5 7 10 12", result.Trim());
        }

        [TestMethod]
        public void TreeHightTestMethod1()
        {
            var result = BinarySearchTree.TreeHeight(root);

            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void BreadthFirstSearchTraversaltTestMethod1()
        {
            var result = BinarySearchTree.BreadthFirstSearchTraversal(root);

            Assert.AreEqual("5 3 10 1 4 7 12", result.Trim());
        }

        [TestMethod]
        public void FindLowestAncertorTestMethod1()
        {
            Node localRoot = new Node(20);
            BinarySearchTree.AddNote(localRoot, new Node(20));
            BinarySearchTree.AddNote(localRoot, new Node(8));
            BinarySearchTree.AddNote(localRoot, new Node(22));
            BinarySearchTree.AddNote(localRoot, new Node(4));
            BinarySearchTree.AddNote(localRoot, new Node(12));
            BinarySearchTree.AddNote(localRoot, new Node(10));
            BinarySearchTree.AddNote(localRoot, new Node(14));


            Node result = BinarySearchTree.FindLowestCommonAncestor(localRoot, 4, 14);

            Assert.AreEqual(8, result.Value);
        }

        [TestMethod]
        public void IsBalancedTestMethod1()
        {
            var result = BinarySearchTree.IsBalanced(root);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsBalancedTestMethod2()
        {
            Node localRoot = new Node(20);
            BinarySearchTree.AddNote(localRoot, new Node(20));
            BinarySearchTree.AddNote(localRoot, new Node(8));
            BinarySearchTree.AddNote(localRoot, new Node(22));
            BinarySearchTree.AddNote(localRoot, new Node(4));
            BinarySearchTree.AddNote(localRoot, new Node(12));
            BinarySearchTree.AddNote(localRoot, new Node(10));
            BinarySearchTree.AddNote(localRoot, new Node(14));


            var result = BinarySearchTree.IsBalanced(localRoot);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsBalanced2TestMethod1()
        {
            var result = BinarySearchTree.IsBalanced2(root);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsBalanced2TestMethod2()
        {
            Node localRoot = new Node(20);
            BinarySearchTree.AddNote(localRoot, new Node(20));
            BinarySearchTree.AddNote(localRoot, new Node(8));
            BinarySearchTree.AddNote(localRoot, new Node(22));
            BinarySearchTree.AddNote(localRoot, new Node(4));
            BinarySearchTree.AddNote(localRoot, new Node(12));
            BinarySearchTree.AddNote(localRoot, new Node(10));
            BinarySearchTree.AddNote(localRoot, new Node(14));


            var result = BinarySearchTree.IsBalanced2(localRoot);

            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void UnbalancedBinaryTreeTestMethod1()
        {
            Node localRoot = new Node(6);
            BinarySearchTree.AddNote(localRoot, new Node(4));
            BinarySearchTree.AddNote(localRoot, new Node(7));
            BinarySearchTree.AddNote(localRoot, new Node(2));
            BinarySearchTree.AddNote(localRoot, new Node(5));
            BinarySearchTree.AddNote(localRoot, new Node(1));
            BinarySearchTree.AddNote(localRoot, new Node(3));

            var result = BinarySearchTree.BreadthFirstSearchTraversal(localRoot);

            Assert.AreEqual("6 4 7 2 5 1 3", result.Trim());
            Assert.AreEqual(4, BinarySearchTree.TreeHeight(localRoot));

            Node rotateNode = BinarySearchTree.FindNode(localRoot, 6);
            Node newRoot = BinarySearchTree.FindNode(localRoot, 4);
            rotateNode.rotateRight();

            var result2 = BinarySearchTree.BreadthFirstSearchTraversal(newRoot);

            Assert.AreEqual("4 2 6 1 3 5 7", result2.Trim());
            Assert.AreEqual(3, BinarySearchTree.TreeHeight(newRoot));

        }

        [TestMethod]
        public void RemoveNodeTestMethod1()
        {
            Node localRoot = new Node(50);
            BinarySearchTree.AddNote(localRoot, new Node(40));
            BinarySearchTree.AddNote(localRoot, new Node(70));
            BinarySearchTree.AddNote(localRoot, new Node(60));
            BinarySearchTree.AddNote(localRoot, new Node(80));

            var result = BinarySearchTree.BreadthFirstSearchTraversal(localRoot);

            Assert.AreEqual("50 40 70 60 80", result.Trim());
            Assert.AreEqual(3, BinarySearchTree.TreeHeight(localRoot));

            localRoot = BinarySearchTree.RemoveNode(localRoot, 50);

            var result2 = BinarySearchTree.BreadthFirstSearchTraversal(localRoot);

            Assert.AreEqual("60 40 70 80", result2.Trim());
            Assert.AreEqual(3, BinarySearchTree.TreeHeight(localRoot));
        }


    }
}
