using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.ShortestReachGraph
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                string[] firstLineStr = Console.ReadLine().Split(' ');
                int n = int.Parse(firstLineStr[0]);
                int m = int.Parse(firstLineStr[1]);

                Graph graph = new Graph(n);
                
                // Creating nodes and adding to the graph
                for (int nodeCount = 1; nodeCount <= n; nodeCount++)
                    graph.AddNode(new Node(nodeCount));

                // Creating edges
                for (int j = 0; j < m; j++)
                {
                    string[] edgeStr = Console.ReadLine().Split(' ');
                    int u = int.Parse(edgeStr[0]);
                    int v = int.Parse(edgeStr[1]);

                    graph.AddEdge(u, v);
                }
                int s = Convert.ToInt32(Console.ReadLine());
                
                // Calc Shortest Distance to all nodes
                int[] distances = graph.ShortestDistances(s);
                StringBuilder sb = new StringBuilder();
                for (int d = 1; d < distances.Length; d++)
                {
                    if (distances[d] != 0)
                        sb.Append(distances[d] + " ");
                }
                sb.Length = sb.Length - 1;
                Console.WriteLine(sb.ToString());
            }
        }
        */

        private class NodeComparer : IComparer<Node>
        {
            public int Compare(Node x, Node y)
            {                
                int mv = x.ID, nv = y.ID;
                return (mv < nv ? -1 : (mv == nv ? 0 : 1));
            }
        }

        public class Node
        {
            public int ID { get; }
            public bool Visited { get; set; }

            private List<Node> edgeList;

            public List<Node> AdjacentNodes { get { return edgeList; } }

            public Node(int ID)
            {
                this.ID = ID;
                this.edgeList = new List<Node>();
            }

            public void OrderAdjacentNodes()
            {
                edgeList.Sort(new NodeComparer());
            }
        }

        public class Graph
        {
            private List<Node> nodeList;

            public Graph(int nodes)
            {
                nodeList = new List<Node>(nodes);
            }

            public void AddNode(Node node)
            {
                if (!nodeList.Contains(node))
                    nodeList.Add(node);
            }

            public Node GetNode(int v)
            {
                return nodeList.Find(x => x.ID == v);
            }

            public void AddEdge(int start, int end)
            {
                Node startNode = GetNode(start);
                Node endNode = GetNode(end);

                if (startNode != null && endNode != null)
                    AddEdge(startNode, endNode);

            }
            public void AddEdge(Node start, Node end)
            {
                if (!start.AdjacentNodes.Contains(end))
                {
                    start.AdjacentNodes.Add(end);
                }
                if (!end.AdjacentNodes.Contains(start))
                {
                    end.AdjacentNodes.Add(start);
                }
            }

            public int[] ShortestDistances(int start)
            {
                if (nodeList.Count == 0)
                    return null;

                Node startNode = GetNode(start);
                startNode.OrderAdjacentNodes();
                int[] distances = BFS(startNode);

                for (int i = 0; i < distances.Length; i++)
                {
                    if (distances[i] > 0)
                        distances[i] *= 6;
                }

                return distances;
            }

            private int[] BFS(Node start)
             {
                int[] distances = Enumerable.Repeat(-1, nodeList.Count+1).ToArray();
                distances[start.ID] = 0;

                Queue<Node> toVisit = new Queue<Node>();
                toVisit.Enqueue(start);

                while (!(toVisit.Count == 0))
                {                        
                    Node nodeVisiting = toVisit.Dequeue();
                    if (!nodeVisiting.Visited)
                    {
                        nodeVisiting.Visited = true;

                        foreach (var adj in nodeVisiting.AdjacentNodes)
                        {
                            if (!adj.Visited)
                            {
                                if (distances[adj.ID] == -1)
                                    distances[adj.ID] = distances[nodeVisiting.ID] + 1;

                                toVisit.Enqueue(adj);
                            }
                        }
                    }
                }
                return distances;
            }
        }
    }
}
