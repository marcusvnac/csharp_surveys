using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.ProgIntervExp
{
    public class Node
    {
        
        private int _value;

        public Node(Node left, Node right, int value)
        {
            Left = left;
            Right = right;
            _value = value;
        }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get { return _value; } }

        // Used to rotate de root Node. Use only in the root!
        public Node rotateRight()
        {
            Node newRoot = Left;
            Left = newRoot.Right;
            newRoot.Right = Left;
            return newRoot;
        }
    }

    public class NodeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Node m = (Node)x, n = (Node)y;
            int mv = m.Value, nv = n.Value;
            return (mv < nv ? -1 : (mv == nv ? 0 : 1));

        }
    }

    public static class BinarySearchTree
    {
        // Lookup is an O(log(n)) operation in a balanced binary search tree.
        // Iterative version
        public static Node findNode(Node root, int value)
        {
            while (root != null)
            {
                int currVal = root.Value;

                if (currVal == value)
                    break;

                if (currVal < value)
                {
                    root = root.Right;
                }
                else
                {
                    root = root.Left;
                }
            }
            return root;
        }

        // Recursive version
        public static Node findNodeRecursive(Node root, int value)
        {
            if (root == null)
                return null;

            int currVal = root.Value;
            if (currVal == value)
            {
                return root;
            }

            if (currVal < value)
            {
                return findNodeRecursive(root.Right, value);
            }
            else
            {
                return findNodeRecursive(root.Left, value);
            }

        }

        public static int treeHeight(Node n)
        {
            if (n == null)
                return 0;

            return 1 + Math.Max(treeHeight(n.Left), treeHeight(n.Right));
        }

        public static Node findLowestCommonAncestor(Node root, int value1, int value2)
        {
            while (root != null)
            {
                int value = root.Value;

                if (value > value1 && value > value2)
                {
                    root = root.Left;
                }
                else if (value < value1 && value < value2)
                {
                    root = root.Right;
                }
                else
                {
                    return root;
                }
            }
            return null;    // only if tree is empty

        }

        #region Traversal

        public static string preorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();
            preorderTraversal(root, sb);
            return sb.ToString();

        }

        public static void preorderTraversal(Node root, StringBuilder result)
        {
            if (root == null)
                return;

            result.Append(root.Value + " ");

            preorderTraversal(root.Left, result);
            preorderTraversal(root.Right, result);
        }


        public static string preorderTraversalIterative(Node root)
        {
            Stack<Node> nodeStack = new Stack<Node>();
            StringBuilder result = new StringBuilder();

            nodeStack.Push(root);

            while (nodeStack.Count > 0)
            {
                Node curr = nodeStack.Pop();
                result.Append(curr.Value + " ");

                Node n = curr.Right;
                if (n != null)
                    nodeStack.Push(n);
                n = curr.Left;
                if (n != null)
                    nodeStack.Push(n);
            }

            return result.ToString();
        }

        public static string inorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();
            inorderTraversal(root, sb);
            return sb.ToString();

        }

        public static void inorderTraversal(Node root, StringBuilder result)
        {
            if (root == null)
                return;

            inorderTraversal(root.Left, result);
            result.Append(root.Value + " ");
            inorderTraversal(root.Right, result);
        }

        public static string postorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();
            postorderTraversal(root, sb);
            return sb.ToString();

        }

        public static void postorderTraversal(Node root, StringBuilder result)
        {
            if (root == null)
                return;

            postorderTraversal(root.Left, result);
            postorderTraversal(root.Right, result);
            result.Append(root.Value + " ");
        }

        #endregion

        

        public static Node heapifyBinaryTree(Node root)
        {
            int size = traverse(root, 0, null); // count nodes
            Node[] nodeArray = new Node[size];
            traverse(root, 0, nodeArray); // Load nods into array
            
            // sort the array based on nodes' values
            Array.Sort(nodeArray, new NodeComparer());

            // reassign children for each node
            for (int i = 0; i < size; i++)
            {
                int left = 2*i + 1;
                int right = left + 1;

                nodeArray[i].Left = (left >= size ? null : nodeArray[left]);
                nodeArray[i].Right = (right >= size ? null : nodeArray[right]);
            }
            return nodeArray[0];    // retun root node
        }

        public static int traverse(Node node, int count, Node[] arr)
        {
            if (node == null)
                return count;

            if (arr != null)
                arr[count] = node;

            count++;

            count = traverse(node.Left, count, arr);
            count = traverse(node.Right, count, arr);
            return count;
        }


    }
}
