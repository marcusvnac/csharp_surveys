using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.ConnectedCellsInGrid
{
    public class Solution
    {
        /*
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] grid = new int[n,m];
            for (int row = 0; row < n; row++)
            {
                string[] grid_temp = Console.ReadLine().Split(' ');
                int[] row_arr = Array.ConvertAll(grid_temp, Int32.Parse);

                for (int col = 0; col < m; col++)
                    grid[row, col] = row_arr[col];
            }

            Graph graph = new Graph();
            for (int row = 0; row < n; row ++)
            {
                for(int col = 0; col < m; col++)
                {
                    if (grid[row, col] == 1)
                    {
                        Point point = new Point(row, col);
                        Node node = new Node(point);
                        graph.AddNode(node);
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (grid[row, col] == 1)
                    {
                        Point point = new Point(row, col);
                        Node node = graph.GetNode(point);
                        graph.MakeConnexions(node, grid);
                    }
                }
            }
            Console.WriteLine(graph.LargestRegion());

        }

    */
        public class Point
        {
            private int _row, _col;

            public Point(int row, int col)
            {
                this._row = row;
                this._col = col;                
            }

            public int col { get { return this._col; } }
            public int row { get { return this._row; } }            

        }
        public class Node
        {
            private readonly Point _point;
            public Point point { get { return _point; } }
            public bool visited { get; set; }


            public HashSet<Node> neighboors { get; }

            public Node(Point point)
            {
                this._point = point;
                neighboors = new HashSet<Node>();
            }

            public void AddNeighboor(Node node)
            {
                if (!neighboors.Contains(node))
                {
                    neighboors.Add(node);
                    node.neighboors.Add(this);
                }
            }

            public void AddNeighboors(List<Node> nodes)
            {
                foreach (var node in nodes)
                {
                    AddNeighboor(node);
                }
            }
        }

        public class Graph
        {
            private List<Node> nodeList;

            public Graph()
            {
                nodeList = new List<Node>();
            }

            public void AddNode(Node node)
            {
                if (!nodeList.Contains(node))
                    nodeList.Add(node);
            }

            public Node GetNode(Point point)
            {
                return (Node)nodeList.Find(x => x.point.col == point.col && x.point.row == point.row);
            }

            public int LargestRegion()
            {
                if (nodeList.Count == 0)
                    return 0;
                else
                {
                    UnVisitNodes();
                    int maxCountConnected = 0;
                    foreach (var node in nodeList)
                    {
                        if (!node.visited)
                        {
                            int countConnected = DFS(node);
                            if (maxCountConnected < countConnected)
                                maxCountConnected = countConnected;
                        }
                    }
                    return maxCountConnected;
                }
            }

            private int DFS(Node root)
            {
                if (root == null)
                    return 0;
                root.visited = true;
                int countConnected = 1;

                foreach (var node in root.neighboors)
                {
                    if (!node.visited)
                        countConnected += DFS(node);
                }
                return countConnected;
            }

            private void UnVisitNodes()
            {
                foreach (var node in nodeList)
                {
                    node.visited = false;
                } 
            }

            public void MakeConnexions(Node node, int[,] grid)
            {
                List<Node> result = new List<Node>();

                int actualRow, actualCol;

                // Row above  
                
                actualRow = node.point.row - 1;
                actualCol = node.point.col - 1;
                if (actualRow > 0 && actualCol > 0 && grid[actualRow, actualCol] == 1)
                    result.Add(GetNode(new Point(actualRow, actualCol)));

                actualRow = node.point.row - 1;
                actualCol = node.point.col;
                if (actualRow > 0 && grid[actualRow, actualCol] == 1)
                    result.Add(GetNode(new Point(actualRow, actualCol)));

                actualRow = node.point.row - 1;
                actualCol = node.point.col + 1;
                if (actualRow > 0 && actualCol < grid.GetLength(1) && grid[actualRow, actualCol] == 1)
                    result.Add(GetNode(new Point(actualRow, actualCol)));

                /// Same row
                actualRow = node.point.row;
                actualCol = node.point.col - 1;
                if (actualCol > 0 && grid[actualRow, actualCol] == 1)
                    result.Add(GetNode(new Point(actualRow, actualCol)));

                actualRow = node.point.row;
                actualCol = node.point.col + 1;
                if (actualCol < grid.GetLength(1) && grid[actualRow, actualCol] == 1)
                    result.Add(GetNode(new Point(actualRow, actualCol)));

                // row below
                actualRow = node.point.row + 1;
                actualCol = node.point.col - 1;
                if (actualRow < grid.GetLength(0) && actualCol > 0 && grid[actualRow, actualCol] == 1)
                    result.Add(GetNode(new Point(actualRow, actualCol)));

                actualRow = node.point.row + 1;
                actualCol = node.point.col;
                if (actualRow < grid.GetLength(0) && grid[actualRow, actualCol] == 1)
                    result.Add(GetNode(new Point(actualRow, actualCol)));

                actualRow = node.point.row + 1;
                actualCol = node.point.col + 1;
                if (actualRow < grid.GetLength(0) && actualCol < grid.GetLength(1) && grid[actualRow, actualCol] == 1)
                    result.Add(GetNode(new Point(actualRow, actualCol)));

                node.AddNeighboors(result);
            }
        }
    }
}
