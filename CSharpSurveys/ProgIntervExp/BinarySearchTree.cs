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
        public Node(Node left, Node right, int value)
        {
            Left = left;
            Right = right;
            Value = value;
        }

        public Node(int value)
        {
            Value = value;
        }

        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }

        // Used to rotate de root Node. Use only in the root!
        public Node rotateRight()
        {
            Node newRoot = Left;
            Left = newRoot.Right;
            newRoot.Right = this;
            return newRoot;
        }
    }
     /***********************************************************************/
    public class NodeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Node m = (Node)x, n = (Node)y;
            int mv = m.Value, nv = n.Value;
            return (mv < nv ? -1 : (mv == nv ? 0 : 1));

        }
    }
    /***********************************************************************/
    public static class BinarySearchTree
    {
        // Used in IsBalanced Method
        private class Height
        {
            public int height { get; set; }
            public int lh { get; set; } // Height of left subtree
            public int rh { get; set; } // Height of right subtree
        }

        public static bool AddNote(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
                return true;
            }
            else
            {
                Node alreadyInTree = FindNode(root, newNode.Value);
                if (alreadyInTree != null)
                {   // Node is already in tree
                    return false;
                }
                else
                {
                    Node actualNode = root;
                    Node parent;
                    int value = newNode.Value;

                    while (true)
                    {
                        parent = actualNode;

                        if (value < actualNode.Value)
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

        }

        #region Remove Methods
        public static Node RemoveNode(Node root, int value)
        {
            /* Base Case: If the tree is empty */
            if (root == null)
                return root;

            /* Otherwise, recur down the tree */
            if (value < root.Value)
                root.Left = RemoveNode(root.Left, value);
            else if (value > root.Value)
                root.Right = RemoveNode(root.Right, value);
            // if key is same as root's key, then This is the node to be deleted
            else
            {
                // node with only one child or no child
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                // node with two children: Get the inorder successor (smallest in the right subtree)
                root.Value = minValue(root.Right);

                // Delete the inorder successor
                root.Right = RemoveNode(root.Right, root.Value);
            }

            return root;
        }

        private static int minValue(Node root)
        {
            int minv = root.Value;
            while (root.Left != null)
            {
                minv = root.Left.Value;
                root = root.Left;
            }
            return minv;
        }

        #endregion

        // O(n^2)
        public static bool IsBalanced2(Node root)
        {
            int lh; /* for height of left subtree */

            int rh; /* for height of right subtree */

            /* If tree is empty then return true */
            if (root == null)
                return true;

            /* Get the height of left and right sub trees */
            lh = TreeHeight(root.Left);
            rh = TreeHeight(root.Right);

            if (Math.Abs(lh - rh) <= 1
                    && IsBalanced(root.Left)
                    && IsBalanced(root.Right))
                return true;

            /* If we reach here then tree is not height-balanced */
            return false;
        }

        // O(n)

        public static bool IsBalanced(Node root)
        {
            int lh; /* for height of left subtree */

            int rh; /* for height of right subtree */

            /* If tree is empty then return true */
            if (root == null)
                return true;

            /* Get the height of left and right sub trees */
            lh = TreeHeight(root.Left);
            rh = TreeHeight(root.Right);

            if (Math.Abs(lh - rh) <= 1
                    && IsBalanced(root.Left)
                    && IsBalanced(root.Right))
                return true;

            /* If we reach here then tree is not height-balanced */
            return false;
        }

        private static bool IsBalanced(Node root, Height height)
        {
            /* l will be true if left subtree is balanced 
               and r will be true if right subtree is balanced */
            bool l = false, r = false;

            /* If tree is empty then return true */
            if (root == null)
            {
                height.height = 0;
                return true;
            }

            /* Get the height of left and right sub trees */
            l = IsBalanced(root.Left, height);
            r = IsBalanced(root.Right, height);

            /* If difference between heights of left and right 
               subtrees is more than 2 then this node is not balanced
               so return 0 */
            if ((height.lh - height.rh >= 2) || (height.rh - height.lh >= 2))
                return false;

            /* If this node is balanced and left and right subtrees 
               are balanced then return true */
            else
                return l && r;

        }

        // Lookup is an O(log(n)) operation in a balanced binary search tree. (Depth-First Search)
        // Iterative version
        public static Node FindNode(Node root, int value)
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

        public static Node FindNode(Node root, Node value)
        {
            return FindNode(root, value.Value);
        }

        // Recursive version
        public static Node FindNodeRecursive(Node root, int value)
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
                return FindNodeRecursive(root.Right, value);
            }
            else
            {
                return FindNodeRecursive(root.Left, value);
            }

        }

        public static int TreeHeight(Node n)
        {
            if (n == null)
                return 0;

            return 1 + Math.Max(TreeHeight(n.Left), TreeHeight(n.Right));
        }

        public static Node FindLowestCommonAncestor(Node root, int value1, int value2)
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
        public static string BreadthFirstSearchTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();
            BreadthFirstSearchTraversal(root, sb);
            return sb.ToString();
        }

        private static void BreadthFirstSearchTraversal(Node root, StringBuilder result)
        {
            if (root != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    Node node = queue.Dequeue();
                    result.Append(node.Value + " ");
                    
                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }
            }
        }
       
        // Preorder, Postorder and Inorder Traversals are Depth First Search

        public static string PreorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();
            PreorderTraversal(root, sb);
            return sb.ToString();

        }

        private static void PreorderTraversal(Node root, StringBuilder result)
        {
            if (root == null)
                return;

            result.Append(root.Value + " ");

            PreorderTraversal(root.Left, result);
            PreorderTraversal(root.Right, result);
        }

        public static string PreorderTraversalIterative(Node root)
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

        public static string InorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();
            InorderTraversal(root, sb);
            return sb.ToString();

        }

        private static void InorderTraversal(Node root, StringBuilder result)
        {
            if (root == null)
                return;

            InorderTraversal(root.Left, result);
            result.Append(root.Value + " ");
            InorderTraversal(root.Right, result);
        }

        public static string PostorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();
            PostorderTraversal(root, sb);
            return sb.ToString();

        }

        private static void PostorderTraversal(Node root, StringBuilder result)
        {
            if (root == null)
                return;

            PostorderTraversal(root.Left, result);
            PostorderTraversal(root.Right, result);
            result.Append(root.Value + " ");
        }

        #endregion


        #region Heapify
        public static Node HeapifyBinaryTree(Node root)
        {
            int size = TraverseCounting(root, 0, null); // count nodes
            Node[] nodeArray = new Node[size];
            TraverseCounting(root, 0, nodeArray); // Load nods into array
            
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

        private static int TraverseCounting(Node node, int count, Node[] arr)
        {
            if (node == null)
                return count;

            if (arr != null)
                arr[count] = node;

            count++;

            count = TraverseCounting(node.Left, count, arr);
            count = TraverseCounting(node.Right, count, arr);
            return count;
        }

        #endregion
    }
}
