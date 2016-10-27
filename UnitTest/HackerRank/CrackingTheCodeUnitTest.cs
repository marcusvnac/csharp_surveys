using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Globalization;
using System;
using System.Text;

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

            using (StreamReader fs = new StreamReader("HackerRank\\TestFiles\\BalancedBrackets-input10.txt"))
            {
                int nLines = int.Parse(fs.ReadLine());
                using (StreamReader outPut = new StreamReader("HackerRank\\TestFiles\\BalancedBrackets-output10.txt"))
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
        public void FindRunningMedianTestMethod1()
        {
            int[] a = { 12, 4, 5, 3, 8, 7 };
            double[] expectedResult = { 12.0, 8.0, 5.0, 4.5, 5.0, 6.0 };

            CSharpSurveys.RackerRank.CrackingTheCode.FindTheRunningMedian.Solution.RunningMedian rm = 
                new CSharpSurveys.RackerRank.CrackingTheCode.FindTheRunningMedian.Solution.RunningMedian();

            for (int i = 0; i < a.Length; i++)
            {                
                rm.AddValue(a[i]);
                Assert.AreEqual(expectedResult[i], rm.FindMedian());                
            }
        }

        [TestMethod]
        public void FindRunningMedianTestMethod2()
        {
            CSharpSurveys.RackerRank.CrackingTheCode.FindTheRunningMedian.Solution.RunningMedian rm =
                new CSharpSurveys.RackerRank.CrackingTheCode.FindTheRunningMedian.Solution.RunningMedian();

            using (StreamReader fs = new StreamReader("HackerRank\\TestFiles\\RunningMedian-input07.txt"))
            {
                int nLines = int.Parse(fs.ReadLine());
                using (StreamReader output = new StreamReader("HackerRank\\TestFiles\\RunningMedian-output07.txt"))
                {
                    string valueStr;
                    while (nLines > 0 && (valueStr = fs.ReadLine()) != null)
                    {
                        string expectedResult = output.ReadLine();
                        rm.AddValue(int.Parse(valueStr));
                        Assert.AreEqual(expectedResult, rm.FindMedian().ToString("F1", CultureInfo.InvariantCulture));

                        nLines--;
                    }
                }
            }
        }


        [TestMethod]
        public void ContactsTestMethod1()
        {
            string[] operations = { "add hack", "add hackerrank", "find hac", "find hak" };
            int[] expectedResult = { 2, 0 };

            CSharpSurveys.RackerRank.CrackingTheCode.Contacts.TrieNode trie =
                new CSharpSurveys.RackerRank.CrackingTheCode.Contacts.TrieNode();

            int count = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                
                string[] tokens_op = operations[i].Split(' ');

                CSharpSurveys.RackerRank.CrackingTheCode.Contacts.Solution.Operation op = 
                    (CSharpSurveys.RackerRank.CrackingTheCode.Contacts.Solution.Operation)Enum.Parse(typeof(CSharpSurveys.RackerRank.CrackingTheCode.Contacts.Solution.Operation), tokens_op[0]);

                string contact = tokens_op[1];
                    
                switch (op)
                {
                    case CSharpSurveys.RackerRank.CrackingTheCode.Contacts.Solution.Operation.add:
                        trie.AddWord(contact);
                        break;
                    case CSharpSurveys.RackerRank.CrackingTheCode.Contacts.Solution.Operation.find:
                        int foundCounter = trie.FindCountPartial(contact);
                        Assert.AreEqual(expectedResult[count++], foundCounter);
                        break;
                }
            }
        }

        [TestMethod]
        public void MergeSortTestMethod1()
        {
            int[] a = { 2, 1, 3, 1, 2 }, expectedResult = { 1, 1, 2, 2, 3 };

            long swaps = CSharpSurveys.RackerRank.CrackingTheCode.MergeSort.Solution.MergeSort(a);

            Assert.IsTrue(expectedResult.SequenceEqual(a));
            Assert.AreEqual(4, swaps);
        }

        [TestMethod]
        public void MergeSortTestMethod2()
        {
            int[] a = { 1, 1, 1, 2, 2 }, expectedResult = { 1, 1, 1, 2, 2 };

            long swaps = CSharpSurveys.RackerRank.CrackingTheCode.MergeSort.Solution.MergeSort(a);

            Assert.IsTrue(expectedResult.SequenceEqual(a));
            Assert.AreEqual(0, swaps);
        }

        [TestMethod]
        public void MergeSortTestMethod3()
        {
            CSharpSurveys.RackerRank.CrackingTheCode.FindTheRunningMedian.Solution.RunningMedian rm =
                new CSharpSurveys.RackerRank.CrackingTheCode.FindTheRunningMedian.Solution.RunningMedian();

            using (StreamReader fs = new StreamReader("HackerRank\\TestFiles\\MergeSort-input04.txt"))
            {
                int nDatasets = int.Parse(fs.ReadLine());                
                using (StreamReader output = new StreamReader("HackerRank\\TestFiles\\MergeSort-output04.txt"))
                {

                    string nElements;
                    while (nDatasets > 0 && (nElements = fs.ReadLine()) != null)
                    {
                        string[] arr_temp = fs.ReadLine().Split(' ');
                        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                        long expectedResult = int.Parse(output.ReadLine());

                        long swaps = CSharpSurveys.RackerRank.CrackingTheCode.MergeSort.Solution.MergeSort(arr);

                        Assert.AreEqual(expectedResult, swaps);

                        nDatasets--;
                    }
                }
            }
        }

        [TestMethod]
        public void IceCreamParlorTestMethod1()
        {
            int[] arr = { 1, 4, 5, 3, 2, };
            string expectedResult = "1 4";
            int m = 4;

            CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.Flavor[] flavors = new CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.Flavor[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                flavors[i] = new CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.Flavor(i + 1, arr[i]);
            }

            Array.Sort(flavors, new CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.FlavorComparer());

            string result = "";
            foreach (var flavor in flavors)
            {
                int CostComplement = m - flavor.Cost;

                CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.Flavor secondFlavor =
                    CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.BinarySearch(flavors, CostComplement, flavor.ID);

                if (secondFlavor != null)
                {
                    result = flavor.ID + " " + secondFlavor.ID;
                    break;
                }
            }                        
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void IceCreamParlorTestMethod2()
        {
            using (StreamReader input = new StreamReader("HackerRank\\TestFiles\\IceCreamParlor-input01.txt"))
            {
                int t = int.Parse(input.ReadLine());
                using (StreamReader output = new StreamReader("HackerRank\\TestFiles\\IceCreamParlor-output01.txt"))
                {
                    string nStr;
                    while (t > 0 && (nStr = input.ReadLine()) != null)
                    {
                        int m = int.Parse(nStr);
                        int n = int.Parse(input.ReadLine());
                        string[] arr_temp = input.ReadLine().Split(' ');
                        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

                        string expectedResult = output.ReadLine();

                        CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.Flavor[] flavors = new CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.Flavor[n];
                        for (int i = 0; i < n; i++)
                        {
                            flavors[i] = new CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.Flavor(i + 1, arr[i]);
                        }

                        Array.Sort(flavors, new CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.FlavorComparer());

                        string result = "";
                        foreach (var flavor in flavors)
                        {
                            int CostComplement = m - flavor.Cost;

                            CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.Flavor secondFlavor =
                                CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor.Solution.BinarySearch(flavors, CostComplement, flavor.ID);

                            if (secondFlavor != null)
                            {
                                if (flavor.ID < secondFlavor.ID )
                                    result = flavor.ID + " " + secondFlavor.ID;
                                else
                                    result = secondFlavor.ID + " " + flavor.ID;

                                break;
                            }
                        }

                        Assert.AreEqual(expectedResult, result);

                        t--;
                    }
                }
            }
        }

        [TestMethod]
        public void ConnectedCellsInGridMethod1()
        {
            int[,] grid = { { 1, 1, 0, 0, 0 },
                         { 0, 1, 1, 0, 0 },
                         { 0, 0, 1, 0, 1 },
                         { 1, 0, 0, 0, 1 },
                         { 0, 1, 0, 1, 1} };
            


            CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Graph graph = 
                new CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Graph();
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (grid[row, col] == 1)
                    {
                        CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Point point = 
                            new CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Point(row, col);
                        CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Node node = 
                            new CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Node(point);

                        graph.AddNode(node);
                    }
                }                
            }

            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (grid[row, col] == 1)
                    {
                        CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Point point =
                            new CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Point(row, col);
                        CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid.Solution.Node node = graph.GetNode(point);
                        graph.MakeConnexions(node, grid);
                    }
                }
            }

            Assert.AreEqual(5, graph.LargestRegion());
        }

        [TestMethod]
        public void ShortestReachGraphTestMethod()
        {
            var n = 4;

            CSharpSurveys.RackerRank.CrackingTheCode.ShortestReachGraph.Solution.Graph graph = 
                new CSharpSurveys.RackerRank.CrackingTheCode.ShortestReachGraph.Solution.Graph(n);

            // Creating nodes and adding to the graph
            for (int nodeCount = 1; nodeCount <= n; nodeCount++)
                graph.AddNode(new CSharpSurveys.RackerRank.CrackingTheCode.ShortestReachGraph.Solution.Node(nodeCount));

            // Creating edges
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);

            int s = 1;

            // Calc Shortest Distance to all nodes
            int[] distances = graph.ShortestDistances(s);
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i < distances.Length; i++)
            {
                if (distances[i] != 0)
                    sb.Append(distances[i] + " ");
            }
            sb.Length = sb.Length - 1;

            Assert.AreEqual("6 6 -1", sb.ToString());
        }

        [TestMethod]
        public void DaviStairCaseMethod1()
        {
            Assert.AreEqual(1, CSharpSurveys.RackerRank.CrackingTheCode.RecursiveStaircase.Solution.DaviStaircase(1));
            Assert.AreEqual(4, CSharpSurveys.RackerRank.CrackingTheCode.RecursiveStaircase.Solution.DaviStaircase(3));
            Assert.AreEqual(44, CSharpSurveys.RackerRank.CrackingTheCode.RecursiveStaircase.Solution.DaviStaircase(7));
        }


    }
}
