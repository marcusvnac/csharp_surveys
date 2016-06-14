using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurvey
{
    class Node
    {
        public int Score { get; set; }
        public int Count { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            this.Score = data;
            this.Count = 1;
            this.Right = null;
            this.Left = null;
        }
    }

    class BinaryTree
    {
        Node root;
        StringBuilder result = new StringBuilder();

        public void addNode(int score)
        {
            Node newNode = new Node(score);

            if (root == null)
                root = newNode;
            else
            {
                Node alreadyInTree = searchNode(score);
                if (alreadyInTree != null)
                {
                    alreadyInTree.Count++;
                }
                else
                {
                    Node actualNode = root;
                    Node parent;

                    while (true)
                    {
                        parent = actualNode;

                        if (score < actualNode.Score)
                        {
                            actualNode = actualNode.Left;
                            if (actualNode == null)
                            {
                                parent.Left = newNode;
                                return;
                            }
                        }
                        else
                        {
                            actualNode = actualNode.Right;
                            if (actualNode == null)
                            {
                                parent.Right = newNode;
                                return;
                            }
                        }
                    }
                }
            }
        }

        private Node searchNode(int score)
        {
            Node findNode = root;

            while (findNode.Score != score)
            {
                if (score < findNode.Score)
                    findNode = findNode.Left;
                else
                    findNode = findNode.Right;

                if (findNode == null)
                    return null;
            }
            return findNode;
        }


        private string CreateSerializedTree(Node actualNode)
        {
            string serializedTree = "";
            if (actualNode != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Clear();
                queue.Enqueue(actualNode);

                while (queue.Count != 0)
                {
                    Node node = queue.Peek();
                    serializedTree = serializedTree + "," + String.Format("{0}:{1}", actualNode.Score, actualNode.Count);
                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);
                }

                CreateSerializedTree(actualNode.Left);

                result.Append(String.Format("{0}:{1}", root.Score, root.Count));

                CreateSerializedTree(actualNode.Right);
            }
            return serializedTree;
        }

        public string TreeAsString()
        {
            
            return CreateSerializedTree(root);
        }
    }

}
