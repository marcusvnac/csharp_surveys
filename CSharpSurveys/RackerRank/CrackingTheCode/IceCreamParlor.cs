using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.IceCreamParlor
{
    public class Solution
    {
        
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                int id = 1;
                BinarySearchTree bst = new BinarySearchTree(new FlavorNode(id, a[0]));
                for (int i=1; i<n; i++)
                {
                    id++;
                    bst.AddNode(new FlavorNode(id, a[i]));
                }

                FlavorNode[] result = bst.FindFlavors(m);
                foreach (var item in result.OrderBy(x => x.ID))
                {
                    Console.Write(item.ID + " ");
                }
                Console.WriteLine();
            }
        }
        
        public class FlavorNode
        {
            public FlavorNode(FlavorNode left, FlavorNode right, int ID, int cost)
            {
                Left = left;
                Right = right;
                Cost = cost;
                this.ID = ID;
            }

            public FlavorNode(int ID, int cost)
            {
                Cost = cost;
                this.ID = ID;
            }

            public FlavorNode Left { get; set; }
            public FlavorNode Right { get; set; }
            public int Cost { get; set; }
            public int ID { get; set; }
        }

        public class BinarySearchTree
        {
            private FlavorNode root;

            public BinarySearchTree(FlavorNode first)
            {
                root = first;
            }

            public bool AddNode(FlavorNode newNode)
            {
                if (root == null)
                {                    
                    return false;
                }
                else
                {
                    FlavorNode actualNode = root;
                    FlavorNode parent;
                    int value = newNode.Cost;

                    while (true)
                    {
                        parent = actualNode;

                        if (value <= actualNode.Cost)
                        {
                            actualNode = actualNode.Left;
                            if (actualNode == null)
                            {
                                parent.Left = newNode;
                                return true;
                            }
                        }
                        else
                        {
                            actualNode = actualNode.Right;
                            if (actualNode == null)
                            {
                                parent.Right = newNode;
                                return true;
                            }
                        }
                    }

                }

            }

            public FlavorNode[] FindFlavors(int m)
            {
                FlavorNode[] result = new FlavorNode[2];
                FindFlavors(root, m, result);
                return result;
            }

            public int FindFlavors(FlavorNode node, int m, FlavorNode[] flavors)
            {
                if (node == null)
                    return 0;

                int totalCost = 0;
                totalCost = PreorderTraversal(node, m, flavors);
                if (totalCost != m)
                {
                    ClearFlavors(flavors);
                    totalCost = FindFlavors(node.Left, m, flavors);
                    if (totalCost != m)
                        totalCost = FindFlavors(node.Right, m, flavors);
                }

                return totalCost;
            }

            private void ClearFlavors(FlavorNode[] flavors)
            {
                flavors[0] = null;
                flavors[1] = null;
            }

            private int PreorderTraversal(FlavorNode node, int m, FlavorNode[] flavors)
            {
                if (node == null || AllFlavorsFound(flavors, m))
                    return 0;

                int totalCost = 0;
                if ((node.Cost <= m - 1) && BuyFlavor(node, flavors, m))
                {
                    totalCost = node.Cost;
                }
                    
                totalCost += PreorderTraversal(node.Left, m, flavors);
                totalCost += PreorderTraversal(node.Right, m, flavors);
                return totalCost;
            }

            private bool BuyFlavor(FlavorNode node, FlavorNode[] flavors, int m)
            {
                if (node.Cost > m - 1)
                    return false;

                if (flavors[0] == null && flavors[1] == null)
                {
                    flavors[0] = node;
                    return true;
                }

                if (flavors[0] != null)
                {
                    if (flavors[0].Cost + node.Cost == m)
                    {
                        flavors[1] = node;
                        return true;
                    }
                }
                return false;
            }

            private bool AllFlavorsFound(FlavorNode[] flavors, int m)
            {
                if (flavors[0] != null && flavors[1] != null)
                    return flavors[0].Cost + flavors[1].Cost == m;
                else
                    return false;
            }
        }
    }
}
